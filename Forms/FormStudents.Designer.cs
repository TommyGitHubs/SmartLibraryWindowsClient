namespace RandomMultiColorThemes.Forms
{
    partial class FormStudents
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnStudents = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(262, 169);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(236, 30);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "This is  Manage Student";
            // 
            // btnStudents
            // 
            this.btnStudents.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudents.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudents.BorderRadius = 0;
            this.btnStudents.ButtonText = "BUTTON";
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudents.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudents.Iconimage = null;
            this.btnStudents.Iconimage_right = null;
            this.btnStudents.Iconimage_right_Selected = null;
            this.btnStudents.Iconimage_Selected = null;
            this.btnStudents.IconMarginLeft = 0;
            this.btnStudents.IconMarginRight = 0;
            this.btnStudents.IconRightVisible = true;
            this.btnStudents.IconRightZoom = 0D;
            this.btnStudents.IconVisible = true;
            this.btnStudents.IconZoom = 90D;
            this.btnStudents.IsTab = false;
            this.btnStudents.Location = new System.Drawing.Point(294, 218);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudents.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStudents.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudents.selected = false;
            this.btnStudents.Size = new System.Drawing.Size(172, 91);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "BUTTON";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudents.Textcolor = System.Drawing.Color.White;
            this.btnStudents.TextFont = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 435);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.lblStudents);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudents;
    }
}