using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Minigames1
{
    public partial class Form1 : Form
    {
        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
        public static bool hihi = true;

        public Form1()
        {
            InitializeComponent();
            player.URL = "games.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chude().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
            if (hihi == true)
            {
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\pause .png");
            }
            else
            {
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\stop.png");
            }
        }

        private void pic_TurnOnMusic_Click(object sender, EventArgs e)
        {
        }

        private void btn_test_audio_Click(object sender, EventArgs e)
        {
            if(hihi==true)
            {
                player.controls.pause();
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\stop.png");
                hihi = false;
            }
            else
            {
                player.controls.play();
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\pause .png");
                hihi = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_viewlist_Click(object sender, EventArgs e)
        {
            listword lw = new listword();
            this.Hide();
            lw.ShowDialog();
        }

        private void btn_ranking_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Rank r = new Rank();
            //r.ShowDialog();
        }

        private void btn_rank_Click(object sender, EventArgs e)
        {
        }
    }
}
