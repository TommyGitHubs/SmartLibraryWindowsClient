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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace Smart_Library
{
    public partial class Login_Form : Form
    {
        public static string studentName, studentMajor, studentImage;
        public static string idstudent1; // bien ID student can chuyen
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cN3BdjyhiY7jT0lxjv8AjBJ0Eh59O2jlWdFp3q2n",
            BasePath = "https://teoshop-7e4a7.firebaseio.com/"
        };
        IFirebaseClient client;

        public Login_Form()
        {
            InitializeComponent();           
        }
        // Di chuyen giao dien
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void usertxt_Enter(object sender, EventArgs e)
        {
            if (usertxt.Text == "USER")
            {
                usertxt.Text = "";
                usertxt.ForeColor = Color.LightGray;
            }
        }

        private void usertxt_Leave(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                usertxt.Text = "USER";
                usertxt.ForeColor = Color.DimGray;
            }
        }

        private void passwordtxt_Enter(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "PASSWORD")
            {
                passwordtxt.Text = "";
                passwordtxt.ForeColor = Color.LightGray;
                passwordtxt.UseSystemPasswordChar = true;
            }
        }

        private void passwordtxt_Leave(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passwordtxt.Text = "PASSWORD";
                passwordtxt.ForeColor = Color.DimGray;
                passwordtxt.UseSystemPasswordChar = false;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkstudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkstudent.Hide();
            usertxt.Hide();
            passwordtxt.Hide();
            lineShape1.Hide();
            lineShape2.Hide();
            btnstudentlogin.Hide();
            loginbtn.Hide();

            linklibrarian.Show();
            txtstudentid.Show();
            lineShape3.Show();
        }

        private void linklibrarian_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklibrarian.Hide();
            btnstudentlogin.Hide();
            txtstudentid.Hide();
            lineShape3.Hide();

            linkstudent.Show();
            usertxt.Show();
            passwordtxt.Show();
            lineShape1.Show();
            lineShape2.Show();
            loginbtn.Show();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            login();
        }

        private void passwordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }


        private void login()
        {
            if (usertxt.Text == "USER" && passwordtxt.Text == "PASSWORD")
            {
                msgError("Plesase fill in the USER and PASSWORD!");
                return;
            }

            if (usertxt.Text == "" || passwordtxt.Text == "")
            {
                msgError("Plesase fill in the USER and PASSWORD!");
                return;
            }

            if (usertxt.Text == "USER" || passwordtxt.Text == "PASSWORD")
            {
                msgError("Plesase fill in the USER and PASSWORD!");
                return;
            }


            //Student resultuser = new Student();
            admin resultuser = new admin();
            try
            {
                FirebaseResponse response = client.Get(@"admin/" + usertxt.Text);

                //resultuser = response.ResultAs<Student>();
                resultuser = response.ResultAs<admin>();
                //MessageBox.Show(resultuser.passwordBcrypt);
            }
            catch
            {
                msgError("Username does not exits.");
            }

            // Reset Bcrypt password
            //string resetbcrypt = BCrypt.Net.BCrypt.HashString(resultuser.password);
            //FirebaseResponse response2 =  client.Set(@"users/admin/"+resultuser.username+"/password", resetbcrypt);


            //Student curentuser = new Student()
            admin curentuser = new admin()
            {
                // Verify 
                username = usertxt.Text,
                passwordBcrypt = passwordtxt.Text
            };
            //MessageBox.Show(curentuser.passwordBcrypt);


            if (curentuser.username == resultuser.username)
            {
                //MessageBox.Show("Pass Input: "+curentuser.password + "\nBrypt: " +resultuser.passwordBcrypt);
                //MessageBox.Show(BCrypt.Net.BCrypt.Verify(passwordtxt.Text,resultuser.passwordBcrypt).ToString());
               if(BCrypt.Net.BCrypt.Verify(passwordtxt.Text,resultuser.passwordBcrypt))
               {
                    MessageBox.Show("Welcome "+ curentuser.username);
                    this.Hide();
                    Librarian_Login Random = new Librarian_Login();
                    Random.ShowDialog();
               }
               else
               {
                    msgError("Password is invalid.");
               }                                
            }
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "   " + msg;
            lblErrorMessage.Visible = true;
            iconerror.Visible = true;
        }

        private void usertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void btnstudentlogin_Click(object sender, EventArgs e)
        {
            studentlogin();
        }

        private void studentlogin()
        {

            FirebaseResponse response = client.Get(@"Users/" + txtstudentid.Text + "@student,hcmute,edu,vn");
            Student resultuser = response.ResultAs<Student>();

            idstudent1 = txtstudentid.Text;
            studentName = resultuser.name;
            studentMajor = resultuser.major;
            studentImage = resultuser.image;
            this.Hide();
            BorrowingandReturnBook.FormMainMenu Random = new BorrowingandReturnBook.FormMainMenu();
            Random.ShowDialog();
        }


        private void txtstudentid_Enter(object sender, EventArgs e)
        {
            if (txtstudentid.Text == "STUDENT ID")
            {
                txtstudentid.Text = "";
                txtstudentid.ForeColor = Color.DimGray;
            }
        }

        private void txtstudentid_Leave(object sender, EventArgs e)
        {
            if (txtstudentid.Text == "")
            {
                txtstudentid.Text = "STUDENT ID";
                txtstudentid.ForeColor = Color.DimGray;
            }
        }

        private void txtstudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                studentlogin();
            }
        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}  


