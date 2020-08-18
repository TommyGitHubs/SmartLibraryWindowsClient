namespace RandomMultiColorThemes.Forms
{
    partial class FormBooks
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
            this.lblBooks = new System.Windows.Forms.Label();
            this.btnbooks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.Location = new System.Drawing.Point(285, 167);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(265, 30);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "This is Manage Book Space";
            // 
            // btnbooks
            // 
            this.btnbooks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnbooks.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbooks.BorderRadius = 0;
            this.btnbooks.ButtonText = "BUTTON";
            this.btnbooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbooks.DisabledColor = System.Drawing.Color.Gray;
            this.btnbooks.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnbooks.Iconimage = null;
            this.btnbooks.Iconimage_right = null;
            this.btnbooks.Iconimage_right_Selected = null;
            this.btnbooks.Iconimage_Selected = null;
            this.btnbooks.IconMarginLeft = 0;
            this.btnbooks.IconMarginRight = 0;
            this.btnbooks.IconRightVisible = true;
            this.btnbooks.IconRightZoom = 0D;
            this.btnbooks.IconVisible = true;
            this.btnbooks.IconZoom = 90D;
            this.btnbooks.IsTab = false;
            this.btnbooks.Location = new System.Drawing.Point(333, 217);
            this.btnbooks.Margin = new System.Windows.Forms.Padding(6);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnbooks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnbooks.OnHoverTextColor = System.Drawing.Color.White;
            this.btnbooks.selected = false;
            this.btnbooks.Size = new System.Drawing.Size(172, 91);
            this.btnbooks.TabIndex = 2;
            this.btnbooks.Text = "BUTTON";
            this.btnbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbooks.Textcolor = System.Drawing.Color.White;
            this.btnbooks.TextFont = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 446);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.lblBooks);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooks;
        private Bunifu.Framework.UI.BunifuFlatButton btnbooks;
    }
}