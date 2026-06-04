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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Manager_Panel
{
    public partial class Reply : Form
    {

       
            public int FeedbackID { get; set; }
            public string CustomerName { get; set; }
            public Reply()
        {
            InitializeComponent();
        }
        private void Reply_Load(object sender, EventArgs e)
        {

        }

       

        private void btnSend_Click(object sender, EventArgs e)
        {
            {
                string replyText = txtInput.Text.Trim();

                if (string.IsNullOrEmpty(replyText))
                {
                    MessageBox.Show(
                        "Please write a reply before sending.",
                        "Empty Reply",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (FeedbackID <= 0)
                {
                    MessageBox.Show(
                        "Invalid feedback ID. Please close and try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string updateSql = @"
                UPDATE Feedback
                SET    ManagerReply = @Reply,
                       ReplyDate    = GETDATE()
                WHERE  FeedbackID   = @FeedbackID";

                SqlParameter[] p =
                {
                new SqlParameter("@Reply",      replyText),
                new SqlParameter("@FeedbackID", FeedbackID)
            };

                int rows = DatabaseHelper.ExecuteNonQuery(updateSql, p);

                if (rows > 0)
                {
                    ReplySent = true;
                    MessageBox.Show(
                        "Reply sent successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to send reply. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
