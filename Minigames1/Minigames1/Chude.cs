using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minigames1
{
    public partial class Chude : Form
    {
        string[] listdapan1 = { "APPLE", "PEACH", "BANANA", "PINEAPPLE", "BLUEBERRY", "CHERRY", "FIG", "GRAPE", "KIWI", "MANGO" };
        string[] listdapan2 = { "BEAR", "BIRD", "BUTTERFLY", "CAT", "COW", "CROCODILE", "ELEPHANT", "FISH", "HORSE", "FROG" };
        string[] listdapan3 = { "BEET", "BROCCOLI", "CARROT", "CORN", "TOMATO", "ONION", "GARLIC", "MUSHROOM", "POTATO", "EGGPLANT" };
        public Chude()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruits fruits = new Fruits(1,listdapan1);
            fruits.Show();
        }

        private void pic_TurnOnMusic_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_VisibleChanged(object sender, EventArgs e)
        {  
        }

        private void pic_TurnOnMusic_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void btn_test_audio_Click(object sender, EventArgs e)
        {
            if (Form1.hihi == true)
            {
                Form1.player.controls.pause();
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\stop.png");
                Form1.hihi = false;
            }
            else
            {
                Form1.player.controls.play();
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\pause .png");
                Form1.hihi = true;
            }
        }

        private void Chude_Load(object sender, EventArgs e)
        {
            if (Form1.hihi == true)
            {
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\pause .png");
            }
            else
            {
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\stop.png");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbx_animal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruits fruits = new Fruits(2, listdapan2);
            fruits.Show();
        }

        private void picbx_vegetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruits fruits = new Fruits(3, listdapan3);
            fruits.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
        }
    }
}
