using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Drawing.Imaging;
using System.Net;

namespace Smart_Library.Forms1
{
    public partial class FormStudents : Form
    {
        DataTable dt = new DataTable();
        string studentImage = Login_Form.studentImage;
        public FormStudents()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tIWLGRVsVY09Eu0K9sYsGExA2FUfCzcenf4C98Ch",
            BasePath = "https://learn-test-mode.firebaseio.com/"
        };
        IFirebaseClient client;

        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadTheme();

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("There's was problem in the Internet! Please try again.");
            }

            dt.Columns.Add("RollNo");
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Author");
            dt.Columns.Add("Borrow");
            dt.Columns.Add("Overdue");
            dt.Columns.Add("Duedate");

            dataGridView2.DataSource = dt;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }

            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void txtStudentidInput_OnValueChanged(object sender, EventArgs e)
        {
            txtStudentidInput.ForeColor = ThemeColor.SecondaryColor;
        }

        private void txtStudentidInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                export();
            }
        }

        private void export()
        {
            // Retrieve information of Student
            try
            {
                var result = client.Get("StudentList/" + txtStudentidInput.Text);
                Student std = result.ResultAs<Student>();
                txtfullname.Text = std.name;
                txtStudentid.Text = std.id;
                txtMajor.Text = std.major;
            }
            catch
            {
                MessageBox.Show("No Student id has available.");
            }


            // Image Retrieve
            pictureBox1.Image = null;


            WebRequest request = WebRequest.Create(studentImage);
            using (var response1 = request.GetResponse())
            {
                using (var str = response1.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(str);
                }
            }

            // Retrieve DatagridView Book
            dt.Rows.Clear();
            int i = 0;

            FirebaseResponse resp1  =  client.Get("Users/" + txtStudentidInput.Text + "/book");
            Counter_class bookcount = resp1.ResultAs<Counter_class>();
            int count = Convert.ToInt32(bookcount.count);

            while (true)
            {
                if (i == count)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp3 = client.Get("User/" + txtStudentidInput.Text + "/book/Sno/" + i);
                    Student idbook_sno = resp3.ResultAs<Student>(); // Lay so thu tu cua Sno


                    FirebaseResponse resp2 = client.Get("Users/" + txtStudentidInput.Text + "/book/" + idbook_sno.id); //Lay ma so id_sno
                    Data obj2 = resp2.ResultAs<Data>();

                    // Lay name, author
                    //FirebaseResponse resp4 = await client.GetTaskAsync(obj2.Position); //Lay ma so id_sno
                    //Data obj4 = resp4.ResultAs<Data>();

                    DataRow row = dt.NewRow();
                    row["RollNo"] = i;
                    row["Id"] = obj2.id;
                   // row["Name"] = obj4.Product_name;
                   // row["Author"] = obj4.Product_tacgia;
                    row["Borrow"] = obj2.mfg;                    
                    row["Duedate"] = obj2.exp;             
                    
                    dt.Rows.Add(row);                    
                }
                catch
                {

                }
            }
            MessageBox.Show("Successfull!");
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            export();
        }
    }
}
