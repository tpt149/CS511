﻿using Shopping_online1.Properties;
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
            txt_fb.Text = "Write your feedback...";
            txt_fb.ForeColor = Color.Silver;
        }
        int i = 0;
        private void btn_send_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.white_star;
            pictureBox2.Image = Resources.white_star;
            pictureBox3.Image = Resources.white_star;
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;
            i++;
            feedback f = new feedback();
            flowLayoutPanel1.Controls.Add(f);
            f.lbl_fb.Text = txt_fb.Text;
            f.lbl_rate.Text = "Rate: "+a;
            f.lbl_name.Text = "Customer " + i.ToString();
            if (txt_fb.Text != "")
            {
                txt_fb.Text = "Write your feedback...";
                txt_fb.ForeColor = Color.Silver;
            }
            //f.lbl_name.Text = inf.txt_name.Text;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.white_star;
            pictureBox3.Image = Resources.white_star;
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;

            pictureBox1.Image = Resources.yellow_star;
            a = "1";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.white_star;
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;

            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            a = "2";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;

            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.yellow_star;
            a = "3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.white_star;

            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.yellow_star;
            pictureBox4.Image = Resources.yellow_star;
            a = "4";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.yellow_star;
            pictureBox4.Image = Resources.yellow_star;
            pictureBox5.Image = Resources.yellow_star;
            a = "5";
        }

        private void txt_fb_Leave(object sender, EventArgs e)
        {
        }

        private void txt_fb_Enter(object sender, EventArgs e)
        {
        }

        private void txt_fb_TextChanged(object sender, EventArgs e)
        {
            txt_fb.ForeColor = Color.Black;
        }

        private void txt_fb_Click(object sender, EventArgs e)
        {
            txt_fb.Text = "";
        }
    }
}
