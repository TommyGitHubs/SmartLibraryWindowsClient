namespace RandomMultiColorThemes.Forms
{
    partial class FormBooking
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
            this.lblBooksing = new System.Windows.Forms.Label();
            this.btnbooking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblBooksing
            // 
            this.lblBooksing.AutoSize = true;
            this.lblBooksing.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksing.Location = new System.Drawing.Point(317, 186);
            this.lblBooksing.Name = "lblBooksing";
            this.lblBooksing.Size = new System.Drawing.Size(281, 30);
            this.lblBooksing.TabIndex = 0;
            this.lblBooksing.Text = "This is Booking Management";
            // 
            // btnbooking
            // 
            this.btnbooking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnbooking.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.btnbooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnbooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbooking.BorderRadius = 0;
            this.btnbooking.ButtonText = "BUTTON";
            this.btnbooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbooking.DisabledColor = System.Drawing.Color.Gray;
            this.btnbooking.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooking.Iconcolor = System.Drawing.Color.Transparent;
            this.btnbooking.Iconimage = null;
            this.btnbooking.Iconimage_right = null;
            this.btnbooking.Iconimage_right_Selected = null;
            this.btnbooking.Iconimage_Selected = null;
            this.btnbooking.IconMarginLeft = 0;
            this.btnbooking.IconMarginRight = 0;
            this.btnbooking.IconRightVisible = true;
            this.btnbooking.IconRightZoom = 0D;
            this.btnbooking.IconVisible = true;
            this.btnbooking.IconZoom = 90D;
            this.btnbooking.IsTab = false;
            this.btnbooking.Location = new System.Drawing.Point(361, 232);
            this.btnbooking.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnbooking.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnbooking.OnHoverTextColor = System.Drawing.Color.White;
            this.btnbooking.selected = false;
            this.btnbooking.Size = new System.Drawing.Size(172, 91);
            this.btnbooking.TabIndex = 1;
            this.btnbooking.Text = "BUTTON";
            this.btnbooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbooking.Textcolor = System.Drawing.Color.White;
            this.btnbooking.TextFont = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 471);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.lblBooksing);
            this.Name = "FormBooking";
            this.Text = "FormBooking";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksing;
        private Bunifu.Framework.UI.BunifuFlatButton btnbooking;
    }
}