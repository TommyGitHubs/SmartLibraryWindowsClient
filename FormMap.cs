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

namespace Smart_Library
{
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "tIWLGRVsVY09Eu0K9sYsGExA2FUfCzcenf4C98Ch",
            BasePath = "https://learn-test-mode.firebaseio.com/"
        };
        IFirebaseClient client;


        private void FormMap_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                string image = Forms1.Booking.mapbook;
                WebRequest request = WebRequest.Create(image);
                //MessageBox.Show(image);
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
    }
}
