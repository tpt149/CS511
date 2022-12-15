using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace Musicapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top + 10;
            bunifuPages1.SetPage(0);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top + 12;
            bunifuPages1.SetPage(1);
        }
        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaylists.Top + 12;
            bunifuPages1.SetPage(2);
            try
            {
                flowLayoutPanel2.Visible = true;
            }
            catch
            {

            }
        }
        private void btnLiked_Click(object sender, EventArgs e)
        {
            indicator.Top = btnLiked.Top + 13;
            bunifuPages1.SetPage(3);
            loadFavorite();
        }
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//xml/history.xml";
        private void btnHistory_Click(object sender, EventArgs e)
        {
            indicator.Top = btnHistory.Top + 14;
            bunifuPages1.SetPage(4);
            doc.Load(fileName);
            root = doc.DocumentElement;
            dgv.Rows.Clear();
            dgv.ColumnCount = 7;
            XmlNodeList ds = root.SelectNodes("song");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("name").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("author").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("type").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("time").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("image").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("lyric").InnerText;
                dgv.Rows[sd].Cells[6].Value = item.SelectSingleNode("love").InnerText;
                sd++;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(0);   
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public static class songs
        {
            private static List<string> name = new List<string>();
            private static List<string> author = new List<string>();
            private static List<string> dur = new List<string>();
            private static List<string> id = new List<string>();
            private static List<string> star = new List<string>();
            private static List<string> type = new List<string>();
            private static List<string> title = new List<string>();
            private static List<string> love = new List<string>();
            private static List<string> playList = new List<string>();

            public static List<string> Name { get => name; set => name = value; }
            public static List<string> Author { get => author; set => author = value; }
            public static List<string> Dur { get => dur; set => dur = value; }
            public static List<string> Id { get => id; set => id = value; }
            public static List<string> Star { get => star; set => star = value; }
            public static List<string> Type { get => type; set => type = value; }
            public static List<string> Title { get => title; set => title = value; }
            public static List<string> Love { get => love; set => love = value; }
            public static List<string> PlayList { get => playList; set => playList = value; }
        }
        public static class songsPlayList
        {
            private static List<string> name = new List<string>();
            private static List<string> playList = new List<string>();

            public static List<string> Name { get => name; set => name = value; }
            public static List<string> PlayList { get => playList; set => playList = value; }
        }

        public static class listFavorite
        {
            private static List<string> name = new List<string>();
            private static List<string> type = new List<string>();
            public static List<string> Name { get => name; set => name = value; }
            public static List<string> Type { get => type; set => type = value; }
        }

        private List<int> ranList(int sl)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            while (list.Count < sl)
            {
                int a = rand.Next(0, sl);
                if (list.Contains(a))
                {
                    continue;
                }
                else
                {
                    list.Add(a);
                }
            }
            return list;
        }
        public void loadData()
        {
            var xml = new XmlDocument();
            xml.Load(@"..//..//XML/music.xml");
            var type = new List<string>()
                    {
                        "remix",
                        "acoustic",
                        "pop",
                    };
            for (int k = 0; k < type.Count; k++)
            {
                XmlNodeList nodeList = xml.SelectNodes("/music" + "/" + type[k] + "/item");
                for (int i = 0; i < nodeList.Count; i++)
                {
                    Form1.songs.Name.Add(nodeList[i].SelectSingleNode("name").InnerText.Trim());
                    Form1.songs.Author.Add(nodeList[i].SelectSingleNode("author").InnerText.Trim());
                    Form1.songs.Dur.Add(nodeList[i].SelectSingleNode("dur").InnerText.Trim());
                    Form1.songs.Id.Add(nodeList[i].SelectSingleNode("id").InnerText.Trim());
                    Form1.songs.Star.Add(nodeList[i].SelectSingleNode("star").InnerText.Trim());
                    Form1.songs.Title.Add(nodeList[i].SelectSingleNode("title").InnerText.Trim());
                    Form1.songs.Love.Add("false");
                    Form1.songs.Type.Add(type[k]);
                }
            }
        }
        private void loadSongs(List<string> type)
        {
            flowLayoutPanel1.Controls.Clear();
            List<int> rand = ranList(Form1.songs.Name.Count);
            for (int i = 0; i < rand.Count; i++)
            {
                for (int j = 0; j < type.Count; j++)
                {
                    if (type[j] == Form1.songs.Type[rand[i]])
                    {
                        song x = new song();
                        x.ItemName = Form1.songs.Name[rand[i]];
                        //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                        //x.ItemImage = Image.FromFile(@"..//..//img" + "/" + Form1.songs.Type[rand[i]] + "/" + Form1.songs.Id[rand[i]] + ".png");
                        x.ItemType = Form1.songs.Type[rand[i]];
                        x.ItemImage = Form1.songs.Id[rand[i]];
                        x.ItemAuthor = Form1.songs.Author[rand[i]];
                        x.ItemDuration = Form1.songs.Dur[rand[i]];
                        x.ItemLove = Form1.songs.Love[rand[i]];
                        x.ItemLyric = Form1.songs.Title[rand[i]];
                        flowLayoutPanel1.Controls.Add(x);
                    }
                }
            }
        }
        private void loadFavorite()
        {
            flowLayoutPanel3.Controls.Clear();
            for (int i = 0; i < Form1.songs.Name.Count; i++)
            {
                if (Form1.songs.Love[i] == "true")
                {
                    song x = new song();
                    x.ItemName = Form1.songs.Name[i];
                    //MessageBox.Show("..//..//img" + "/" + Form1.songs.Type[i] + "/" + Form1.songs.Id[i] + ".png");
                    x.ItemType = Form1.songs.Type[i];
                    x.ItemImage = Form1.songs.Id[i];
                    x.ItemAuthor = Form1.songs.Author[i];
                    x.ItemDuration = Form1.songs.Dur[i];
                    x.ItemLove = Form1.songs.Love[i];
                    x.ItemLyric = Form1.songs.Title[i];
                    //MessageBox.Show(Form1.songs.Id[i], Form1.songs.Type[i]);
                    flowLayoutPanel3.Controls.Add(x);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var type = new List<string>()
                    {
                        "remix",
                        "acoustic",
                        "pop",
                    };
            loadSongs(type);
        }

        /*private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search items")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search items";
                txtSearch.ForeColor = Color.Silver;
            }
        }*/

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

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type=new List<string>();
            if(cbName.Text=="Acoustic")
            {
                type = new List<string>()
                {
                    "acoustic",
                };
            }
            else if (cbName.Text == "Remix")
            {
                type = new List<string>()
                {
                    "remix",
                };
            }
            else if (cbName.Text == "Pop")
            {
                type = new List<string>()
                {
                    "pop",
                };
            }
            else if (cbName.Text == "All")
            {
                type = new List<string>()
                {
                    "acoustic",
                    "pop",
                    "remix",
                };
            }
            loadSongs(type);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            root.RemoveAll();
            dgv.Rows.Clear();
            doc.Save(@"..//..//XML/history.xml");
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            int rowIdex = dgv.CurrentCell.RowIndex;
            string name = dgv.Rows[rowIdex].Cells[0].Value.ToString();
            string author = dgv.Rows[rowIdex].Cells[1].Value.ToString();
            string type = dgv.Rows[rowIdex].Cells[2].Value.ToString();
            string image = dgv.Rows[rowIdex].Cells[4].Value.ToString();
            string lyric = dgv.Rows[rowIdex].Cells[5].Value.ToString();
            string love = dgv.Rows[rowIdex].Cells[6].Value.ToString();


            Form2 page = new Form2(name, author, type, image, lyric, love);
            page.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void picCreate_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Enter Your Playlist Name", "Name Playlist", "", 500, 300);
            if (content != "")
            {
                playlist x = new playlist();
                x.NamePlayList = content;
                flowLayoutPanel2.Controls.Add(x);
            }
            else
            {
                MessageBox.Show("Enter Name PlayList!! Please!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var s = (playlist)item;
                s.Visible = s.Item_Name.ToLower().ToLower().Contains(txt.Trim().ToLower());
                if (s.Visible == false)
                {
                    //s.Visible = s.ItemAuthor.ToLower().ToLower().Contains(txt.Trim().ToLower());
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox3.Text;
            foreach (var item in flowLayoutPanel3.Controls)
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
