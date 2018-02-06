namespace AdoBeginner
{
    partial class CustDet
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
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtCCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCPno = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(62, 31);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(65, 13);
            this.lblCID.TabIndex = 0;
            this.lblCID.Text = "Customer ID";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(156, 28);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(175, 20);
            this.txtCID.TabIndex = 1;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(156, 80);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(175, 20);
            this.txtCname.TabIndex = 3;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(62, 83);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(82, 13);
            this.lblCname.TabIndex = 2;
            this.lblCname.Text = "Customer Name";
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(156, 128);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(175, 20);
            this.txtCCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(62, 131);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtCPno
            // 
            this.txtCPno.Location = new System.Drawing.Point(156, 173);
            this.txtCPno.Name = "txtCPno";
            this.txtCPno.Size = new System.Drawing.Size(175, 20);
            this.txtCPno.TabIndex = 7;
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(62, 176);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(72, 13);
            this.Mobile.TabIndex = 6;
            this.Mobile.Text = "Mobile Phone";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(169, 248);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Search";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CustDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 376);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtCPno);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.txtCCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.lblCname);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.lblCID);
            this.Name = "CustDet";
            this.Text = "CustDet";
            this.Load += new System.EventHandler(this.CustDet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtCCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCPno;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Button btnNext;
    }
}