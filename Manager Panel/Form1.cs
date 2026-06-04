using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loadform(Form f)
        {


        }
        private void addUserControl(UserControl userControl)
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);


            this.mainpanel.Controls.Add(userControl);
            this.mainpanel.Tag = userControl;
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {

            feedback uc = new feedback();
            addUserControl(uc);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void walletbtn_Click(object sender, EventArgs e)
        {
            Wallet uc = new Wallet();
            addUserControl(uc);
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {
            mainpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Login newform = new Login();

            newform.Show();


        }
    }
}
       

         
        

