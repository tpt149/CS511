using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musicapp
{
    public partial class Form4 : Form
    {
        string namePlaylist;
        public Form4(string namePlaylist_)
        {
            InitializeComponent();
            namePlaylist = namePlaylist_;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < Form1.songsPlayList.Name.Count; j++)
            {
                if (Form1.songsPlayList.PlayList[j] == namePlaylist)
                {
                    for (int i = 0; i < Form1.songs.Name.Count; i++)
                    {
                        if (Form1.songsPlayList.Name[j] == Form1.songs.Name[i])
                        {
                            song x = new song();
                            x.ItemName = Form1.songs.Name[i];
                            //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                            //x.ItemImage = Image.FromFile(@"..//..//img" + "/" + Form1.songs.Type[rand[i]] + "/" + Form1.songs.Id[rand[i]] + ".png");
                            x.ItemType = Form1.songs.Type[i];
                            x.ItemImage = Form1.songs.Id[i];
                            x.ItemAuthor = Form1.songs.Author[i];
                            x.ItemLove = Form1.songs.Love[i];
                            x.ItemDuration = Form1.songs.Dur[i];
                            //x.ItemStar = Form1.songs.Star[i];
                            x.ItemLyric = Form1.songs.Title[i];
                            //MessageBox.Show(this.Parent.Parent.GetType().ToString());
                            flowLayoutPanel1.Controls.Add(x);
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var s = (song)item;
                s.Visible = s.ItemName.ToLower().ToLower().Contains(txt.Trim().ToLower());
                if (s.Visible == false)
                {
                    s.Visible = s.ItemAuthor.ToLower().ToLower().Contains(txt.Trim().ToLower());
                    s.Visible = s.ItemType.ToLower().ToLower().Contains(txt.Trim().ToLower());
                }

            }
        }
    }
}
