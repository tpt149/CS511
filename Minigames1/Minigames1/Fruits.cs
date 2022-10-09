using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Minigames1
{
    public partial class Fruits : Form
    {
        public static DataTable dtrank = new DataTable();
        public static string type = "";
        string[] listimages;
        int index;
        int[] listindexdadung;
        int indexdadung;
        string[] listdapan;
        public int CorrectAnswers = 0;
        public int points = 0;
        public int rest = 10;
        public int temp;
        public int hints = 3;
        public int a = 0;
        public int dem = 0;
        public Fruits(int x, string[] v)
        {
            InitializeComponent();
            listdapan = v;
            temp = x;
            try
            {
                dtrank.Columns.Add("Core", typeof(int));
                dtrank.Columns.Add("Time", typeof(string));
                dtrank.Columns.Add("Theme", typeof(string));
            }
            catch
            {
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFirstHint.Text = "Length of this word = " + listdapan[index].Length.ToString();
            lblFirstHint.Visible = true;
            picLock.Visible = false;
            btnSecondHint.Enabled = true;
            hints--;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_check.Enabled = true;
            a = a + 1;
            if (a < 5)
            {
                lbl_hideanswer.Text = listdapan[index];
                if (txt_input.Text.Trim() == "" || txt_input.Text.Trim() == "Type your answer here...")
                {
                    lbl_goodjob.Visible = true;
                    lbl_goodjob.ForeColor = Color.Red;
                    lbl_goodjob.Text = "Please type an answer first!";
                }
                MessageBox.Show(lbl_hideanswer.Text);
                bool Checkk;
                do
                {
                    Random rd = new Random();
                    index = rd.Next(0, listimages.Length);
                    Checkk = true;
                    for (int i = 0; i <= indexdadung; ++i)
                    {
                        if (listindexdadung[i] == index)
                        {
                            Checkk = false;
                            break;
                        }
                    }
                    if (Checkk == true)
                    {
                        pic.ImageLocation = listimages[index];
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Show();
                        lbl_hideanswer.Text = listdapan[index];
                        if (txt_input.Text.Trim() == "" || txt_input.Text.Trim() == "Type your answer here...")
                        {
                            lbl_goodjob.Visible = true;
                            lbl_goodjob.ForeColor = Color.Red;
                            lbl_goodjob.Text = "Please type an answer first!";
                        }
                        listindexdadung[++indexdadung] = index;
                    }
                    txt_input.Text = "";
                    txt_input.Focus();
                } while (Checkk == false);
                dem += 1;
                lbl_left.Text = dem + "/5";
                //if(indexdadung == listindexdadung.Length-1)
                //{
                // 
                // }
            }
            else
            {
                dtrank.Rows.Add(points, DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"), type);
            }
        }

        private void Fruits_Load(object sender, EventArgs e)
        {
            if (Form1.hihi == true)
            {
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\pause .png");
            }
            else
            {
                btn_test_audio.BackgroundImage = Image.FromFile("C:\\Code\\C#\\Minigames1\\Minigames1\\stop.png");
            }
            listimages = new string[10];
            listindexdadung = new int[10];
            if (temp == 1)
            {
                for (int i = 1; i <= listimages.Length; i++)
                {
                    listimages[i - 1] = "C:\\Code\\C#\\Minigames1\\Minigames1\\Images\\Fruits\\" + i + ".png";
                }
            }
            else if (temp == 2)
            {
                for (int i = 1; i <= listimages.Length; i++)
                {
                    listimages[i - 1] = "C:\\Code\\C#\\Minigames1\\Minigames1\\Images\\Animals\\" + i + ".png";
                }
            }
            else if (temp == 3)
            {
                for (int i = 1; i <= listimages.Length; i++)
                {
                    listimages[i - 1] = "C:\\Code\\C#\\Minigames1\\Minigames1\\Images\\Vegetables\\" + i + ".png";
                }
            }
            Random rd = new Random();
            index = rd.Next(0, listimages.Length);
            indexdadung = 0;
            listindexdadung[indexdadung] = index;
            pic.ImageLocation = listimages[index];
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_hideanswer.Text = listdapan[index];
            pic.Show();
            dem += 1;
            lbl_left.Text = dem + "/5";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void RemoveText()
        {
            if (txt_input.Text == "Type your answer here...")
            {

                txt_input.Text = "";
            }
        }

        public void AddText()
        {
            if (String.IsNullOrWhiteSpace(txt_input.Text))
            {
                txt_input.Text = "Type your answer here...";
            }
        }

        public void CorrectAnswer()
        {
            //txt_input.Enabled = false;

            lbl_goodjob.Text = "Great job!You correctly.";
            CorrectAnswers++;
            lbl_goodjob.Visible = true;
            lbl_goodjob.ForeColor = Color.SeaGreen;
            points += 20;
            lbl_point.Text = points + "/100";
            btn_check.Enabled = false;
        }
        public void IncorrectAnswer()
        {
            //txt_input.Enabled = false;
            lbl_goodjob.ForeColor = Color.IndianRed;
            lbl_goodjob.Text = "Sorry, your answer was incorrect.";
            lbl_goodjob.Visible = true;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (lbl_hideanswer.Text.Trim().ToLower() == txt_input.Text.Trim().ToLower())
            {
                CorrectAnswer();
            }
            else
            {
                IncorrectAnswer();

            }
        }

        private void lbl_hideanswer_VisibleChanged(object sender, EventArgs e)
        {
            lbl_hideanswer.Visible = false;
        }

        private void pic_TurnOnMusic_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Chude f1 = new Chude();
            this.Hide();
            f1.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
        }

        private void btnSecondHint_Click(object sender, EventArgs e)
        {
            lblSecondHint.Text = "The word start with " + listdapan[index].Substring(0, 1).ToUpper();
            lblSecondHint.Visible = true;
            picLock2.Visible = false;
            hints--;
        }

        private void btn_rank_Click(object sender, EventArgs e)
        {
            Rank r = new Rank(dtrank);
            r.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_thirdhint_Click(object sender, EventArgs e)
        {
            lblThirdHint.Text = "The word end with " + lbl_hideanswer.Text.Substring(lbl_hideanswer.Text.Length - 1, 1).ToUpper();
            lblThirdHint.Visible = true;
            hints--;
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_check_Click(sender, e);
        }
    }

}
