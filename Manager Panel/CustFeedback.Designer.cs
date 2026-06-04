namespace Manager_Panel
{
    partial class CustFeedback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.replybtn = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerName.Location = new System.Drawing.Point(227, 28);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(175, 52);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer";
            this.lblCustomerName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // replybtn
            // 
            this.replybtn.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replybtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.replybtn.Location = new System.Drawing.Point(815, 190);
            this.replybtn.Name = "replybtn";
            this.replybtn.Size = new System.Drawing.Size(128, 48);
            this.replybtn.TabIndex = 3;
            this.replybtn.Text = "Reply";
            this.replybtn.UseVisualStyleBackColor = true;
            this.replybtn.Click += new System.EventHandler(this.replybtn_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.Transparent;
            this.lblmessage.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmessage.Location = new System.Drawing.Point(230, 80);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(60, 34);
            this.lblmessage.TabIndex = 2;
            this.lblmessage.Text = ".........";
            this.lblmessage.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblmessage);
            this.panel3.Controls.Add(this.replybtn);
            this.panel3.Controls.Add(this.lblCustomerName);
            this.panel3.Location = new System.Drawing.Point(3, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 267);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 259);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Manager_Panel.Properties.Resources.customer_face;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(37, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 122);
            this.panel1.TabIndex = 0;
            // 
            // CustFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "CustFeedback";
            this.Size = new System.Drawing.Size(958, 265);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button replybtn;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
