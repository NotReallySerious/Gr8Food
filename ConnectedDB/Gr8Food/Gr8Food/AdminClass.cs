using Gr8Food;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr8Food
{
    public class AdminClass
    {
        public string Name;
        public string password;
        public string Role = "admin";
        public AdminClass(string name, string password, string role)
        {
            this.Name = name;
            this.Password = password; 
            this.Role = role;
        }

        public string GreetAdmin(string name)
        {
            return $"Welcome Admin, {name}!";
        }

        public DataTable ShowAllUsers()
        {
            DataTable datatable = new DataTable();

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                MessageBox.Show("Connection Successful!");

                string query = "SELECT UserId, Name, Email, Password, Role, EWalletBalance FROM users ORDER BY UserId ASC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(datatable);
                }
            }
            return datatable;
        }
        public DataTable AddNewUser(string name, string email, string password, string role)
        {
            DataTable datatable = new DataTable();
            string Name = name;
            string Email = email;
            string Password = password;
            string Role = role;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string query = $"INSERT INTO users (Name, Email, Password, Role) VALUES ('{Name}', '{Email}', '{Password}', '{Role}')";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(datatable);
                }
            }
            return datatable;
        }

        public DataTable UpdateUser(string UserID, string name, string email, string password, string role)
        {
            DataTable datatable = new DataTable();
            string userid = UserID;
            string Name = name;
            string Email = email;
            string Password = password;
            string Role = role;
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"UPDATE users SET Name = '{Name}', Email = '{Email}', Password = '{Password}', Role = '{Role}' WHERE UserId = {userid}";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(datatable);
                }
            }
            return datatable;
        }

        public DataTable DeleteUser(string UserID)
        {
            DataTable datatable = new DataTable();
            string userid = UserID;
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"DELETE FROM users WHERE UserId = {userid}";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(datatable);
                }
            }
            return datatable;
        }

        public List<string> GetAllUserIds()
        {
            List<string> userIds = new List<string>();

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT UserId FROM users";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userIds.Add(reader["UserId"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userIds;
        }
        public DataTable GetUserDetails(string UserID)
        {
            DataTable datatable = new DataTable();
            string userid = UserID;
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"SELECT Name, Email, Password, Role FROM users WHERE UserId = {userid}";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(datatable);
                }
            }
            return datatable;

        }
        public void RefreshUI(DataGridView targetGrid, ComboBox targetlistbox)
        {
            try
            {
                // 1. Keep track of what item text was highlighted before the wipe
                object currentlySelectedId = targetlistbox.SelectedItem;

                // 2. Refresh the DataGridView using existing DataTable method
                targetGrid.DataSource = null;
                targetGrid.DataSource = this.ShowAllUsers();

                // 3. Refresh the User ID ListBox using string list method
                targetlistbox.DataSource = null;
                targetlistbox.DataSource = this.GetAllUserIds(); // Returns the List<string>

                // 4. Put the user's string selection highlight back if it still exists
                if (currentlySelectedId != null && targetlistbox.Items.Contains(currentlySelectedId))
                {
                    targetlistbox.SelectedItem = currentlySelectedId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data display: {ex.Message}", "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetAllSalesReportDefault()
        {
            DataTable reportTable = new DataTable();

            string query = $@"SELECT 
                                o.OrderID AS [Order ID],
                                o.OrderDate AS [Date],
                                m.Name AS [Item Name],
                                m.Category AS [Category],
                                o.TotalCost AS [Total Revenue],
                                u.Name AS [Chef Name],
                                o.Status AS [Order Status]
                             FROM Orders o
                             INNER JOIN MenuItems m ON o.ItemID = m.ItemID
                             INNER JOIN Users u ON o.ChefID = u.UserID";

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(reportTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading default sales records: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return reportTable;
        }
        public DataTable GetSortedSalesReport(string dateInput, string chefFilter, string categoryFilter, string sortType)
        {
            DataTable reportTable = new DataTable();

            // Combining $ and @ allows multi-line formatting along with string interpolation
            string query = $@"SELECT 
                                o.OrderID AS [Order ID],
                                o.OrderDate AS [Date],
                                m.Name AS [Item Name],
                                m.Category AS [Category],
                                o.TotalCost AS [Total Revenue],
                                u.Name AS [Chef Name],
                                o.Status AS [Order Status]
                             FROM Orders o
                             INNER JOIN MenuItems m ON o.ItemID = m.ItemID
                             INNER JOIN Users u ON o.ChefID = u.UserID
                             WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(dateInput))
            {
                query += $@" AND CAST(o.OrderDate AS DATE) = @OrderDate";
            }

            if (!string.IsNullOrWhiteSpace(chefFilter))
            {
                query += $@" AND u.Name LIKE @ChefName";
            }

            if (!string.IsNullOrWhiteSpace(categoryFilter))
            {
                query += $@" AND m.Category LIKE @Category";
            }

            // Append sorting sequence structures
            if (sortType == "Ascending")
            {
                query += $" ORDER BY o.OrderDate ASC";
            }
            else
            {
                query += $" ORDER BY o.OrderDate DESC";
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(dateInput))
                        {
                            DateTime parsedDate = DateTime.ParseExact(dateInput.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            cmd.Parameters.AddWithValue("@OrderDate", $"{parsedDate:yyyy-MM-dd}");
                        }

                        if (!string.IsNullOrWhiteSpace(chefFilter))
                        {
                            cmd.Parameters.AddWithValue("@ChefName", $"%{chefFilter.Trim()}%");
                        }

                        if (!string.IsNullOrWhiteSpace(categoryFilter))
                        {
                            cmd.Parameters.AddWithValue("@Category", $"%{categoryFilter.Trim()}%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(reportTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error compiling sales data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return reportTable;
        }

        public bool DoesChefExist(string chefName)
        {
            if (string.IsNullOrWhiteSpace(chefName)) return true;

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = $@"SELECT COUNT(1) FROM users WHERE Name = @ChefName AND Role = 'chef'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChefName", chefName.Trim());
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error verifying chef: {ex.Message}");
                return false;
            }
        }

        public bool DoesCategoryExist(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName)) return true;

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = $@"SELECT COUNT(1) FROM MenuItems WHERE Category = @Category";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", categoryName.Trim());
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error verifying category: {ex.Message}");
                return false;
            }
        }

        public bool IsValidDateFormat(string dateText)
        {
            if (string.IsNullOrWhiteSpace(dateText)) return true;

            return DateTime.TryParseExact(
                dateText.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out _
            );
        }
    }
}

