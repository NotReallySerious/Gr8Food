namespace Manager_Panel
{
    partial class Wallet
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttopup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtcust = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.walletcust1 = new Manager_Panel.walletcust();
            this.BuildTableRow = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterbtn = new System.Windows.Forms.Button();
            this.cmballmonth = new System.Windows.Forms.ComboBox();
            this.cmballyear = new System.Windows.Forms.ComboBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.walletcust2 = new Manager_Panel.walletcust();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FLP.SuspendLayout();
            this.BuildTableRow.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.txttopup);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(64, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 172);
            this.panel3.TabIndex = 5;
            // 
            // txttopup
            // 
            this.txttopup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttopup.Location = new System.Drawing.Point(105, 76);
            this.txttopup.Name = "txttopup";
            this.txttopup.Size = new System.Drawing.Size(120, 44);
            this.txttopup.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Top-Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtusage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(445, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 172);
            this.panel1.TabIndex = 4;
            // 
            // txtusage
            // 
            this.txtusage.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusage.Location = new System.Drawing.Point(107, 76);
            this.txtusage.Name = "txtusage";
            this.txtusage.Size = new System.Drawing.Size(120, 44);
            this.txtusage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(89, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Usage";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.txtcust);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(821, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 172);
            this.panel4.TabIndex = 3;
            // 
            // txtcust
            // 
            this.txtcust.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcust.Location = new System.Drawing.Point(119, 76);
            this.txtcust.Name = "txtcust";
            this.txtcust.Size = new System.Drawing.Size(120, 44);
            this.txtcust.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(71, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active Customer";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.FLP);
            this.panel2.Controls.Add(this.BuildTableRow);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(64, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 854);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.Controls.Add(this.walletcust2);
            this.FLP.Controls.Add(this.walletcust1);
            this.FLP.Location = new System.Drawing.Point(64, 391);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(956, 444);
            this.FLP.TabIndex = 2;
            this.FLP.WrapContents = false;
            this.FLP.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // walletcust1
            // 
            this.walletcust1.BackColor = System.Drawing.Color.Transparent;
            this.walletcust1.Date = null;
            this.walletcust1.ID = null;
            this.walletcust1.Location = new System.Drawing.Point(957, 3);
            this.walletcust1.name = null;
            this.walletcust1.Name = "walletcust1";
            this.walletcust1.Size = new System.Drawing.Size(948, 95);
            this.walletcust1.TabIndex = 0;
            this.walletcust1.total = null;
            this.walletcust1.Type = null;
            this.walletcust1.Load += new System.EventHandler(this.walletcust1_Load);
            // 
            // BuildTableRow
            // 
            this.BuildTableRow.Controls.Add(this.label9);
            this.BuildTableRow.Controls.Add(this.label8);
            this.BuildTableRow.Controls.Add(this.label7);
            this.BuildTableRow.Controls.Add(this.label6);
            this.BuildTableRow.Controls.Add(this.label5);
            this.BuildTableRow.Location = new System.Drawing.Point(64, 295);
            this.BuildTableRow.Name = "BuildTableRow";
            this.BuildTableRow.Size = new System.Drawing.Size(957, 81);
            this.BuildTableRow.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(834, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 33);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(638, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(458, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cust ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.filterbtn);
            this.groupBox1.Controls.Add(this.cmballmonth);
            this.groupBox1.Controls.Add(this.cmballyear);
            this.groupBox1.Location = new System.Drawing.Point(64, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(31, 86);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(525, 31);
            this.searchbox.TabIndex = 5;
            this.searchbox.Text = "Search Customer Name...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "All Customer";
            // 
            // filterbtn
            // 
            this.filterbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.filterbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filterbtn.Location = new System.Drawing.Point(735, 80);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Size = new System.Drawing.Size(160, 42);
            this.filterbtn.TabIndex = 2;
            this.filterbtn.Text = "Filter";
            this.filterbtn.UseVisualStyleBackColor = false;
            this.filterbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmballmonth
            // 
            this.cmballmonth.FormattingEnabled = true;
            this.cmballmonth.ItemHeight = 25;
            this.cmballmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmballmonth.Location = new System.Drawing.Point(31, 136);
            this.cmballmonth.Name = "cmballmonth";
            this.cmballmonth.Size = new System.Drawing.Size(525, 33);
            this.cmballmonth.TabIndex = 1;
            this.cmballmonth.Text = "All Month";
            this.cmballmonth.UseWaitCursor = true;
            this.cmballmonth.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmballyear
            // 
            this.cmballyear.FormattingEnabled = true;
            this.cmballyear.ItemHeight = 25;
            this.cmballyear.Items.AddRange(new object[] {
            "2025",
            "2026"});
            this.cmballyear.Location = new System.Drawing.Point(31, 184);
            this.cmballyear.Name = "cmballyear";
            this.cmballyear.Size = new System.Drawing.Size(525, 33);
            this.cmballyear.TabIndex = 0;
            this.cmballyear.Text = "All Year";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // walletcust2
            // 
            this.walletcust2.BackColor = System.Drawing.Color.Transparent;
            this.walletcust2.Date = null;
            this.walletcust2.ID = null;
            this.walletcust2.Location = new System.Drawing.Point(3, 3);
            this.walletcust2.name = null;
            this.walletcust2.Name = "walletcust2";
            this.walletcust2.Size = new System.Drawing.Size(948, 95);
            this.walletcust2.TabIndex = 1;
            this.walletcust2.total = null;
            this.walletcust2.Type = null;
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Wallet";
            this.Size = new System.Drawing.Size(1225, 1150);
            this.Load += new System.EventHandler(this.Wallet_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.FLP.ResumeLayout(false);
            this.BuildTableRow.ResumeLayout(false);
            this.BuildTableRow.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttopup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtcust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button filterbtn;
        private System.Windows.Forms.ComboBox cmballmonth;
        private System.Windows.Forms.ComboBox cmballyear;
        private System.Windows.Forms.TextBox searchbox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel BuildTableRow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private walletcust walletcust1;
        private walletcust walletcust2;
    }
}
