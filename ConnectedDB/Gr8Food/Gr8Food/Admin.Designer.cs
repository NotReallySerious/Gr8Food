namespace Gr8Food
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.lblgreeting = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpDashboard = new System.Windows.Forms.GroupBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.cmbAscDesc = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCate = new System.Windows.Forms.TextBox();
            this.txtChef = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dgSales = new System.Windows.Forms.DataGridView();
            this.cmbID = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.grpDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.grpSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.BackgroundImage")));
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 14);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(66, 68);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // lblgreeting
            // 
            this.lblgreeting.AutoSize = true;
            this.lblgreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgreeting.Location = new System.Drawing.Point(93, 14);
            this.lblgreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgreeting.Name = "lblgreeting";
            this.lblgreeting.Size = new System.Drawing.Size(184, 36);
            this.lblgreeting.TabIndex = 1;
            this.lblgreeting.Text = "Hello, Admin";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(576, 14);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(90, 20);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(676, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 20);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(99, 57);
            this.btnShowUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(92, 23);
            this.btnShowUsers.TabIndex = 3;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(207, 57);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(92, 23);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Sales Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpDashboard
            // 
            this.grpDashboard.Controls.Add(this.grpSales);
            this.grpDashboard.Controls.Add(this.cmbRole);
            this.grpDashboard.Controls.Add(this.cmbUserID);
            this.grpDashboard.Controls.Add(this.dgDisplay);
            this.grpDashboard.Controls.Add(this.btnAdd);
            this.grpDashboard.Controls.Add(this.btnDelete);
            this.grpDashboard.Controls.Add(this.btnUpdate);
            this.grpDashboard.Controls.Add(this.label5);
            this.grpDashboard.Controls.Add(this.txtPass);
            this.grpDashboard.Controls.Add(this.label4);
            this.grpDashboard.Controls.Add(this.txtEmail);
            this.grpDashboard.Controls.Add(this.label3);
            this.grpDashboard.Controls.Add(this.txtusername);
            this.grpDashboard.Controls.Add(this.label2);
            this.grpDashboard.Controls.Add(this.label1);
            this.grpDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDashboard.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDashboard.Location = new System.Drawing.Point(11, 86);
            this.grpDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.grpDashboard.Name = "grpDashboard";
            this.grpDashboard.Padding = new System.Windows.Forms.Padding(2);
            this.grpDashboard.Size = new System.Drawing.Size(722, 326);
            this.grpDashboard.TabIndex = 4;
            this.grpDashboard.TabStop = false;
            this.grpDashboard.Text = "Display";
            this.grpDashboard.Enter += new System.EventHandler(this.grpDashboard_Enter);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Chef",
            "Customer"});
            this.cmbRole.Location = new System.Drawing.Point(519, 222);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(186, 25);
            this.cmbRole.TabIndex = 8;
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(522, 56);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(186, 25);
            this.cmbUserID.TabIndex = 8;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // dgDisplay
            // 
            this.dgDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Location = new System.Drawing.Point(11, 27);
            this.dgDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.RowHeadersWidth = 82;
            this.dgDisplay.RowTemplate.Height = 33;
            this.dgDisplay.Size = new System.Drawing.Size(494, 245);
            this.dgDisplay.TabIndex = 6;
            this.dgDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 281);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(148, 281);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 281);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(519, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Role";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(522, 180);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(184, 23);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(522, 141);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(522, 98);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(184, 23);
            this.txtusername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.cmbAscDesc);
            this.grpSales.Controls.Add(this.btnSearch);
            this.grpSales.Controls.Add(this.label9);
            this.grpSales.Controls.Add(this.label8);
            this.grpSales.Controls.Add(this.label7);
            this.grpSales.Controls.Add(this.label6);
            this.grpSales.Controls.Add(this.txtCate);
            this.grpSales.Controls.Add(this.txtChef);
            this.grpSales.Controls.Add(this.txtDate);
            this.grpSales.Controls.Add(this.dgSales);
            this.grpSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSales.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(0, 0);
            this.grpSales.Margin = new System.Windows.Forms.Padding(2);
            this.grpSales.Name = "grpSales";
            this.grpSales.Padding = new System.Windows.Forms.Padding(2);
            this.grpSales.Size = new System.Drawing.Size(722, 287);
            this.grpSales.TabIndex = 7;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Display";
            // 
            // cmbAscDesc
            // 
            this.cmbAscDesc.FormattingEnabled = true;
            this.cmbAscDesc.ItemHeight = 17;
            this.cmbAscDesc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbAscDesc.Location = new System.Drawing.Point(466, 204);
            this.cmbAscDesc.Name = "cmbAscDesc";
            this.cmbAscDesc.Size = new System.Drawing.Size(235, 21);
            this.cmbAscDesc.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(466, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(235, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(462, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sort Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Category Sort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chef Sort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Sort (DD/MM/YYYY)";
            // 
            // txtCate
            // 
            this.txtCate.Location = new System.Drawing.Point(466, 155);
            this.txtCate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new System.Drawing.Size(238, 22);
            this.txtCate.TabIndex = 7;
            // 
            // txtChef
            // 
            this.txtChef.Location = new System.Drawing.Point(466, 103);
            this.txtChef.Margin = new System.Windows.Forms.Padding(2);
            this.txtChef.Name = "txtChef";
            this.txtChef.Size = new System.Drawing.Size(238, 22);
            this.txtChef.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(466, 49);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(238, 22);
            this.txtDate.TabIndex = 7;
            // 
            // dgSales
            // 
            this.dgSales.BackgroundColor = System.Drawing.Color.White;
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.Location = new System.Drawing.Point(11, 27);
            this.dgSales.Margin = new System.Windows.Forms.Padding(2);
            this.dgSales.Name = "dgSales";
            this.dgSales.RowHeadersWidth = 82;
            this.dgSales.RowTemplate.Height = 33;
            this.dgSales.Size = new System.Drawing.Size(435, 245);
            this.dgSales.TabIndex = 6;
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.ItemHeight = 25;
            this.cmbID.Location = new System.Drawing.Point(817, 116);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(365, 29);
            this.cmbID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(818, 204);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(818, 286);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(364, 20);
            this.txtmail.TabIndex = 4;
            this.txtmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(818, 361);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(364, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(753, 453);
            this.Controls.Add(this.grpDashboard);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.lblgreeting);
            this.Controls.Add(this.pictureBoxProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmin";
            this.Text = "Admin ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.grpDashboard.ResumeLayout(false);
            this.grpDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblgreeting;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpDashboard;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox cmbID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.DataGridView dgSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ListBox cmbAscDesc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCate;
        private System.Windows.Forms.TextBox txtChef;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbUserID;
    }
}