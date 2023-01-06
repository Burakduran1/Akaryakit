namespace İstasyonProje
{
    partial class Personel_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_list));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelOgrenimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelPozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgiDataSet4 = new İstasyonProje.PersonelBilgiDataSet4();
            this.personelTableAdapter = new İstasyonProje.PersonelBilgiDataSet4TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personelTcDataGridViewTextBoxColumn,
            this.personelTelefonDataGridViewTextBoxColumn,
            this.personelAdresDataGridViewTextBoxColumn,
            this.personelDogumTarihiDataGridViewTextBoxColumn,
            this.personelOgrenimDataGridViewTextBoxColumn,
            this.personelPozisyonDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personel_id";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "Personel_Ad";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "Personel_Ad";
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "Personel_Soyad";
            this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "Personel_Soyad";
            this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            // 
            // personelTcDataGridViewTextBoxColumn
            // 
            this.personelTcDataGridViewTextBoxColumn.DataPropertyName = "Personel_Tc";
            this.personelTcDataGridViewTextBoxColumn.HeaderText = "Personel_Tc";
            this.personelTcDataGridViewTextBoxColumn.Name = "personelTcDataGridViewTextBoxColumn";
            // 
            // personelTelefonDataGridViewTextBoxColumn
            // 
            this.personelTelefonDataGridViewTextBoxColumn.DataPropertyName = "Personel_Telefon";
            this.personelTelefonDataGridViewTextBoxColumn.HeaderText = "Personel_Telefon";
            this.personelTelefonDataGridViewTextBoxColumn.Name = "personelTelefonDataGridViewTextBoxColumn";
            // 
            // personelAdresDataGridViewTextBoxColumn
            // 
            this.personelAdresDataGridViewTextBoxColumn.DataPropertyName = "Personel_Adres";
            this.personelAdresDataGridViewTextBoxColumn.HeaderText = "Personel_Adres";
            this.personelAdresDataGridViewTextBoxColumn.Name = "personelAdresDataGridViewTextBoxColumn";
            // 
            // personelDogumTarihiDataGridViewTextBoxColumn
            // 
            this.personelDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Personel_DogumTarihi";
            this.personelDogumTarihiDataGridViewTextBoxColumn.HeaderText = "Personel_DogumTarihi";
            this.personelDogumTarihiDataGridViewTextBoxColumn.Name = "personelDogumTarihiDataGridViewTextBoxColumn";
            // 
            // personelOgrenimDataGridViewTextBoxColumn
            // 
            this.personelOgrenimDataGridViewTextBoxColumn.DataPropertyName = "Personel_Ogrenim";
            this.personelOgrenimDataGridViewTextBoxColumn.HeaderText = "Personel_Ogrenim";
            this.personelOgrenimDataGridViewTextBoxColumn.Name = "personelOgrenimDataGridViewTextBoxColumn";
            // 
            // personelPozisyonDataGridViewTextBoxColumn
            // 
            this.personelPozisyonDataGridViewTextBoxColumn.DataPropertyName = "Personel_Pozisyon";
            this.personelPozisyonDataGridViewTextBoxColumn.HeaderText = "Personel_Pozisyon";
            this.personelPozisyonDataGridViewTextBoxColumn.Name = "personelPozisyonDataGridViewTextBoxColumn";
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "Personel_Maas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "Personel_Maas";
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.personelBilgiDataSet4;
            // 
            // personelBilgiDataSet4
            // 
            this.personelBilgiDataSet4.DataSetName = "PersonelBilgiDataSet4";
            this.personelBilgiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // Personel_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1038, 392);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personel_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_list";
            this.Load += new System.EventHandler(this.Personel_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelBilgiDataSet4 personelBilgiDataSet4;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private PersonelBilgiDataSet4TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelOgrenimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelPozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
    }
}