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
    public enum categories { Drinks, Snacks, Bakery }
    public partial class Widgets : UserControl
    {
        //private categories _category;
        private double cost;

        public event EventHandler Onselect = null;
        public Widgets()
        {
            InitializeComponent();
            lbl_cate.Visible = false;
        }

        //public categories Category { get => _category; set => _category = value; }
        public string Category { get => lbl_cate.Text; set => lbl_cate.Text = value; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public double Cost { get => cost; set { cost = value; lblCost.Text = cost.ToString("C2"); } }
        public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }

        private void imgImage_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }
    }
}
