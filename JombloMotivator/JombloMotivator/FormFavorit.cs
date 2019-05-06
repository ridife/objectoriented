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

namespace JombloMotivator
{
    public partial class FormFavorit : Form
    {
        public FormFavorit()
        {
            InitializeComponent();
        }

        private void FormFavorit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseJombloMotivatorDataSet.TableFavorit' table. You can move, or remove it, as needed.
            string connectionString = string.Format(Properties.Settings.Default.ConnectionString, Environment.CurrentDirectory);
            OleDbConnection connection = new OleDbConnection(connectionString);
            tableFavoritTableAdapter.Connection = connection;
            this.tableFavoritTableAdapter.Fill(this.databaseJombloMotivatorDataSet.TableFavorit);


        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kamu yakin hendak menghapus jejak ini?", "Hapus Jejakmu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dgvFavorit.Rows.RemoveAt(dgvFavorit.SelectedRows[0].Index);
                    tableFavoritTableAdapter.Update(this.databaseJombloMotivatorDataSet.TableFavorit);
                }
                catch (Exception)
                {
                    MessageBox.Show("Yakinlah kamu sudah memilih jejak yang hendak dihapus");
                    
                }
                
               
            }
        }
    }
}
