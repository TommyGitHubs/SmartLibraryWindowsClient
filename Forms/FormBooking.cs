using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMultiColorThemes.Forms
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
           
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lblBooksing.ForeColor = ThemeColor.SecondaryColor;
            btnbooking.BackColor = ThemeColor.SecondaryColor;
        }
    }
}
