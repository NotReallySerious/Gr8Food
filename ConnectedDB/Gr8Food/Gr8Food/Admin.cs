using Gr8Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // Cleaned: Kept only a single declaration block
using System.Text.RegularExpressions;

namespace Gr8Food
{
    public partial class frmAdmin : Form
    {
        public AdminClass utils; 
        private bool isRowClicking = false;

        public frmAdmin()
        {
            InitializeComponent();
            utils = new AdminClass(Session.CurrentUserName, "admin");
            ShowPage(grpDashboard);
            lblgreeting.Text = utils.GreetAdmin(Session.CurrentUserName);
        }

        private void ShowPage(System.Windows.Forms.GroupBox grouptoActivelyShow)
        {
            // Hide all workspace panels
            grpDashboard.Visible = false;
            grpSales.Visible = false;

            // Only snap location, do NOT override Size — let each GroupBox keep its own designed dimensions
            grouptoActivelyShow.Location = new Point(18, 86);

            grouptoActivelyShow.Visible = true;
            grouptoActivelyShow.BringToFront();
        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isRowClicking = true;
                try
                {
                    DataGridViewRow row = dgDisplay.Rows[e.RowIndex];

                    string cellUserId = row.Cells["UserId"].Value?.ToString() ?? "";
                    string cellName = row.Cells["Name"].Value?.ToString() ?? "";
                    string cellEmail = row.Cells["Email"].Value?.ToString() ?? "";
                    string cellPassword = row.Cells["Password"].Value?.ToString() ?? "";
                    string cellRole = row.Cells["Role"].Value?.ToString() ?? "";

                    txtusername.Text = cellName;
                    txtEmail.Text = cellEmail;
                    txtPass.Text = cellPassword;

                    if (!string.IsNullOrEmpty(cellUserId) && cmbUserID.Items.Count > 0)
                    {
                        int userIndex = cmbUserID.FindStringExact(cellUserId);
                        if (userIndex != -1)
                            cmbUserID.SelectedIndex = userIndex;
                        else
                            cmbUserID.Text = cellUserId;
                    }
                    else
                    {
                        cmbUserID.Text = cellUserId;
                    }

                    if (!string.IsNullOrEmpty(cellRole) && cmbRole.Items.Count > 0)
                    {
                        cmbRole.SelectedIndex = cmbRole.FindStringExact(cellRole);
                        if (cmbRole.SelectedIndex == -1)
                        {
                            cmbRole.Text = cellRole;
                        }
                    }
                    else
                    {
                        cmbRole.Text = cellRole;
                    }
                }
                finally
                {
                    isRowClicking = false;
                }
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            ShowPage(grpDashboard);
            DataTable users = utils.ShowAllUsers();
            dgDisplay.DataSource = users;
            List<string> useridlist = utils.GetAllUserIds();
            cmbUserID.DataSource = null;
            cmbUserID.DataSource = useridlist;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userid = cmbUserID.Text;
            string username = txtusername.Text;
            string email = txtEmail.Text;
            string password = txtPass.Text;
            string role = cmbRole.Text;
            try
            {
                utils.UpdateUser(userid, username, email, password, role);
                MessageBox.Show("User updated successfully!");
                utils.RefreshUI(dgDisplay, cmbUserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                utils.DeleteUser(cmbUserID.Text);
                MessageBox.Show("User deleted successfully!");
                utils.RefreshUI(dgDisplay, cmbUserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRowClicking) return;

            if (cmbUserID.SelectedItem == null && string.IsNullOrWhiteSpace(cmbUserID.Text)) return;

            try
            {
                string selectedUserId = "";

                if (cmbUserID.SelectedIndex != -1)
                {
                    selectedUserId = cmbUserID.Text.Trim();
                }
                else if (cmbUserID.SelectedItem != null)
                {
                    selectedUserId = cmbUserID.SelectedItem.ToString().Trim();
                }

                if (string.IsNullOrWhiteSpace(selectedUserId)) return;

                DataTable userDetails = utils.GetUserDetails(selectedUserId);

                if (userDetails != null && userDetails.Rows.Count > 0)
                {
                    DataRow row = userDetails.Rows[0];

                    txtusername.Text = row["Name"]?.ToString() ?? "";
                    txtEmail.Text = row["Email"]?.ToString() ?? "";
                    txtPass.Text = row["Password"]?.ToString() ?? "";

                    string dbRole = row["Role"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(dbRole) && cmbRole.Items.Count > 0)
                    {
                        int roleIndex = cmbRole.FindStringExact(dbRole);
                        if (roleIndex != -1)
                            cmbRole.SelectedIndex = roleIndex;
                        else
                            cmbRole.Text = dbRole;
                    }
                    else
                    {
                        cmbRole.Text = dbRole;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch credentials for the selected User ID: {ex.Message}",
                                "Data Fetch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string email = txtEmail.Text;
            string password = txtPass.Text;
            string role = cmbRole.Text;
            try
            {
                utils.AddNewUser(username, email, password, role);
                MessageBox.Show("User added successfully!");
                utils.RefreshUI(dgDisplay, cmbUserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Use ShowPage so grpSales snaps to the correct position
                ShowPage(grpSales);

                dgSales.DataSource = null;

                DataTable salesReport = utils.GetAllSalesReportDefault();

                if (salesReport == null || salesReport.Rows.Count == 0)
                {
                    MessageBox.Show("The sales report container was fetched successfully, but the database returned 0 matching sales records.",
                                    "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgSales.DataSource = salesReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load sales database contents cleanly: {ex.Message}",
                                "Database Reporting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Date = txtDate.Text.Trim();
            string Chef = txtChef.Text.Trim();
            string category = txtCate.Text.Trim();

            string Selected_Mode = cmbAscDesc.SelectedItem != null
                ? cmbAscDesc.SelectedItem.ToString()
                : "";

            try
            {
                DataTable reportResults = utils.GetSortedSalesReport(Date, Chef, category, Selected_Mode);
                dgSales.DataSource = null;
                dgSales.DataSource = reportResults;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (ex.ParamName == "Date")
                {
                    txtDate.Clear();
                    txtDate.Focus();
                }
                else if (ex.ParamName == "Chef")
                {
                    txtChef.Clear();
                    txtChef.Focus();
                }
                else if (ex.ParamName == "Category")
                {
                    txtCate.Clear();
                    txtCate.Focus();
                }
                else if (ex.ParamName == "SortMode")
                {
                    cmbAscDesc.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search compiled execution failure error: {ex.Message}", "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            frmUpdateProfile updateProfileForm = new frmUpdateProfile();
            this.Hide();
            updateProfileForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void grpDashboard_Enter(object sender, EventArgs e)
        {
        }
    }
}