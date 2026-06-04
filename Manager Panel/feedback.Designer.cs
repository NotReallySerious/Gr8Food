namespace Manager_Panel
{
    partial class feedback
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.custFeedback2 = new Manager_Panel.CustFeedback();
            this.custFeedback1 = new Manager_Panel.CustFeedback();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.filterbtn = new System.Windows.Forms.Button();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttopup = new System.Windows.Forms.TextBox();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtreplies = new System.Windows.Forms.TextBox();
            this.lblpending = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.FLP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.FLP);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(55, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 864);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.Controls.Add(this.custFeedback2);
            this.FLP.Controls.Add(this.custFeedback1);
            this.FLP.Location = new System.Drawing.Point(64, 247);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(969, 575);
            this.FLP.TabIndex = 1;
            this.FLP.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // custFeedback2
            // 
            this.custFeedback2.BackColor = System.Drawing.Color.Transparent;
            this.custFeedback2.Location = new System.Drawing.Point(3, 3);
            this.custFeedback2.Message = null;
            this.custFeedback2.Name = "custFeedback2";
            this.custFeedback2.Size = new System.Drawing.Size(958, 265);
            this.custFeedback2.TabIndex = 1;
            this.custFeedback2.Title = null;
            this.custFeedback2.Load += new System.EventHandler(this.custFeedback2_Load);
            // 
            // custFeedback1
            // 
            this.custFeedback1.BackColor = System.Drawing.Color.Transparent;
            this.custFeedback1.Location = new System.Drawing.Point(3, 274);
            this.custFeedback1.Message = null;
            this.custFeedback1.Name = "custFeedback1";
            this.custFeedback1.Size = new System.Drawing.Size(958, 265);
            this.custFeedback1.TabIndex = 2;
            this.custFeedback1.Title = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.filterbtn);
            this.groupBox1.Controls.Add(this.cmbStatusFilter);
            this.groupBox1.Location = new System.Drawing.Point(64, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "All Feedback";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 12);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // filterbtn
            // 
            this.filterbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.filterbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filterbtn.Location = new System.Drawing.Point(372, 102);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Size = new System.Drawing.Size(160, 42);
            this.filterbtn.TabIndex = 2;
            this.filterbtn.Text = "Filter";
            this.filterbtn.UseVisualStyleBackColor = false;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.ItemHeight = 25;
            this.cmbStatusFilter.Location = new System.Drawing.Point(372, 59);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(525, 33);
            this.cmbStatusFilter.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.txttopup);
            this.panel3.Controls.Add(this.lblfeedback);
            this.panel3.Location = new System.Drawing.Point(55, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 172);
            this.panel3.TabIndex = 9;
            // 
            // txttopup
            // 
            this.txttopup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttopup.Location = new System.Drawing.Point(52, 76);
            this.txttopup.Name = "txttopup";
            this.txttopup.Size = new System.Drawing.Size(120, 44);
            this.txttopup.TabIndex = 4;
            this.txttopup.TextChanged += new System.EventHandler(this.txttopup_TextChanged);
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfeedback.Location = new System.Drawing.Point(45, 23);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(212, 38);
            this.lblfeedback.TabIndex = 0;
            this.lblfeedback.Text = "Total Feedback";
            this.lblfeedback.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtreplies);
            this.panel1.Controls.Add(this.lblpending);
            this.panel1.Location = new System.Drawing.Point(610, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 172);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtreplies
            // 
            this.txtreplies.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreplies.Location = new System.Drawing.Point(44, 64);
            this.txtreplies.Name = "txtreplies";
            this.txtreplies.Size = new System.Drawing.Size(120, 44);
            this.txtreplies.TabIndex = 2;
            // 
            // lblpending
            // 
            this.lblpending.AutoSize = true;
            this.lblpending.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpending.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpending.Location = new System.Drawing.Point(28, 23);
            this.lblpending.Name = "lblpending";
            this.lblpending.Size = new System.Drawing.Size(208, 38);
            this.lblpending.TabIndex = 1;
            this.lblpending.Text = "Pending Replies";
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "feedback";
            this.Size = new System.Drawing.Size(1225, 1150);
            this.Load += new System.EventHandler(this.feedback_Load);
            this.panel2.ResumeLayout(false);
            this.FLP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button filterbtn;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttopup;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtreplies;
        private System.Windows.Forms.Label lblpending;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private CustFeedback custFeedback2;
        private CustFeedback custFeedback1;
    }
}
