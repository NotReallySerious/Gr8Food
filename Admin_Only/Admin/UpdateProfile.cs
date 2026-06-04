using Gr8Food;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmUpdateProfile : Form
    {
        public frmUpdateProfile()
        {
            InitializeComponent();
            ExistingCredentialsLoad();
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void ExistingCredentialsLoad()
        {
            // Guard: catch null session before it crashes the query
            if (string.IsNullOrWhiteSpace(Session.CurrentUserName))
            {
                MessageBox.Show("Session has expired or no user is logged in. Please log in again.",
                                "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string query = "SELECT Name, Email, Password FROM Users WHERE LTRIM(RTRIM(Name)) = @Username";

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Session.CurrentUserName.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtPassword.Text = reader["Password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User session profile data could not be located.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string Email = txtEmail.Text;
            string password = txtPassword.Text;

            if (CheckPassword(password) == true)
            {
                // ORIGINAL: update by session username inline (reverted)
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password WHERE LTRIM(RTRIM(Name)) = @CurrentName";

                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", username.Trim());
                        cmd.Parameters.AddWithValue("@Email", Email.Trim());
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@CurrentName", Session.CurrentUserName.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Session.CurrentUserName = username.Trim();
                        }
                        else
                        {
                            MessageBox.Show("Profile update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private bool CheckPassword(string password)
        {
            if (password.Length < 12)
            {
                MessageBox.Show($"Password must be at least 12 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show($"Password must contain at least one uppercase letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show($"Password must contain at least one digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            if (!password.Any(c => char.IsSymbol(c) || char.IsPunctuation(c)))
            {
                MessageBox.Show($"Password must contain at least one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin adminpage = new frmAdmin();
            this.Hide();
            adminpage.Show();
        }
    }
}