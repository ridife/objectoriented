using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZodiacRestAPI;

namespace JombloMotivator
{
    public partial class FormCurhat : Form
    {
        ZodiacResult result;
        public FormCurhat()
        {
            InitializeComponent();
        }

        public FormCurhat(ZodiacResult zodiacResult)
        {
            InitializeComponent();
            this.result = zodiacResult;

        }

        private void BtnBagikanPerasaanIni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maaf Hanya Tersedia di Versi PRO", "Ahsiapp");

        }

        private void BtnSimpanPerasaanIni_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format(Properties.Settings.Default.ConnectionString,Environment.CurrentDirectory);
            
            string catatanPribadi = rtbCurhat.Text;
            string kataKunci = result.Content.Keywords;
            string semangatHidup = result.Content.intensity;
            string mood = result.Content.Mood;

            string insertSQL = string.Format(Properties.Settings.Default.InsertSQL,catatanPribadi,kataKunci,semangatHidup,mood);

            MessageBox.Show(insertSQL);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // The insertSQL string contains a SQL statement that
                // inserts a new row in the source table.
                OleDbCommand command = new OleDbCommand(insertSQL);



                // Set the Connection to the new OleDbConnection.
                command.Connection = connection;

                // Open the connection and execute the insert command.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    this.Close();
                   
                }
                
                
            }

        }
    }
}
