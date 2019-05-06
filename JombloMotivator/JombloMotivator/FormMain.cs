using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZodiacLibrary;
using ZodiacRestAPI;

namespace JombloMotivator
{
    public partial class FormMain : Form
    {
        // inisialisasi variabel 
        string hasil = string.Empty;
        ZodiacResult zodiacTest;

        public FormMain()
        {
            InitializeComponent();
            // ambil data dari enum 
            cbxTime.DataSource = Enum.GetValues(typeof(TimeSign));

            // baca setting 
            if (JombloMotivator.Properties.Settings.Default.SelectedDate != null)
            {
                dtpTanggalLahir.Value = JombloMotivator.Properties.Settings.Default.SelectedDate;
                GetZodiac();
            }

        }

        private void BtnDeteksiZodiac_Click(object sender, EventArgs e)
        {
            GetZodiac();

        }

        private void GetZodiac()
        {
            // memaksa culture agar id-ID
            CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("id-ID");

            // mengambil nilai dari UI
            string tanggalPilihan = dtpTanggalLahir.Value.ToShortDateString();

            // memanggil library Zodiac
            hasil = Zodiac.FindZodiac(tanggalPilihan);
            lblZodiac.Text = "Selamat Datang:" + hasil;
        }


        private void GetZodiacQuotes()
        {
            TimeSign selectedTimeSign = (TimeSign)cbxTime.SelectedValue;


            // memanggil services
            Enum.TryParse(hasil, out ZodiacSign myZodiac);
            ZodiacRest zodiac = new ZodiacRest();
            zodiacTest = new ZodiacResult();
            zodiacTest = zodiac.ObtainResult(myZodiac, selectedTimeSign);

            // tampilkan ke layar

            Meta meta = new Meta();
            meta = zodiacTest.Content;

            txtMood.Text = meta.Mood;
            txtKataKunci.Text = meta.Keywords;
            txtSemangat.Text = meta.intensity;
            rtbQuote.Text = zodiacTest.Quotes;
        }

        private void BtnQuotes_Click(object sender, EventArgs e)
        {
            this.GetZodiacQuotes();
        }

        private void SimpanSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JombloMotivator.Properties.Settings.Default.SelectedDate = dtpTanggalLahir.Value;
            JombloMotivator.Properties.Settings.Default.Save();
            MessageBox.Show(this, "Setting sudah tersimpan","Tersimpan",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void TentangAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Hamba adalah seorang jomblo yang sudah bahagia dengan kensendiriannya.", "Tentang Hamba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LihatFavoritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFavorit formFavorit = new FormFavorit();
            formFavorit.ShowDialog(this);


        }

        private void BtnAddToFavorites_Click(object sender, EventArgs e)
        {
            FormCurhat formCurhat = new FormCurhat(zodiacTest);
            formCurhat.ShowDialog(this);

        }
    }
}
