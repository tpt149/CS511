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
    public partial class Form3 : Form
    {
        string namePlayList;
        public Form3(string namePlayList_)
        {
            InitializeComponent();
            namePlayList = namePlayList_;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.songs.Name.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = Form1.songs.Name[i];
                dgv.Rows[i].Cells[1].Value = Form1.songs.Author[i];
                dgv.Rows[i].Cells[2].Value = Form1.songs.Type[i];
                dgv.Rows[i].Cells[3].Value = Form1.songs.Dur[i];
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            int rowIdex = dgv.CurrentCell.RowIndex;
            string name = dgv.Rows[rowIdex].Cells[0].Value.ToString();
            int index = Form1.songsPlayList.Name.IndexOf(name);
            if (index == -1 || Form1.songsPlayList.PlayList[index] != namePlayList)
            {
                Form1.songsPlayList.Name.Add(name);
                Form1.songsPlayList.PlayList.Add(namePlayList);
                MessageBox.Show("Added this song to the playlist " + namePlayList);
            }
            else
            {
                MessageBox.Show("The song already exists in playList " + namePlayList);
            }
        }
    }
}
