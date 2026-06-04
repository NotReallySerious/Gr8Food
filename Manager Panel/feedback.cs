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
    

    public partial class feedback : UserControl
    {
        public feedback()
        {
            InitializeComponent(); 
            InitializeStatusFilter();
        }


        private void FeedbackUserControl_Load(object sender, EventArgs e)
        { 
            LoadMetrics();
            LoadFeedbackCards();
        }
        private void InitializeStatusFilter()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.AddRange(new string[] { "All", "Pending", "Replied" });
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadMetrics()
        {
            object totalResult = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Feedback");
            txttopup.Text = totalResult?.ToString() ?? "0";
            txttopup.ReadOnly = true;

            object pendingResult = DatabaseHelper.ExecuteScalar(
                "SELECT COUNT(*) FROM Feedback WHERE ManagerReply IS NULL");
            txtreplies.Text = pendingResult?.ToString() ?? "0";
            txtreplies.ReadOnly = true;
        }



        private void LoadFeedbackCards()
        {
            string statusFilter = cmbStatusFilter.SelectedItem?.ToString() ?? "All";

            string sql = @"
                SELECT
                    f.FeedbackID,
                    u.FirstName + ' ' + u.LastName         AS Customer,
                    f.Rating,
                    f.Message,
                    ISNULL(f.ManagerReply, '')              AS Reply,
                    CASE WHEN f.ManagerReply IS NULL
                         THEN 'Pending' ELSE 'Replied'
                    END                                     AS Status,
                    CONVERT(VARCHAR, f.FeedbackDate, 106)  AS FeedbackDate
                FROM  Feedback f
                INNER JOIN Users u ON f.CustomerID = u.UserID
                WHERE 1=1";

            if (statusFilter == "Pending")
                sql += " AND f.ManagerReply IS NULL";
            else if (statusFilter == "Replied")
                sql += " AND f.ManagerReply IS NOT NULL";

            sql += " ORDER BY f.FeedbackDate DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

            
            FLP.Controls.Clear();

            if (dt.Rows.Count == 0)
            {
                Label noData = new Label
                {
                    Text = "No feedback found.",
                    Font = new Font("Segoe UI", 10f),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(10)
                };
                FLP.Controls.Add(noData);
                return;
            }

           
            foreach (DataRow row in dt.Rows)
            {
                
                CustFeedback card = new CustFeedback();

                
                card.Title = row["Customer"].ToString();
                card.Message = row["Message"].ToString();
                card.FeedbackID = Convert.ToInt32(row["FeedbackID"]);
                card.Status = row["Status"].ToString();

                
                card.CardReplied += (s, e) =>
                {
                    LoadMetrics();
                    LoadFeedbackCards();
                };

                FLP.Controls.Add(card);
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Replied");
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void filterbtn_Click(object sender, EventArgs e)
        {
            LoadFeedbackCards();
            LoadMetrics();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void custFeedback1_Load(object sender, EventArgs e)
        {

        }

        private void custFeedback3_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void feedback_Load(object sender, EventArgs e)
        {
      
        }

        private void txttopup_TextChanged(object sender, EventArgs e)
        {

        }

        private void custFeedback2_Load(object sender, EventArgs e)
        {

        }
    }

}
