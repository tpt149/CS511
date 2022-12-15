using Musicapp.Properties;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Musicapp
{
    public partial class Form2 : Form
    {
        string name; string author; string type, lyric; string img, love;
        public Form2(string name_, string author_, string type_, string img_, string lyric_, string love_)
        {
            name = name_;
            author = author_;
            type = type_;
            img = img_;
            lyric = lyric_;
            love = love_;
            InitializeComponent();
        }
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labAuthor.Text = author;
            labName.Text = name;
            //labType.Text = type;
            picSong.BackgroundImage = Image.FromFile(@"..//..//img" + "/" + type + "/" + img + ".png");
            txtLyric.Text = lyric;
            wplayer.URL = "C:\\Code\\C#\\Musicapp - Copy\\Musicapp\\nhac\\" + type + "\\" + img + ".mp3";
            wplayer.Ctlcontrols.play();
            if (love == "true")
            {
                picLove.BackgroundImage = Image.FromFile(@"..//..//img/icon/redheart.png");
            }

            //Add history
            Add(name, author, img, type, lyric, love);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string fileName = @"..//..//xml/history.xml";

        public void Add(string name, string author, string image, string type, string lyric, string love)
        {
            doc.Load(fileName);
            root = doc.DocumentElement;

            XmlNode item = doc.CreateElement("song");

            XmlElement Name_ = doc.CreateElement("name");
            Name_.InnerText = name;
            item.AppendChild(Name_);

            XmlElement Author_ = doc.CreateElement("author");
            Author_.InnerText = author;
            item.AppendChild(Author_);

            XmlElement Image_ = doc.CreateElement("image");
            Image_.InnerText = image;
            item.AppendChild(Image_);

            XmlElement Type_ = doc.CreateElement("type");
            Type_.InnerText = type;
            item.AppendChild(Type_);

            XmlElement Lyric_ = doc.CreateElement("lyric");
            Lyric_.InnerText = lyric;
            item.AppendChild(Lyric_);

            XmlElement Love_ = doc.CreateElement("love");
            Love_.InnerText = love;
            item.AppendChild(Love_);

            string time = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
            XmlElement Time_ = doc.CreateElement("time");
            Time_.InnerText = time;
            item.AppendChild(Time_);

            root.AppendChild(item);
            doc.Save(fileName);
        }
        public int time = 0, degree = 0;

        private void pb_str1_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str2.Image = Resources.white_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            lbl_core.Text = "1";
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            lbl_core.Text = "2";
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            lbl_core.Text = "3";
        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
            //change yellow star to white
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            lbl_core.Text = "4";
        }

        private void pb_str5_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            pb_str5.Image = Resources.yellow_star;
            lbl_core.Text = "5";
        }

        private void picLove_Click(object sender, EventArgs e)
        {

        }


        RotateImageClass rot = new RotateImageClass();
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            degree += 2;
            //if (time == 50)
            //{
            //    timer1.Stop();
            //}
            picSong.BackgroundImage = rot.RotateImage(Image.FromFile(@"..//..//img" + "/" + type + "/" + img + ".png"), degree);
        }
    }
}
