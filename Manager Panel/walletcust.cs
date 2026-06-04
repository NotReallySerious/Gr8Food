using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_Panel
{
    public partial class walletcust : UserControl
    {
        public walletcust()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string _name;
        private string _ID;
        private string _type;
        private string _date;
        private string _total;

        public string name
        {
            get { return _name; }
            set { _name = value; lblCusname.Text = value; }
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; lblCusID.Text = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; lblType.Text = value;  }
        }
       
        public string Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = value; }
        }
        
        public string total
        {
            get { return _total; }
            set { _total = value; lbltotal.Text = value;  }
        }

        private void walletcust_Load(object sender, EventArgs e)
        {

        }
    }
    }

