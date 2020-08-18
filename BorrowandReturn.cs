using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Net;
//using BorrowandReturn;

namespace Smart_Library.BorrowingandReturnBook
{
    public partial class FormMainMenu : Form
    {
        string str1, str2, str3, txtidstudent1;
        string studentName, studentMajor, studentImage;
        DateTime dt = DateTime.Now;
        DataTable dtable = new DataTable();
        private void txtReturnBook_Click(object sender, EventArgs e)
        {
            returnbook();
        }

        public FormMainMenu()
        {
            InitializeComponent();            
            lblStudentID.Text = Login_Form.idstudent1;
            txtidstudent1 = Login_Form.idstudent1;
            studentImage = Login_Form.studentImage;
            studentMajor = Login_Form.studentMajor;
            studentName = Login_Form.studentName;
            
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cN3BdjyhiY7jT0lxjv8AjBJ0Eh59O2jlWdFp3q2n",
            BasePath = "https://teoshop-7e4a7.firebaseio.com/"
        };
        IFirebaseClient client;

        private void BorrowandReturn_Load(object sender, EventArgs e)
        {            
            try
            {
                client = new FireSharp.FirebaseClient(config);
                studentName = Login_Form.studentName;
                studentMajor = Login_Form.studentMajor;
                studentImage = Login_Form.studentImage;
                lblMajor.Text = studentMajor;
                lblName.Text = studentName;
                lblStudentID.Text = txtidstudent1;

                dtable.Columns.Add("ID");
                dtable.Columns.Add("Name");
                dtable.Columns.Add("Author");
                dataGridView2.DataSource = dtable;

                // Image Retrieve
                pictureBox1.Image = null;
                //FirebaseResponse response = client.Get("Users/" + txtidstudent1 + "@student,hcmute,edu,vn");
                //Image_Modal image = response.ResultAs<Image_Modal>();

                WebRequest request = WebRequest.Create(studentImage);
                using (var response1 = request.GetResponse())
                {
                    using (var str = response1.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(str);
                    }
                }
            }
            
            catch
            {
                MessageBox.Show("There's was problem in the Internet! Please try again.");
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Random = new Login_Form();
            Random.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Random = new Login_Form();
            Random.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            borrowbook();
        }

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == (char)Keys.Enter)
                {
                    int id = txtBookID.Text.IndexOf("id");
                    str1 = txtBookID.Text.Substring(0, 3);
                    str2 = txtBookID.Text.Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
                    str3 = txtBookID.Text.Substring(id + 2, 3); // Start get id after 'id'  

                    // Lay dia chi cua sach, Get product_name, product_tacgia, POPH1/
                    FirebaseResponse response = client.Get(str1 + "/" + str2);
                    BookInfo result = response.ResultAs<BookInfo>();

                    DataRow row = dtable.NewRow();
                    //row["ID"] = result.id;
                    row["Name"] = result.product_name;
                    row["Author"] = result.product_tacgia;
                    row["ID"] = txtBookID.Text;
                    dtable.Rows.Add(row);

                // lay id POPH1id001/id
                    txtBookID.Text = "";
                }
            
        }

        private void borrowbook()
        {
            try
            {
                string idbook;
                int i = 0;

                while (true)
                {
                    idbook = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    //MessageBox.Show(idbook);
                    i++;

                    int id = idbook.IndexOf("id");
                    str1 = idbook.Substring(0, 3);
                    str2 = idbook.Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
                    str3 = idbook.Substring(id + 2, 3); // Start get id after 'id'
                    int count = 0;

                    //FirebaseResponse response5 = client.Get(@"Users/" + txtidstudent1 + "@student,hcmute,edu,vn/borrow/sach");
                    //Data result1 = response5.ResultAs<Data>();

                    var book = new Data
                    {
                        mfg = DateTime.Now.ToString("dd/MM/yyyy"),
                        exp = "20/7/2020",
                        id = idbook,
                    };

                    
                    FirebaseResponse response4 = client.Get(str1 + "/" + str2);
                    CategoryBook product_Soluong = response4.ResultAs<CategoryBook>();
                    count = product_Soluong.product_soluong - 1;
                    //MessageBox.Show(count.ToString());
                    FirebaseResponse response6 = client.Set(str1 + "/" + str2 + "/product_soluong",count);
                    FirebaseResponse response2 = client.Update(@"Users/" + txtidstudent1 + "@student,hcmute,edu,vn/borrow/sach/" + idbook, book);
                    FirebaseResponse response3 = client.Set(str1 + "/" + str2 + "/id/" + str3 + "/status/", "onn");   // Status book onn: Da muon
                }
            }
            catch
            {
                MessageBox.Show("Done");              
            }
            
        }

        private void returnbook()
        {
            try
            {
                string idbook;
                int i = 0;

                while (true)
                {
                    idbook = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    //MessageBox.Show(idbook);
                    i++;

                    int id = idbook.IndexOf("id");
                    str1 = idbook.Substring(0, 3);
                    str2 = idbook.Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
                    str3 = idbook.Substring(id + 2, 3); // Start get id after 'id'


                    //FirebaseResponse response5 = client.Get(@"Users/" + txtidstudent1 + "@student,hcmute,edu,vn/borrow");
                    //Data result1 = response5.ResultAs<Data>();

                    var book = new Data
                    {
                        returndate = DateTime.Now.ToString("dd/MM/yyyy"),
                        id = idbook,
                    };
                    int count = 0;
                    FirebaseResponse response7 = client.Get(str1 + "/" + str2);
                    CategoryBook product_Soluong = response7.ResultAs<CategoryBook>();
                    count = product_Soluong.product_soluong + 1;
                    //MessageBox.Show(count.ToString());
                    FirebaseResponse response6 = client.Set(str1 + "/" + str2 + "/product_soluong", count);
                    FirebaseResponse response5 = client.Set(@"Users/" + txtidstudent1 + "@student,hcmute,edu,vn/history/" + idbook, book);                                                
                    FirebaseResponse response3 = client.Delete(@"Users/" + txtidstudent1 + "@student,hcmute,edu,vn/borrow/sach/" + idbook);
                    FirebaseResponse response4 = client.Set(str1 + "/" + str2 + "/id/" + str3 + "/status", "off");   // Status book
                }
            }
            catch
            {
                MessageBox.Show("Done");
            }
        }

        private void getdata()
        {
            // Check status book (not check book is exist)               
            int id = txtBookID.Text.IndexOf("id");
            str1 = txtBookID.Text.Substring(0, 3);
            str2 = txtBookID.Text.Substring(3, id - 3); // If Hx get 2 character, Hxx get 3 character, Hxxx get 4 character ...
            str3 = txtBookID.Text.Substring(id + 2, 3); // Start get id after 'id'          
        }

    }
}
