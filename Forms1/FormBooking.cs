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
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.EventStreaming;
using FireSharp.Extensions;
using System.Drawing.Imaging;

namespace Smart_Library.Forms1
{
    public partial class FormBooking : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cN3BdjyhiY7jT0lxjv8AjBJ0Eh59O2jlWdFp3q2n",
            BasePath = "https://teoshop-7e4a7.firebaseio.com/"
        };
        IFirebaseClient client;
        public FormBooking()
        {
            InitializeComponent();
            LoadTheme();
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
            btnOk.ForeColor = ThemeColor.PrimaryColor;


        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            
        }

        private void main()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
