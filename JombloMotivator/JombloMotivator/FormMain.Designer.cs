namespace JombloMotivator
{
    partial class FormMain
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
            this.menuStripUtama = new System.Windows.Forms.MenuStrip();
            this.tsSaveSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatFavoritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.btnDeteksiZodiac = new System.Windows.Forms.Button();
            this.lblZodiac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSemangat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKataKunci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbQuote = new System.Windows.Forms.RichTextBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuotes = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMood = new System.Windows.Forms.TextBox();
            this.btnAddCurhat = new System.Windows.Forms.Button();
            this.menuStripUtama.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripUtama
            // 
            this.menuStripUtama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveSetting,
            this.toolStripMenuItem1});
            this.menuStripUtama.Location = new System.Drawing.Point(0, 0);
            this.menuStripUtama.Name = "menuStripUtama";
            this.menuStripUtama.Size = new System.Drawing.Size(800, 24);
            this.menuStripUtama.TabIndex = 13;
            this.menuStripUtama.Text = "menuStrip1";
            // 
            // tsSaveSetting
            // 
            this.tsSaveSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpanSettingToolStripMenuItem,
            this.lihatFavoritToolStripMenuItem});
            this.tsSaveSetting.Name = "tsSaveSetting";
            this.tsSaveSetting.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsSaveSetting.Size = new System.Drawing.Size(37, 20);
            this.tsSaveSetting.Text = "File";
            // 
            // simpanSettingToolStripMenuItem
            // 
            this.simpanSettingToolStripMenuItem.Name = "simpanSettingToolStripMenuItem";
            this.simpanSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.simpanSettingToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.simpanSettingToolStripMenuItem.Text = "Simpan Setting";
            this.simpanSettingToolStripMenuItem.Click += new System.EventHandler(this.SimpanSettingToolStripMenuItem_Click);
            // 
            // lihatFavoritToolStripMenuItem
            // 
            this.lihatFavoritToolStripMenuItem.Name = "lihatFavoritToolStripMenuItem";
            this.lihatFavoritToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.lihatFavoritToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.lihatFavoritToolStripMenuItem.Text = "Lihat Curhat";
            this.lihatFavoritToolStripMenuItem.Click += new System.EventHandler(this.LihatFavoritToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangAplikasiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Tentang";
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi";
            this.tentangAplikasiToolStripMenuItem.Click += new System.EventHandler(this.TentangAplikasiToolStripMenuItem_Click);
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(3, 3);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(461, 20);
            this.dtpTanggalLahir.TabIndex = 0;
            // 
            // btnDeteksiZodiac
            // 
            this.btnDeteksiZodiac.Location = new System.Drawing.Point(470, 3);
            this.btnDeteksiZodiac.Name = "btnDeteksiZodiac";
            this.btnDeteksiZodiac.Size = new System.Drawing.Size(211, 23);
            this.btnDeteksiZodiac.TabIndex = 1;
            this.btnDeteksiZodiac.Text = "Cek &Zodiac Mu Blo";
            this.btnDeteksiZodiac.UseVisualStyleBackColor = true;
            this.btnDeteksiZodiac.Click += new System.EventHandler(this.BtnDeteksiZodiac_Click);
            // 
            // lblZodiac
            // 
            this.lblZodiac.AutoSize = true;
            this.lblZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZodiac.Location = new System.Drawing.Point(3, 0);
            this.lblZodiac.Name = "lblZodiac";
            this.lblZodiac.Size = new System.Drawing.Size(146, 24);
            this.lblZodiac.TabIndex = 2;
            this.lblZodiac.Text = "Selamat Datang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mood";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Semangat Hidup";
            // 
            // txtSemangat
            // 
            this.txtSemangat.Location = new System.Drawing.Point(2, 113);
            this.txtSemangat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSemangat.Name = "txtSemangat";
            this.txtSemangat.Size = new System.Drawing.Size(787, 20);
            this.txtSemangat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kata Kunci";
            // 
            // txtKataKunci
            // 
            this.txtKataKunci.Location = new System.Drawing.Point(2, 39);
            this.txtKataKunci.Margin = new System.Windows.Forms.Padding(2);
            this.txtKataKunci.Name = "txtKataKunci";
            this.txtKataKunci.Size = new System.Drawing.Size(787, 20);
            this.txtKataKunci.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quote hari ini";
            // 
            // rtbQuote
            // 
            this.rtbQuote.Location = new System.Drawing.Point(2, 150);
            this.rtbQuote.Margin = new System.Windows.Forms.Padding(2);
            this.rtbQuote.Name = "rtbQuote";
            this.rtbQuote.Size = new System.Drawing.Size(787, 164);
            this.rtbQuote.TabIndex = 10;
            this.rtbQuote.Text = "";
            // 
            // cbxTime
            // 
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Location = new System.Drawing.Point(3, 32);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(461, 21);
            this.cbxTime.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtpTanggalLahir);
            this.flowLayoutPanel1.Controls.Add(this.btnDeteksiZodiac);
            this.flowLayoutPanel1.Controls.Add(this.cbxTime);
            this.flowLayoutPanel1.Controls.Add(this.btnQuotes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 65);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnQuotes
            // 
            this.btnQuotes.Location = new System.Drawing.Point(470, 32);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(211, 23);
            this.btnQuotes.TabIndex = 12;
            this.btnQuotes.Text = "&Motivation Quotes";
            this.btnQuotes.UseVisualStyleBackColor = true;
            this.btnQuotes.Click += new System.EventHandler(this.BtnQuotes_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblZodiac);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtKataKunci);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMood);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtSemangat);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.rtbQuote);
            this.flowLayoutPanel2.Controls.Add(this.btnAddCurhat);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 355);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // txtMood
            // 
            this.txtMood.Location = new System.Drawing.Point(2, 76);
            this.txtMood.Margin = new System.Windows.Forms.Padding(2);
            this.txtMood.Name = "txtMood";
            this.txtMood.Size = new System.Drawing.Size(787, 20);
            this.txtMood.TabIndex = 9;
            // 
            // btnAddCurhat
            // 
            this.btnAddCurhat.Location = new System.Drawing.Point(3, 319);
            this.btnAddCurhat.Name = "btnAddCurhat";
            this.btnAddCurhat.Size = new System.Drawing.Size(182, 23);
            this.btnAddCurhat.TabIndex = 11;
            this.btnAddCurhat.Text = "Tambah &Curhat";
            this.btnAddCurhat.UseVisualStyleBackColor = true;
            this.btnAddCurhat.Click += new System.EventHandler(this.BtnAddToFavorites_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStripUtama);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripUtama;
            this.Name = "FormMain";
            this.Text = "Jomblo Motivator";
            this.menuStripUtama.ResumeLayout(false);
            this.menuStripUtama.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Button btnDeteksiZodiac;
        private System.Windows.Forms.Label lblZodiac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSemangat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKataKunci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbQuote;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnQuotes;
        private System.Windows.Forms.MenuStrip menuStripUtama;
        private System.Windows.Forms.ToolStripMenuItem tsSaveSetting;
        private System.Windows.Forms.ToolStripMenuItem simpanSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatFavoritToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tentangAplikasiToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtMood;
        private System.Windows.Forms.Button btnAddCurhat;
    }
}

