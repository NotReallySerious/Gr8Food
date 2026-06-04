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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manager_Panel
{
    public partial class CustFeedback : UserControl
    {
        public int FeedbackID { get; set; }
        public string Status { get; set; }
        public CustFeedback()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private string _title;
        private string _message;


        public string Title
        {
            get { return _title; }
            set { _title = value; lblCustomerName.Text = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; lblmessage.Text = value; }
        }

        private void replybtn_Click(object sender, EventArgs e)
        {
            if (Status == "Replied")
            {
                MessageBox.Show(
                    "This feedback has already been replied to.",
                    "Already Replied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            Reply replyForm = new Reply();
            replyForm.FeedbackID = this.FeedbackID;
            replyForm.CustomerName = this.Title;

        
            replyForm.FormClosed += (s, ev) =>
            {
                if (replyForm.ReplySent)
                {
                    Status = "Replied";
                    replybtn.Text = "Replied";
                    replybtn.Enabled = false;

                }
            };

            replyForm.Show();
        }
    
   
        

