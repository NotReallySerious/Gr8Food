using System.Drawing;
using System.Windows.Forms;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGreetAdmin = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.grpDashboard = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbUserId = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailInput = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblBBC = new System.Windows.Forms.Label();
            this.txtBBCInput = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUserInner = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnAddRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(44, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtGreetAdmin
            // 
            this.txtGreetAdmin.AutoSize = true;
            this.txtGreetAdmin.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreetAdmin.Location = new System.Drawing.Point(226, 37);
            this.txtGreetAdmin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtGreetAdmin.Name = "txtGreetAdmin";
            this.txtGreetAdmin.Size = new System.Drawing.Size(452, 93);
            this.txtGreetAdmin.TabIndex = 1;
            this.txtGreetAdmin.Text = "Hello Admin";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1910, 20);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(236, 60);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(1654, 20);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(216, 60);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // grpDashboard
            // 
            this.grpDashboard.BackColor = System.Drawing.Color.Transparent;
            this.grpDashboard.Controls.Add(this.dgvUsers);
            this.grpDashboard.Controls.Add(this.pnlInputs);
            this.grpDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDashboard.Location = new System.Drawing.Point(48, 263);
            this.grpDashboard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpDashboard.Name = "grpDashboard";
            this.grpDashboard.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpDashboard.Size = new System.Drawing.Size(2054, 815);
            this.grpDashboard.TabIndex = 4;
            this.grpDashboard.TabStop = false;
            this.grpDashboard.Text = "Dashboard";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsers.ColumnHeadersHeight = 46;
            this.dgvUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.Location = new System.Drawing.Point(34, 66);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 82;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1302, 700);
            this.dgvUsers.TabIndex = 0;
            // 
            // pnlInputs
            // 
            this.pnlInputs.Controls.Add(this.cmbRole);
            this.pnlInputs.Controls.Add(this.lblId);
            this.pnlInputs.Controls.Add(this.cmbUserId);
            this.pnlInputs.Controls.Add(this.lblName);
            this.pnlInputs.Controls.Add(this.txtNameInput);
            this.pnlInputs.Controls.Add(this.lblEmail);
            this.pnlInputs.Controls.Add(this.txtEmailInput);
            this.pnlInputs.Controls.Add(this.lblPassword);
            this.pnlInputs.Controls.Add(this.txtPasswordInput);
            this.pnlInputs.Controls.Add(this.lblRole);
            this.pnlInputs.Controls.Add(this.lblBBC);
            this.pnlInputs.Controls.Add(this.txtBBCInput);
            this.pnlInputs.Controls.Add(this.btnAddUser);
            this.pnlInputs.Controls.Add(this.btnUpdateUserInner);
            this.pnlInputs.Controls.Add(this.btnDeleteUser);
            this.pnlInputs.Location = new System.Drawing.Point(1372, 66);
            this.pnlInputs.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(652, 700);
            this.pnlInputs.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Chef",
            "Manager"});
            this.cmbRole.Location = new System.Drawing.Point(19, 457);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(598, 40);
            this.cmbRole.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(18, 16);
            this.lblId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(172, 38);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "UserID:";
            // 
            // cmbUserId
            // 
            this.cmbUserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserId.FormattingEnabled = true;
            this.cmbUserId.Location = new System.Drawing.Point(18, 59);
            this.cmbUserId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbUserId.Name = "cmbUserId";
            this.cmbUserId.Size = new System.Drawing.Size(598, 40);
            this.cmbUserId.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 116);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 38);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameInput.Location = new System.Drawing.Point(18, 159);
            this.txtNameInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(598, 39);
            this.txtNameInput.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 216);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(172, 38);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmailInput
            // 
            this.txtEmailInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailInput.Location = new System.Drawing.Point(18, 259);
            this.txtEmailInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmailInput.Name = "txtEmailInput";
            this.txtEmailInput.Size = new System.Drawing.Size(598, 39);
            this.txtEmailInput.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(18, 316);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(220, 38);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordInput.Location = new System.Drawing.Point(18, 359);
            this.txtPasswordInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.Size = new System.Drawing.Size(598, 39);
            this.txtPasswordInput.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(18, 416);
            this.lblRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(172, 38);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role:";
            // 
            // lblBBC
            // 
            this.lblBBC.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBC.Location = new System.Drawing.Point(18, 516);
            this.lblBBC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBBC.Name = "lblBBC";
            this.lblBBC.Size = new System.Drawing.Size(244, 38);
            this.lblBBC.TabIndex = 10;
            this.lblBBC.Text = "BBC Balance:";
            // 
            // txtBBCInput
            // 
            this.txtBBCInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBBCInput.Location = new System.Drawing.Point(18, 559);
            this.txtBBCInput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBBCInput.Name = "txtBBCInput";
            this.txtBBCInput.Size = new System.Drawing.Size(598, 39);
            this.txtBBCInput.TabIndex = 11;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(18, 623);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(188, 59);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Add User";
            // 
            // btnUpdateUserInner
            // 
            this.btnUpdateUserInner.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUserInner.Location = new System.Drawing.Point(222, 623);
            this.btnUpdateUserInner.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdateUserInner.Name = "btnUpdateUserInner";
            this.btnUpdateUserInner.Size = new System.Drawing.Size(188, 59);
            this.btnUpdateUserInner.TabIndex = 13;
            this.btnUpdateUserInner.Text = "Update User";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(428, 623);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(188, 59);
            this.btnDeleteUser.TabIndex = 14;
            this.btnDeleteUser.Text = "Delete User";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(536, 135);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(264, 68);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Text = "Update User Profile";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(832, 135);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(264, 68);
            this.btnSalesReport.TabIndex = 5;
            this.btnSalesReport.Text = "View Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnAddRemove
            // 
            this.btnAddRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRemove.Location = new System.Drawing.Point(236, 135);
            this.btnAddRemove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddRemove.Name = "btnAddRemove";
            this.btnAddRemove.Size = new System.Drawing.Size(264, 68);
            this.btnAddRemove.TabIndex = 5;
            this.btnAddRemove.Text = "Add or Remove User";
            this.btnAddRemove.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(2166, 1135);
            this.Controls.Add(this.btnAddRemove);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.grpDashboard);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtGreetAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtGreetAdmin;
        private Button btnLogOut;
        private Button btnEditProfile;
        private GroupBox grpDashboard;
        private DataGridView dgvUsers;
        private Button btnUpdateUser;
        private Button btnSalesReport;
        private Button btnAddRemove;
        private Panel pnlInputs;
        private Label lblId;
        private ComboBox cmbUserId;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRole;
        private Label lblBBC;
        private ComboBox cmbRole;
        private TextBox txtNameInput;
        private TextBox txtEmailInput;
        private TextBox txtPasswordInput;
        private TextBox txtBBCInput;
        private Button btnAddUser;
        private Button btnUpdateUserInner;
        private Button btnDeleteUser;
        private GroupBox grpSalesReport;
    }
}