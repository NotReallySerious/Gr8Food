using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Manager_Panel
{
    public partial class Wallet : UserControl
    {
        public Wallet()
        {
            InitializeComponent();

        }

        private void EWalletUserControl_Load(object sender, EventArgs e)
        {
            ComboBoxes();
            LoadMetrics();
            LoadTransactions();
        }

        private void ComboBoxes()
        {
            
            cmballyear.Items.Clear();
            cmballyear.Items.Add("All Years");
            cmballyear.Items.Add("2025");
            cmballyear.Items.Add("2026");
            cmballyear.SelectedIndex = 0;

            cmballmonth.Items.Clear();
            cmballmonth.Items.Add("All Months");
            cmballmonth.Items.AddRange(new string[]
            {
                "January","February","March","April",
                "May","June","July","August",
                "September","October","November","December"
            });
            cmballmonth.SelectedIndex = 0;

            
            searchbox.Text = "Search customer name...";
            

            searchbox.GotFocus += (s, e) =>
            {
                if (searchbox.Text == "Search customer name...")
                {
                    searchbox.Text = "";
                    
                }
            };
            searchbox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(searchbox.Text))
                {
                    searchbox.Text = "Search customer name...";
                    
                }
            };
        }
        private void LoadMetrics()
        {
            
            string topupSql = @"
                SELECT ISNULL(SUM(Amount), 0)
                FROM   EWalletTransactions
                WHERE  TransactionType = 'TopUp'
                AND    MONTH(TransactionDate) = MONTH(GETDATE())
                AND    YEAR(TransactionDate)  = YEAR(GETDATE())";
            object topupResult = DatabaseHelper.ExecuteScalar(topupSql);
            txttopup.Text = "RM " + Convert.ToDecimal(topupResult).ToString("0.00");
            txttopup.ReadOnly = true;

          
            string usageSql = @"
                SELECT ISNULL(SUM(Amount), 0)
                FROM   EWalletTransactions
                WHERE  TransactionType = 'Usage'
                AND    MONTH(TransactionDate) = MONTH(GETDATE())
                AND    YEAR(TransactionDate)  = YEAR(GETDATE())";
            object usageResult = DatabaseHelper.ExecuteScalar(usageSql);
            txtusage.Text = "RM " + Convert.ToDecimal(usageResult).ToString("0.00");
            txtusage.ReadOnly = true;

            
            string custSql = @"
                SELECT COUNT(DISTINCT UserID)
                FROM   EWalletTransactions";
            object custResult = DatabaseHelper.ExecuteScalar(custSql);
            txtcust.Text = custResult?.ToString() ?? "0";
            txtcust.ReadOnly = true;
        }

        private void LoadTransactions()
        {
            string search = (searchbox.Text == "Search customer name...") ? "" : searchbox.Text.Trim();

            
            int monthIdx = cmballmonth.SelectedIndex;   
            string yearText = cmballyear.SelectedItem?.ToString() ?? "All Years";

            string sql = @"
                SELECT
                    u.FirstName + ' ' + u.LastName         AS Name,
                    u.LoginID                               AS [Cust ID],
                    t.TransactionType                       AS Type,
                    CONVERT(VARCHAR, t.TransactionDate, 106) AS Date,
                    t.Amount                                AS Total
                FROM  EWalletTransactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE 1=1";

            if (!string.IsNullOrEmpty(search))
                sql += $" AND (u.FirstName + ' ' + u.LastName) LIKE '%{search}%'";

            if (monthIdx > 0)
                sql += $" AND MONTH(t.TransactionDate) = {monthIdx}";

            if (yearText != "All Years")
                sql += $" AND YEAR(t.TransactionDate) = {yearText}";

            sql += " ORDER BY t.TransactionDate DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

           
            FLP.Controls.Clear();

            if (dt.Rows.Count == 0)
            {
                Label noData = new Label
                {
                    Text = "No transactions found.",
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
                walletcust custRow = new walletcust();
                custRow.name = row["Name"].ToString();
                custRow.ID = row["Cust ID"].ToString();
                custRow.Type = row["Type"].ToString();
                custRow.Date = row["Date"].ToString();
                custRow.total = "RM " + Convert.ToDecimal(row["Total"]).ToString("0.00");

                
                
      
                FLP.Controls.Add(custRow);
            }

            UpdateSummary(dt);
        }

        private void UpdateSummary(DataTable dt)
        {
            decimal totalTopUp = 0, totalUsage = 0;
            foreach (DataRow row in dt.Rows)
            {
                string type = row["Type"].ToString();
                decimal amount = Convert.ToDecimal(row["Total"]);
                if (type == "TopUp") totalTopUp += amount;
                else totalUsage += amount;
            }
            txttopup.Text = "RM " + totalTopUp.ToString("0.00");
            txtusage.Text = "RM " + totalUsage.ToString("0.00");


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadMetrics();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Wallet_Load(object sender, EventArgs e)
        {
            
        }

        private void walletcust1_Load(object sender, EventArgs e)
        {

        }

        private void Wallet_Load_1(object sender, EventArgs e)
        {

        }
    }
}
