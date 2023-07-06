namespace WinFormMusic
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.lbSongs = new System.Windows.Forms.Label();
            this.dgwMusic = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbProducerCredits = new System.Windows.Forms.TextBox();
            this.tbWritersCredits = new System.Windows.Forms.TextBox();
            this.tbSongGenre = new System.Windows.Forms.TextBox();
            this.tbSongName = new System.Windows.Forms.TextBox();
            this.lbProducerCredits = new System.Windows.Forms.Label();
            this.lbWritersCredits = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songsToolStripMenuItem,
            this.lyricsToolStripMenuItem,
            this.beatsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.deleteSongToolStripMenuItem});
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.songsToolStripMenuItem.Text = "Songs";
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSongToolStripMenuItem.Text = "Add Song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.addSongToolStripMenuItem_Click);
            // 
            // deleteSongToolStripMenuItem
            // 
            this.deleteSongToolStripMenuItem.Name = "deleteSongToolStripMenuItem";
            this.deleteSongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSongToolStripMenuItem.Text = "Delete Song";
            this.deleteSongToolStripMenuItem.Click += new System.EventHandler(this.deleteSongToolStripMenuItem_Click);
            // 
            // lyricsToolStripMenuItem
            // 
            this.lyricsToolStripMenuItem.Name = "lyricsToolStripMenuItem";
            this.lyricsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lyricsToolStripMenuItem.Text = "Lyrics";
            // 
            // beatsToolStripMenuItem
            // 
            this.beatsToolStripMenuItem.Name = "beatsToolStripMenuItem";
            this.beatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beatsToolStripMenuItem.Text = "Beats";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearchText);
            this.panel1.Controls.Add(this.lbSongs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(144, 28);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(282, 20);
            this.tbSearchText.TabIndex = 1;
            this.tbSearchText.TextChanged += new System.EventHandler(this.tbSearchText_TextChanged);
            // 
            // lbSongs
            // 
            this.lbSongs.AutoSize = true;
            this.lbSongs.Location = new System.Drawing.Point(98, 31);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(40, 13);
            this.lbSongs.TabIndex = 0;
            this.lbSongs.Text = "Songs:";
            // 
            // dgwMusic
            // 
            this.dgwMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMusic.Location = new System.Drawing.Point(0, 296);
            this.dgwMusic.Name = "dgwMusic";
            this.dgwMusic.Size = new System.Drawing.Size(800, 154);
            this.dgwMusic.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.tbProducerCredits);
            this.panel2.Controls.Add(this.tbWritersCredits);
            this.panel2.Controls.Add(this.tbSongGenre);
            this.panel2.Controls.Add(this.tbSongName);
            this.panel2.Controls.Add(this.lbProducerCredits);
            this.panel2.Controls.Add(this.lbWritersCredits);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 203);
            this.panel2.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(293, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbProducerCredits
            // 
            this.tbProducerCredits.Location = new System.Drawing.Point(144, 158);
            this.tbProducerCredits.Name = "tbProducerCredits";
            this.tbProducerCredits.Size = new System.Drawing.Size(143, 20);
            this.tbProducerCredits.TabIndex = 9;
            // 
            // tbWritersCredits
            // 
            this.tbWritersCredits.Location = new System.Drawing.Point(144, 122);
            this.tbWritersCredits.Name = "tbWritersCredits";
            this.tbWritersCredits.Size = new System.Drawing.Size(143, 20);
            this.tbWritersCredits.TabIndex = 8;
            // 
            // tbSongGenre
            // 
            this.tbSongGenre.Location = new System.Drawing.Point(144, 82);
            this.tbSongGenre.Name = "tbSongGenre";
            this.tbSongGenre.Size = new System.Drawing.Size(143, 20);
            this.tbSongGenre.TabIndex = 7;
            // 
            // tbSongName
            // 
            this.tbSongName.Location = new System.Drawing.Point(144, 53);
            this.tbSongName.Name = "tbSongName";
            this.tbSongName.Size = new System.Drawing.Size(143, 20);
            this.tbSongName.TabIndex = 6;
            // 
            // lbProducerCredits
            // 
            this.lbProducerCredits.AutoSize = true;
            this.lbProducerCredits.Location = new System.Drawing.Point(56, 158);
            this.lbProducerCredits.Name = "lbProducerCredits";
            this.lbProducerCredits.Size = new System.Drawing.Size(85, 13);
            this.lbProducerCredits.TabIndex = 4;
            this.lbProducerCredits.Text = "ProducerCredits:";
            // 
            // lbWritersCredits
            // 
            this.lbWritersCredits.AutoSize = true;
            this.lbWritersCredits.Location = new System.Drawing.Point(63, 125);
            this.lbWritersCredits.Name = "lbWritersCredits";
            this.lbWritersCredits.Size = new System.Drawing.Size(75, 13);
            this.lbWritersCredits.TabIndex = 3;
            this.lbWritersCredits.Text = "WritersCredits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SongGenre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SongName:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwMusic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Music";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beatsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwMusic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.Label lbSongs;
        private System.Windows.Forms.Label lbWritersCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWritersCredits;
        private System.Windows.Forms.TextBox tbSongGenre;
        private System.Windows.Forms.TextBox tbSongName;
        private System.Windows.Forms.Label lbProducerCredits;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbProducerCredits;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSongToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

