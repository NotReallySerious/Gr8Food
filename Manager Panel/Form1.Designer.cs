namespace Manager_Panel
{
    partial class Form1
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEWalletReport = new System.Windows.Forms.Button();
            this.btnCustomerFeedback = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprofile = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Image = global::Manager_Panel.Properties.Resources.main_label;
            pictureBox1.Location = new System.Drawing.Point(27, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(364, 100);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-58, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1977, 59);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnprofile);
            this.panel2.Controls.Add(this.btnEWalletReport);
            this.panel2.Controls.Add(this.btnCustomerFeedback);
            this.panel2.Location = new System.Drawing.Point(45, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 675);
            this.panel2.TabIndex = 1;
            // 
            // btnEWalletReport
            // 
            this.btnEWalletReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEWalletReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEWalletReport.Font = new System.Drawing.Font("Cooper Black", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEWalletReport.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEWalletReport.Location = new System.Drawing.Point(3, 144);
            this.btnEWalletReport.Name = "btnEWalletReport";
            this.btnEWalletReport.Size = new System.Drawing.Size(397, 86);
            this.btnEWalletReport.TabIndex = 3;
            this.btnEWalletReport.Text = "E-Wallet Report";
            this.btnEWalletReport.UseVisualStyleBackColor = false;
            this.btnEWalletReport.Click += new System.EventHandler(this.walletbtn_Click);
            // 
            // btnCustomerFeedback
            // 
            this.btnCustomerFeedback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerFeedback.Font = new System.Drawing.Font("Cooper Black", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerFeedback.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCustomerFeedback.Location = new System.Drawing.Point(3, 35);
            this.btnCustomerFeedback.Name = "btnCustomerFeedback";
            this.btnCustomerFeedback.Size = new System.Drawing.Size(397, 86);
            this.btnCustomerFeedback.TabIndex = 2;
            this.btnCustomerFeedback.Text = "Customer Feedback";
            this.btnCustomerFeedback.UseVisualStyleBackColor = false;
            this.btnCustomerFeedback.Click += new System.EventHandler(this.feedbackbtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.AutoScroll = true;
            this.mainpanel.AutoSize = true;
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.ForeColor = System.Drawing.Color.Transparent;
            this.mainpanel.Location = new System.Drawing.Point(478, 85);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1291, 864);
            this.mainpanel.TabIndex = 1;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(pictureBox1);
            this.panel3.Location = new System.Drawing.Point(45, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 183);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.Font = new System.Drawing.Font("Cooper Black", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.Black;
            this.btnprofile.Location = new System.Drawing.Point(27, 594);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(364, 59);
            this.btnprofile.TabIndex = 0;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1881, 1029);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCustomerFeedback;
        private System.Windows.Forms.Button btnEWalletReport;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprofile;
    }
}

