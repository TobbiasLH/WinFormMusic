using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMusic.Classes;

namespace WinFormMusic
{
    public partial class AddSongsForm : Form
    {
        public AddSongsForm()
        {
            InitializeComponent();

            RefreshMusicGridView();
        }


        private void RefreshMusicGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectAllMusic();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataLayer.InsertMusic(tbSongName.Text, tbSongGenre.Text, tbWritersCredits.Text, tbProducerCredits.Text);

            Close();
        }
    }
}
