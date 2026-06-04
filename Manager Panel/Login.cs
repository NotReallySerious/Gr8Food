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

namespace Manager_Panel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)

        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            

            string updateSql = "UPDATE Users SET Username = @Username, Email = @Email WHERE UserID = @UserID";

            SqlParameter[] p =
            {
                 new SqlParameter("@Username", username),
                 new SqlParameter("@Email", email),
               
    };

            int rows = DatabaseHelper.ExecuteNonQuery(updateSql, p);

            if (rows > 0)
                MessageBox.Show("Profile updated successfully!");
            else
                MessageBox.Show("Update failed.");
        }
       
    }
}
