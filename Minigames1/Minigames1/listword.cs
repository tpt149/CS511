using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minigames1
{
    public partial class listword : Form
    {
        public static DataTable Fruits = new DataTable();
        public static DataTable Animals = new DataTable();
        public static DataTable Vegetables = new DataTable();
        public listword()
        {
            InitializeComponent();
            try
            {

                Fruits.Columns.Add("ID", typeof(string));
                Fruits.Columns.Add("VOCAB", typeof(string));
                Fruits.Columns.Add("MEAN", typeof(string));

                Animals.Columns.Add("ID", typeof(string));
                Animals.Columns.Add("VOCAB", typeof(string));
                Animals.Columns.Add("MEAN", typeof(string));

                Vegetables.Columns.Add("ID", typeof(string));
                Vegetables.Columns.Add("VOCAB", typeof(string));
                Vegetables.Columns.Add("MEAN", typeof(string));

                Fruits.Rows.Add("1", "Apple", "Táo");
                Fruits.Rows.Add("2", "Peach", "Đào");
                Fruits.Rows.Add("3", "Banana", "Chuối");
                Fruits.Rows.Add("4", "Strawberry", "Dâu");
                Fruits.Rows.Add("5", "Blueberry", "Việt quốc");
                Fruits.Rows.Add("6", "Cherry", "Cherry");
                Fruits.Rows.Add("7", "Fig", "Sung");
                Fruits.Rows.Add("8", "Grape", "Nho");
                Fruits.Rows.Add("9", "Kiwi", "Kiwi");
                Fruits.Rows.Add("10", "Mango", "Xoài");

                Animals.Rows.Add("1", "Bear", "Gấu");
                Animals.Rows.Add("2", "Bird", "Chim");
                Animals.Rows.Add("3", "Butterfly", "Bướm");
                Animals.Rows.Add("4", "Cat", "Mèo");
                Animals.Rows.Add("5", "Cow", "Bò");
                Animals.Rows.Add("6", "Crocodile", "Cá sấu");
                Animals.Rows.Add("7", "Elephant", "Voi");
                Animals.Rows.Add("8", "Fish", "Cá");
                Animals.Rows.Add("9", "Horse", "Ngựa");
                Animals.Rows.Add("10", "Frog", "Ếch");

                Vegetables.Rows.Add("1", "Beet", "Củ dền");
                Vegetables.Rows.Add("2", "Broccoli", "Bông cải xanh");
                Vegetables.Rows.Add("3", "Carrot", "Cà rốt");
                Vegetables.Rows.Add("4", "Corn", "Bắp");
                Vegetables.Rows.Add("5", "Tomato", "Cà chua");
                Vegetables.Rows.Add("6", "Onion", "Củ hành");
                Vegetables.Rows.Add("7", "Garlic", "Tỏi");
                Vegetables.Rows.Add("8", "Mushroom", "Nấm");
                Vegetables.Rows.Add("9", "Potato", "Khoai tây");
                Vegetables.Rows.Add("10", "Eggplant", "Cà tím");

            }
            catch { }

            dataGridView1.DataSource = Fruits;
            dataGridView2.DataSource = Animals;
            dataGridView3.DataSource = Vegetables;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
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

        private void listword_Load(object sender, EventArgs e)
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
    }
}
