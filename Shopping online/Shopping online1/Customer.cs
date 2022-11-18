using Shopping_online1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_online1
{
    public partial class Customer : Form
    {
        string a;
        public Customer()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btn_send_Click(object sender, EventArgs e)
        {
            i++;
            feedback f = new feedback();
            flowLayoutPanel1.Controls.Add(f);
            f.lbl_fb.Text = txt_fb.Text;
            f.lbl_rate.Text = a;
            f.lbl_name.Text = "Customer " + i.ToString();
            //f.lbl_name.Text = inf.txt_name.Text;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
