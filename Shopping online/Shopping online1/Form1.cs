using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using System.Drawing.Drawing2D;

namespace Shopping_online1
{
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        public string temp;
        //UserControl pay1 = new Payy();
        //public static string setvalue_total = "";
        public Form1()
        {
            InitializeComponent();
            txtSearch.Visible = false;
            splitContainer1.Visible = false;
            splitContainer2.Visible = false;
            splitContainer2.Location = new Point(230, 200);
            lbl_delivery.Visible = false;
            txt_home.Visible = false;
            btn_takeaway.BackColor = Color.MistyRose;
            //payy1.Visible = false;
            firstCustomControl1.Location = new Point(213, 190);
            grid.RowTemplate.Height = 30;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            calendar.MinDate = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelCollection.Height += 10;
                if (panelCollection.Size == panelCollection.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelCollection.Height -= 10;
                if (panelCollection.Size == panelCollection.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void btn_collection_Click(object sender, EventArgs e)
        {
            timer1.Start();
            splitContainer1.Visible = true;
            txtSearch.Visible = true;
            splitContainer2.Visible = false;
            firstCustomControl1.Visible = false;
            //payy1.Visible = false;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            firstCustomControl1.Visible = true;
            firstCustomControl1.Location = new Point(275, 170);
            //payy1.Visible = false;
            splitContainer1.Visible = false;
            txtSearch.Visible = false;
            splitContainer2.Visible = false;
        }

        /*public void AddItem(string name, double cost, categories category, string icon)
        {
            flowLayoutPanel2.Controls.Add(new Widgets()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("Icon/" + icon),
                Tag = category
            }); ;
        }*/

        public void AddItem(string name, double cost, string category, string icon)
        {

            var w = new Widgets()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("Icon/" + icon)
            };
            flowLayoutPanel2.Controls.Add(w);

            w.Onselect += (ss, es) =>
            {
                var wdg = (Widgets)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text.Replace("$", ""))).ToString("C2");
                        CalculateTotal();
                        return;
                    }
                }
                grid.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.lblCost.Text });
                CalculateTotal();
            };
        }
        
        void CalculateTotal()
        {
            double tot = 0;
            foreach(DataGridViewRow item in grid.Rows)
            {
                tot+= double.Parse(item.Cells[2].Value.ToString().Replace("$", ""));
            }
            lblTot.Text = tot.ToString("C2");
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            /*//drinks
            AddItem("Latte Latte", 1.81, categories.Drinks, "Latte Latte.png");
            AddItem("Berry Berry Milk Tea", 2.41, categories.Drinks, "Berry Berry Milk Tea.png");
            AddItem("Cappucino - Vietnamo", 1.81, categories.Drinks, "Cappucino - Vietnamo.png");
            AddItem("Milk Black Tea", 1.81, categories.Drinks, "Milk Black Tea.png");
            AddItem("Milk Olong Tea", 1.81, categories.Drinks, "Milk Olong Tea.png");
            AddItem("Peach Milk Tea", 1.61, categories.Drinks, "Peach Milk Tea.png");
            AddItem("Phuc Long Milk Tea", 1.81, categories.Drinks, "Phuc Long Milk Tea.png");

            //snacks
            AddItem("Australian Raisins", 1.54, categories.Snacks, "Australian Raisins.png");
            AddItem("Dried Mangoes", 1.26, categories.Snacks, "Dried Mangoes.png");
            AddItem("Honey Grilled Ginger", 2.29, categories.Snacks, "Honey Grilled Ginger.png");
            AddItem("Plums Ginger", 1.82, categories.Snacks, "Plums Ginger.png");
            AddItem("Soft Dried Fruits", 1.26, categories.Snacks, "Soft Dried Fruits.png");

            //Bakey
            AddItem("Green Tea Choco Cake", 1.38, categories.Bakery, "Green Tea Choco Cake.png");
            AddItem("Passion Panna Cotta", 1.38, categories.Bakery, "Passion Panna Cotta.png");
            AddItem("Pure Butter Croissant", 0.79, categories.Bakery, "Pure Butter Croissant.png");
            AddItem("Tiramisu Mini", 1.38, categories.Bakery, "Tiramisu Mini.png");
            AddItem("Butter Chocolate Croissant", 0.88, categories.Bakery, "Butter Chocolate Croissant.png");*/
            //drinks
            AddItem("Latte Latte", 1.81, "Drinks", "Latte Latte.png");
            AddItem("Berry Berry Milk Tea", 2.41, "Drinks", "Berry Berry Milk Tea.png");
            AddItem("Cappucino - Vietnamo", 1.81, "Drinks", "Cappucino - Vietnamo.png");
            AddItem("Black Milk Tea", 1.81, "Drinks", "Black Milk Tea.png");
            AddItem("Oolong Milk Tea", 1.81, "Drinks", "Oolong Milk Tea.png");
            AddItem("Peach Milk Tea", 1.61, "Drinks", "Peach Milk Tea.png");
            AddItem("Phuc Long Tea Latte", 1.81, "Drinks", "Phuc Long Tea Latte.png");
            AddItem("Longan Tea (Jasmine)", 2.01, "Drinks", "Longan Tea (Jasmine).png");
            AddItem("Forest Black Tea", 2.82, "Drinks", "Forest Black Tea.png");
            AddItem("Matcha Latte", 1.81, "Drinks", "Matcha Latte.png");
            AddItem("Rose Tea", 2.01, "Drinks", "Rose Tea.png"); 
            AddItem("Lemon Black Tea", 1.61, "Drinks", "Lemon Black Tea.png");
            AddItem("Green Tea Ice Blended", 2.42, "Drinks", "Green Tea Ice Blended.png");
            AddItem("Choco-Almond Crunch", 2.42, "Drinks", "Choco-Almond Crunch.png");
            AddItem("Forest Fruit", 2.01, "Drinks", "Forest Fruit.png"); 
            AddItem("Tropical Fruit", 2.01, "Drinks", "Tropical Fruit.png");
            AddItem("Red Sunset", 2.22, "Drinks", "Red Sunset.png");
            AddItem("Love Autumn", 2.22, "Drinks", "Love Autumn.png");

            //snacks
            AddItem("Australian Raisins", 1.54, "Snacks", "Australian Raisins.png");
            AddItem("Dried Mangoes", 1.26, "Snacks", "Dried Mangoes.png");
            AddItem("Honey Grilled Ginger", 2.29, "Snacks", "Honey Grilled Ginger.png");
            AddItem("Plums Ginger", 1.82, "Snacks", "Plums Ginger.png");
            AddItem("Soft Dried Fruits", 1.26, "Snacks", "Soft Dried Fruits.png");
            AddItem("Dried Papaya", 1.27, "Snacks", "Dried Papaya.png"); 
            AddItem("Dried Fragrant", 1.26, "Snacks", "Dried Fragrant.png");

            //Bakery
            AddItem("Green Tea Choco Cake", 1.38, "Bakery", "Green Tea Choco Cake.png");
            AddItem("Passion Panna Cotta", 1.38, "Bakery", "Passion Panna Cotta.png");
            AddItem("Pure Butter Croissant", 0.79, "Bakery", "Pure Butter Croissant.png");
            AddItem("Tiramisu Mini", 1.38, "Bakery", "Tiramisu Mini.png");
            AddItem("Butter Chocolate Croissant", 0.88, "Bakery", "Butter Chocolate Croissant.png");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length==0)
            {
                foreach (var item in flowLayoutPanel2.Controls)
                {
                    var wdg = (Widgets)item;
                    wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(txtSearch.Text.Trim().ToLower());
                }
            }
        }
        
        private void btn_drinks_Click(object sender, EventArgs e)
        {
            string a = "Drinks";
            txtSearch.Text = "Search items";
            txtSearch.ForeColor = Color.Silver;
            splitContainer1.Visible = true;
            txtSearch.Visible = true;
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var wdg = (Widgets)item;
                wdg.Visible = wdg.lbl_cate.Text.ToLower().ToLower().Contains(a.Trim().ToLower());
            }
            
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text=="Search items")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                txtSearch.Text = "Search items";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_snacks_Click(object sender, EventArgs e)
        {
            string a = "Snack";
            txtSearch.Text = "Search items";
            txtSearch.ForeColor = Color.Silver;
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var wdg = (Widgets)item;
                wdg.Visible = wdg.lbl_cate.Text.ToLower().ToLower().Contains(a.Trim().ToLower());
            }
        }

        private void btn_Bakery_Click(object sender, EventArgs e)
        {
            string a = "Bakery";
            txtSearch.Text = "Search items";
            txtSearch.ForeColor = Color.Silver;
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var wdg = (Widgets)item;
                wdg.Visible = wdg.lbl_cate.Text.ToLower().ToLower().Contains(a.Trim().ToLower());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = false;
            txtSearch.Visible = false;
            if (double.Parse(lblTot.Text.Replace("$", "")) != 0)
            {
                splitContainer2.Visible = true;
            }
            lbl_temp.Text = lblTot.Text;
            firstCustomControl1.Visible = false;
            //payy1.Visible = true;
            //payy1.Location = new Point(275, 217);
            //setvalue_total = lblTot.Text;
            //Pay p = new Pay();
            //p.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = false;
            txtSearch.Visible = false;
            if(double.Parse(lblTot.Text.Replace("$", "")) !=0)
            {
                splitContainer2.Visible = true;
            }
            lbl_temp.Text = lblTot.Text;
            firstCustomControl1.Visible = false;
            //payy1.Visible = true;
            //payy1.Location = new Point(275, 217);
        }

        private void btn_takeaway_Click(object sender, EventArgs e)
        {
            lbl_delivery.Visible = false;
            txt_home.Visible = false;
            lbl_store.Visible = true;
            cb_store.Visible = true;
            btn_takeaway.BackColor = Color.MistyRose;
            btn_delivery.BackColor = Color.White;
        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            btn_delivery.BackColor = Color.MistyRose;
            btn_takeaway.BackColor = Color.White;
            lbl_store.Visible = false;
            cb_store.Visible = false;
            lbl_delivery.Visible = true;
            txt_home.Visible=true;
            lbl_delivery.Location = lbl_store.Location;
            txt_home.Location = cb_store.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_loadtotal_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btn_loadcollect_Click(object sender, EventArgs e)
        {

        }
        
        public class receipt
        {
            public string item { get; set; }
            public double qty { get; set; }
            public string cost { get; set; }
        }

        public class customer
        {
            public string name { get; set; }
            public string phone { get; set; }
            public string date { get; set; }
        }
        ReportDataSource rs = new ReportDataSource();
        private void btn_makepayment_Click(object sender, EventArgs e)
        {
            List<receipt> list = new List<receipt>();
            list.Clear();

            for (int i = 0; i < grid.Rows.Count; i++)
            {
                receipt r = new receipt
                {
                    item = grid.Rows[i].Cells[0].Value.ToString(),
                    qty = int.Parse(grid.Rows[i].Cells[1].Value.ToString()),
                    cost = grid.Rows[i].Cells[2].Value.ToString()
                };
                list.Add(r);
            }
            rs.Name = "DataSet1";
            rs.Value = list;
            Form2 frm = new Form2();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            customer c = new customer
            {
                name = txt_name.Text,
                phone = txt_phone.Text,
                date = calendar.Value.ToString()
            };
            ReportParameter para1 = new ReportParameter();
            ReportParameter para2 = new ReportParameter();
            ReportParameter para3 = new ReportParameter();
            ReportParameter para4 = new ReportParameter();
            para1.Name = "total";
            para1.Values.Add(lblTot.Text);
            para2.Name = "name";
            para2.Values.Add(c.name);
            para3.Name = "phone";
            para3.Values.Add(c.phone);
            para4.Name = "time";
            para4.Values.Add(c.date);
            frm.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4 });
            var qrcode_text = $"2|99|{txt_phone.Text.Trim()}|{txt_name.Text.Trim()}|{txt_phone.Text.Trim()}|0|0|{lbl_temp.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = null;
            if(rdo_cash.Checked)
            {
                frm.pic_qrcode.Visible = false;
                frm.reportViewer1.Dock = DockStyle.Bottom;
            }
            if (rdo_momo.Checked)
            {
                logo = resizeImage(Properties.Resources.logo_momo, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                frm.pic_qrcode.Image = bitmap;
            }
            if (rdo_zalo.Checked)
            {
                logo = resizeImage(Properties.Resources.logo_zalopay, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                frm.pic_qrcode.Image = bitmap;
            }
            if (rdo_shopee.Checked)
            {
                logo = resizeImage(Properties.Resources.logo_shopeepay, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                frm.pic_qrcode.Image = bitmap;
            }
            frm.ShowDialog();
        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }
    }
}
