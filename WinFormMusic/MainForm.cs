using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMusic.Classes;

namespace WinFormMusic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeApplication();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataLayer.SelectMusicBySongName(tbSearchText.Text);

            dgwMusic.DataSource = dataTable;

            Log("User Searched: " + tbSearchText.Text);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedSongID = Convert.ToInt32(dgwMusic.SelectedRows[0].Cells["SongID"].Value);

                DataLayer.UpdateMusic(selectedSongID, tbSongName.Text, tbSongGenre.Text, tbWritersCredits.Text, tbProducerCredits.Text);

                RefreshMusicGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }
        }

        private void RefreshMusicGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectAllMusic();

            dgwMusic.DataSource = dataTable;
        }


        

        public void InitializeApplication()
        {

            StartPosition = FormStartPosition.CenterScreen;

            dgwMusic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            RefreshMusicGridView();


            // dgwProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void ErrorLog(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("ErrorLog.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        private void Log(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("Log.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            dgwMusic.DataSource = DataLayer.SelectMusicBySongName(tbSearchText.Text);
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSongsForm addSongsForm = new AddSongsForm();

            addSongsForm.ShowDialog();

            RefreshMusicGridView();
        }

        private void deleteSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedSongID = Convert.ToInt32(dgwMusic.SelectedRows[0].Cells["SongID"].Value);

                DialogResult result = MessageBox.Show("Delete Song " + selectedSongID + "?", "Confirm", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    DataLayer.DeleteMusic(selectedSongID);

                    RefreshMusicGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }
        }
    }
}
