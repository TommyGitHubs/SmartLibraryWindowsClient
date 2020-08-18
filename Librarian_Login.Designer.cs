namespace Smart_Library
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkstudent = new System.Windows.Forms.LinkLabel();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.minimizebtn = new System.Windows.Forms.PictureBox();
            this.linklibrarian = new System.Windows.Forms.LinkLabel();
            this.btnstudentlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.iconerror = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconerror)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(29, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Smart Library";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(67, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "SL";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.Visible = false;
            this.lineShape3.X1 = 307;
            this.lineShape3.X2 = 715;
            this.lineShape3.Y1 = 156;
            this.lineShape3.Y2 = 156;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 307;
            this.lineShape2.X2 = 715;
            this.lineShape2.Y1 = 156;
            this.lineShape2.Y2 = 156;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 310;
            this.lineShape1.X2 = 717;
            this.lineShape1.Y1 = 100;
            this.lineShape1.Y2 = 100;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.DimGray;
            this.usertxt.Location = new System.Drawing.Point(309, 78);
            this.usertxt.MaxLength = 20;
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(408, 22);
            this.usertxt.TabIndex = 1;
            this.usertxt.Text = "USER";
            this.usertxt.Enter += new System.EventHandler(this.usertxt_Enter);
            this.usertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usertxt_KeyPress);
            this.usertxt.Leave += new System.EventHandler(this.usertxt_Leave);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtxt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.Color.DimGray;
            this.passwordtxt.Location = new System.Drawing.Point(310, 133);
            this.passwordtxt.MaxLength = 20;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(408, 22);
            this.passwordtxt.TabIndex = 2;
            this.passwordtxt.Text = "PASSWORD";
            this.passwordtxt.Enter += new System.EventHandler(this.passwordtxt_Enter);
            this.passwordtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtxt_KeyPress);
            this.passwordtxt.Leave += new System.EventHandler(this.passwordtxt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(534, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            // 
            // loginbtn
            // 
            this.loginbtn.Activecolor = System.Drawing.Color.Black;
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbtn.BorderRadius = 0;
            this.loginbtn.ButtonText = "LOGIN";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.DisabledColor = System.Drawing.Color.Gray;
            this.loginbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.loginbtn.Iconimage = null;
            this.loginbtn.Iconimage_right = null;
            this.loginbtn.Iconimage_right_Selected = null;
            this.loginbtn.Iconimage_Selected = null;
            this.loginbtn.IconMarginLeft = 0;
            this.loginbtn.IconMarginRight = 0;
            this.loginbtn.IconRightVisible = true;
            this.loginbtn.IconRightZoom = 0D;
            this.loginbtn.IconVisible = true;
            this.loginbtn.IconZoom = 90D;
            this.loginbtn.IsTab = false;
            this.loginbtn.Location = new System.Drawing.Point(310, 215);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loginbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.loginbtn.selected = false;
            this.loginbtn.Size = new System.Drawing.Size(408, 43);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.Textcolor = System.Drawing.Color.White;
            this.loginbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // linkstudent
            // 
            this.linkstudent.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkstudent.AutoSize = true;
            this.linkstudent.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkstudent.LinkColor = System.Drawing.Color.DimGray;
            this.linkstudent.Location = new System.Drawing.Point(450, 290);
            this.linkstudent.Name = "linkstudent";
            this.linkstudent.Size = new System.Drawing.Size(106, 17);
            this.linkstudent.TabIndex = 0;
            this.linkstudent.TabStop = true;
            this.linkstudent.Text = "Are you student?";
            this.linkstudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkstudent_LinkClicked);
            // 
            // closebtn
            // 
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(762, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(15, 15);
            this.closebtn.TabIndex = 7;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizebtn.Image")));
            this.minimizebtn.Location = new System.Drawing.Point(741, 3);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(15, 15);
            this.minimizebtn.TabIndex = 8;
            this.minimizebtn.TabStop = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // linklibrarian
            // 
            this.linklibrarian.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linklibrarian.AutoSize = true;
            this.linklibrarian.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklibrarian.LinkColor = System.Drawing.Color.DimGray;
            this.linklibrarian.Location = new System.Drawing.Point(450, 290);
            this.linklibrarian.Name = "linklibrarian";
            this.linklibrarian.Size = new System.Drawing.Size(111, 17);
            this.linklibrarian.TabIndex = 9;
            this.linklibrarian.TabStop = true;
            this.linklibrarian.Text = "Are you librarian?";
            this.linklibrarian.Visible = false;
            this.linklibrarian.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklibrarian_LinkClicked);
            // 
            // btnstudentlogin
            // 
            this.btnstudentlogin.Activecolor = System.Drawing.Color.Black;
            this.btnstudentlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnstudentlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstudentlogin.BorderRadius = 0;
            this.btnstudentlogin.ButtonText = "LOGIN ST";
            this.btnstudentlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstudentlogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnstudentlogin.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnstudentlogin.Iconimage = null;
            this.btnstudentlogin.Iconimage_right = null;
            this.btnstudentlogin.Iconimage_right_Selected = null;
            this.btnstudentlogin.Iconimage_Selected = null;
            this.btnstudentlogin.IconMarginLeft = 0;
            this.btnstudentlogin.IconMarginRight = 0;
            this.btnstudentlogin.IconRightVisible = true;
            this.btnstudentlogin.IconRightZoom = 0D;
            this.btnstudentlogin.IconVisible = true;
            this.btnstudentlogin.IconZoom = 90D;
            this.btnstudentlogin.IsTab = false;
            this.btnstudentlogin.Location = new System.Drawing.Point(310, 215);
            this.btnstudentlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnstudentlogin.Name = "btnstudentlogin";
            this.btnstudentlogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnstudentlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnstudentlogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnstudentlogin.selected = false;
            this.btnstudentlogin.Size = new System.Drawing.Size(408, 43);
            this.btnstudentlogin.TabIndex = 10;
            this.btnstudentlogin.Text = "LOGIN ST";
            this.btnstudentlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnstudentlogin.Textcolor = System.Drawing.Color.White;
            this.btnstudentlogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentlogin.Visible = false;
            this.btnstudentlogin.Click += new System.EventHandler(this.btnstudentlogin_Click);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtstudentid.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.ForeColor = System.Drawing.Color.DimGray;
            this.txtstudentid.Location = new System.Drawing.Point(309, 134);
            this.txtstudentid.MaxLength = 20;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(408, 22);
            this.txtstudentid.TabIndex = 11;
            this.txtstudentid.Text = "STUDENT ID";
            this.txtstudentid.Visible = false;
            this.txtstudentid.TextChanged += new System.EventHandler(this.txtstudentid_TextChanged);
            this.txtstudentid.Enter += new System.EventHandler(this.txtstudentid_Enter);
            this.txtstudentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentid_KeyPress);
            this.txtstudentid.Leave += new System.EventHandler(this.txtstudentid_Leave);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DimGray;
            this.lblErrorMessage.Location = new System.Drawing.Point(320, 175);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(95, 17);
            this.lblErrorMessage.TabIndex = 12;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // iconerror
            // 
            this.iconerror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconerror.Image = ((System.Drawing.Image)(resources.GetObject("iconerror.Image")));
            this.iconerror.Location = new System.Drawing.Point(309, 177);
            this.iconerror.Name = "iconerror";
            this.iconerror.Size = new System.Drawing.Size(15, 15);
            this.iconerror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconerror.TabIndex = 13;
            this.iconerror.TabStop = false;
            this.iconerror.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.iconerror);
            this.Controls.Add(this.btnstudentlogin);
            this.Controls.Add(this.linklibrarian);
            this.Controls.Add(this.minimizebtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.linkstudent);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Form_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton loginbtn;
        private System.Windows.Forms.LinkLabel linkstudent;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox minimizebtn;
        private System.Windows.Forms.LinkLabel linklibrarian;
        private Bunifu.Framework.UI.BunifuFlatButton btnstudentlogin;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.PictureBox iconerror;
    }
}

