namespace WinFormMusic
{
    partial class AddSongsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbProducerCredits = new System.Windows.Forms.TextBox();
            this.tbWritersCredits = new System.Windows.Forms.TextBox();
            this.tbSongGenre = new System.Windows.Forms.TextBox();
            this.tbSongName = new System.Windows.Forms.TextBox();
            this.lbProducerCredits = new System.Windows.Forms.Label();
            this.lbWritersCredits = new System.Windows.Forms.Label();
            this.lbSongGenre = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbProducerCredits
            // 
            this.tbProducerCredits.Location = new System.Drawing.Point(121, 176);
            this.tbProducerCredits.Name = "tbProducerCredits";
            this.tbProducerCredits.Size = new System.Drawing.Size(201, 20);
            this.tbProducerCredits.TabIndex = 25;
            // 
            // tbWritersCredits
            // 
            this.tbWritersCredits.Location = new System.Drawing.Point(121, 140);
            this.tbWritersCredits.Name = "tbWritersCredits";
            this.tbWritersCredits.Size = new System.Drawing.Size(201, 20);
            this.tbWritersCredits.TabIndex = 24;
            // 
            // tbSongGenre
            // 
            this.tbSongGenre.Location = new System.Drawing.Point(121, 107);
            this.tbSongGenre.Name = "tbSongGenre";
            this.tbSongGenre.Size = new System.Drawing.Size(201, 20);
            this.tbSongGenre.TabIndex = 23;
            // 
            // tbSongName
            // 
            this.tbSongName.Location = new System.Drawing.Point(121, 74);
            this.tbSongName.Name = "tbSongName";
            this.tbSongName.Size = new System.Drawing.Size(201, 20);
            this.tbSongName.TabIndex = 22;
            // 
            // lbProducerCredits
            // 
            this.lbProducerCredits.AutoSize = true;
            this.lbProducerCredits.Location = new System.Drawing.Point(29, 176);
            this.lbProducerCredits.Name = "lbProducerCredits";
            this.lbProducerCredits.Size = new System.Drawing.Size(85, 13);
            this.lbProducerCredits.TabIndex = 21;
            this.lbProducerCredits.Text = "ProducerCredits:";
            // 
            // lbWritersCredits
            // 
            this.lbWritersCredits.AutoSize = true;
            this.lbWritersCredits.Location = new System.Drawing.Point(39, 140);
            this.lbWritersCredits.Name = "lbWritersCredits";
            this.lbWritersCredits.Size = new System.Drawing.Size(75, 13);
            this.lbWritersCredits.TabIndex = 20;
            this.lbWritersCredits.Text = "WritersCredits:";
            // 
            // lbSongGenre
            // 
            this.lbSongGenre.AutoSize = true;
            this.lbSongGenre.Location = new System.Drawing.Point(50, 107);
            this.lbSongGenre.Name = "lbSongGenre";
            this.lbSongGenre.Size = new System.Drawing.Size(64, 13);
            this.lbSongGenre.TabIndex = 19;
            this.lbSongGenre.Text = "SongGenre:";
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Location = new System.Drawing.Point(51, 74);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(63, 13);
            this.lbSongName.TabIndex = 18;
            this.lbSongName.Text = "SongName:";
            // 
            // AddSongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 316);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbProducerCredits);
            this.Controls.Add(this.tbWritersCredits);
            this.Controls.Add(this.tbSongGenre);
            this.Controls.Add(this.tbSongName);
            this.Controls.Add(this.lbProducerCredits);
            this.Controls.Add(this.lbWritersCredits);
            this.Controls.Add(this.lbSongGenre);
            this.Controls.Add(this.lbSongName);
            this.Name = "AddSongsForm";
            this.Text = "AddSongsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbProducerCredits;
        private System.Windows.Forms.TextBox tbWritersCredits;
        private System.Windows.Forms.TextBox tbSongGenre;
        private System.Windows.Forms.TextBox tbSongName;
        private System.Windows.Forms.Label lbProducerCredits;
        private System.Windows.Forms.Label lbWritersCredits;
        private System.Windows.Forms.Label lbSongGenre;
        private System.Windows.Forms.Label lbSongName;
    }
}