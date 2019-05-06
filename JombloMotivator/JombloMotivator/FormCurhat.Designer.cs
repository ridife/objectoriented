namespace JombloMotivator
{
    partial class FormCurhat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbCurhat = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpanPerasaanIni = new System.Windows.Forms.Button();
            this.btnBagikanPerasaanIni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.rtbCurhat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masukkan Bersama Apa yang Kau Rasakan Blo...";
            // 
            // rtbCurhat
            // 
            this.rtbCurhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbCurhat.Location = new System.Drawing.Point(3, 16);
            this.rtbCurhat.Name = "rtbCurhat";
            this.rtbCurhat.Size = new System.Drawing.Size(567, 82);
            this.rtbCurhat.TabIndex = 0;
            this.rtbCurhat.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSimpanPerasaanIni);
            this.flowLayoutPanel1.Controls.Add(this.btnBagikanPerasaanIni);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSimpanPerasaanIni
            // 
            this.btnSimpanPerasaanIni.Location = new System.Drawing.Point(3, 3);
            this.btnSimpanPerasaanIni.Name = "btnSimpanPerasaanIni";
            this.btnSimpanPerasaanIni.Size = new System.Drawing.Size(156, 23);
            this.btnSimpanPerasaanIni.TabIndex = 0;
            this.btnSimpanPerasaanIni.Text = "Simpan Perasaan Ini";
            this.btnSimpanPerasaanIni.UseVisualStyleBackColor = true;
            this.btnSimpanPerasaanIni.Click += new System.EventHandler(this.BtnSimpanPerasaanIni_Click);
            // 
            // btnBagikanPerasaanIni
            // 
            this.btnBagikanPerasaanIni.Location = new System.Drawing.Point(165, 3);
            this.btnBagikanPerasaanIni.Name = "btnBagikanPerasaanIni";
            this.btnBagikanPerasaanIni.Size = new System.Drawing.Size(155, 23);
            this.btnBagikanPerasaanIni.TabIndex = 1;
            this.btnBagikanPerasaanIni.Text = "Bagikan Perasaan Ini";
            this.btnBagikanPerasaanIni.UseVisualStyleBackColor = true;
            this.btnBagikanPerasaanIni.Click += new System.EventHandler(this.BtnBagikanPerasaanIni_Click);
            // 
            // FormCurhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 136);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCurhat";
            this.Text = "Simpan Ke Favorit ";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSimpanPerasaanIni;
        private System.Windows.Forms.Button btnBagikanPerasaanIni;
        private System.Windows.Forms.RichTextBox rtbCurhat;
    }
}