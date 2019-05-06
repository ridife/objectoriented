namespace JombloMotivator
{
    partial class FormFavorit
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
            this.components = new System.ComponentModel.Container();
            this.dgvFavorit = new System.Windows.Forms.DataGridView();
            this.databaseJombloMotivatorDataSet = new JombloMotivator.DatabaseJombloMotivatorDataSet();
            this.tableFavoritBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableFavoritTableAdapter = new JombloMotivator.DatabaseJombloMotivatorDataSetTableAdapters.TableFavoritTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catatanPribadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kataKunciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semangatHidupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseJombloMotivatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFavoritBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFavorit
            // 
            this.dgvFavorit.AutoGenerateColumns = false;
            this.dgvFavorit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavorit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.catatanPribadiDataGridViewTextBoxColumn,
            this.kataKunciDataGridViewTextBoxColumn,
            this.semangatHidupDataGridViewTextBoxColumn,
            this.moodDataGridViewTextBoxColumn});
            this.dgvFavorit.DataSource = this.tableFavoritBindingSource;
            this.dgvFavorit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFavorit.Location = new System.Drawing.Point(0, 0);
            this.dgvFavorit.Name = "dgvFavorit";
            this.dgvFavorit.Size = new System.Drawing.Size(641, 280);
            this.dgvFavorit.TabIndex = 0;
            // 
            // databaseJombloMotivatorDataSet
            // 
            this.databaseJombloMotivatorDataSet.DataSetName = "DatabaseJombloMotivatorDataSet";
            this.databaseJombloMotivatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableFavoritBindingSource
            // 
            this.tableFavoritBindingSource.DataMember = "TableFavorit";
            this.tableFavoritBindingSource.DataSource = this.databaseJombloMotivatorDataSet;
            // 
            // tableFavoritTableAdapter
            // 
            this.tableFavoritTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // catatanPribadiDataGridViewTextBoxColumn
            // 
            this.catatanPribadiDataGridViewTextBoxColumn.DataPropertyName = "CatatanPribadi";
            this.catatanPribadiDataGridViewTextBoxColumn.HeaderText = "CatatanPribadi";
            this.catatanPribadiDataGridViewTextBoxColumn.Name = "catatanPribadiDataGridViewTextBoxColumn";
            // 
            // kataKunciDataGridViewTextBoxColumn
            // 
            this.kataKunciDataGridViewTextBoxColumn.DataPropertyName = "KataKunci";
            this.kataKunciDataGridViewTextBoxColumn.HeaderText = "KataKunci";
            this.kataKunciDataGridViewTextBoxColumn.Name = "kataKunciDataGridViewTextBoxColumn";
            // 
            // semangatHidupDataGridViewTextBoxColumn
            // 
            this.semangatHidupDataGridViewTextBoxColumn.DataPropertyName = "SemangatHidup";
            this.semangatHidupDataGridViewTextBoxColumn.HeaderText = "SemangatHidup";
            this.semangatHidupDataGridViewTextBoxColumn.Name = "semangatHidupDataGridViewTextBoxColumn";
            // 
            // moodDataGridViewTextBoxColumn
            // 
            this.moodDataGridViewTextBoxColumn.DataPropertyName = "Mood";
            this.moodDataGridViewTextBoxColumn.HeaderText = "Mood";
            this.moodDataGridViewTextBoxColumn.Name = "moodDataGridViewTextBoxColumn";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(13, 287);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(118, 33);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Menghapus Jejakmu";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // FormFavorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 332);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgvFavorit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFavorit";
            this.Text = "Form Favorit";
            this.Load += new System.EventHandler(this.FormFavorit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseJombloMotivatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFavoritBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFavorit;
        private DatabaseJombloMotivatorDataSet databaseJombloMotivatorDataSet;
        private System.Windows.Forms.BindingSource tableFavoritBindingSource;
        private DatabaseJombloMotivatorDataSetTableAdapters.TableFavoritTableAdapter tableFavoritTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catatanPribadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kataKunciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semangatHidupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHapus;
    }
}