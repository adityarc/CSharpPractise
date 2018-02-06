namespace AdoBeginner
{
    partial class frmDetails
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
            this.lblWelcomePage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomePage
            // 
            this.lblWelcomePage.AutoSize = true;
            this.lblWelcomePage.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomePage.Location = new System.Drawing.Point(71, 98);
            this.lblWelcomePage.Name = "lblWelcomePage";
            this.lblWelcomePage.Size = new System.Drawing.Size(184, 33);
            this.lblWelcomePage.TabIndex = 0;
            this.lblWelcomePage.Text = "Welcome Admin";
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblWelcomePage);
            this.Name = "frmDetails";
            this.Text = "Welcome Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetails_FormClosing);
           // this.Load += new System.EventHandler(this.frmDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomePage;
    }
}