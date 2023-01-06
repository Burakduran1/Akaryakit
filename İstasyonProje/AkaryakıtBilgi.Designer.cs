namespace İstasyonProje
{
    partial class AkaryakıtBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkaryakıtBilgi));
            this.Pcb_ekle = new System.Windows.Forms.PictureBox();
            this.Pcb_sil = new System.Windows.Forms.PictureBox();
            this.Pcb_duzenle = new System.Windows.Forms.PictureBox();
            this.Lbl_akİd = new System.Windows.Forms.Label();
            this.Lbl_akAd = new System.Windows.Forms.Label();
            this.Lbl_akFiyat = new System.Windows.Forms.Label();
            this.Txt_akAd = new System.Windows.Forms.TextBox();
            this.Txt_akFiyat = new System.Windows.Forms.TextBox();
            this.akaryakitBilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgiDataSet = new İstasyonProje.PersonelBilgiDataSet();
            this.akaryakitBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_akİd = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.akaryakit_BilgileriTableAdapter = new İstasyonProje.PersonelBilgiDataSetTableAdapters.Akaryakit_BilgileriTableAdapter();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_ekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_sil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_duzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akaryakitBilgileriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akaryakitBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pcb_ekle
            // 
            this.Pcb_ekle.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_ekle.Image")));
            this.Pcb_ekle.Location = new System.Drawing.Point(362, 16);
            this.Pcb_ekle.Name = "Pcb_ekle";
            this.Pcb_ekle.Size = new System.Drawing.Size(63, 61);
            this.Pcb_ekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_ekle.TabIndex = 0;
            this.Pcb_ekle.TabStop = false;
            this.toolTip1.SetToolTip(this.Pcb_ekle, "Ekle");
            this.Pcb_ekle.Click += new System.EventHandler(this.Pcb_ekle_Click);
            // 
            // Pcb_sil
            // 
            this.Pcb_sil.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_sil.Image")));
            this.Pcb_sil.Location = new System.Drawing.Point(445, 16);
            this.Pcb_sil.Name = "Pcb_sil";
            this.Pcb_sil.Size = new System.Drawing.Size(63, 61);
            this.Pcb_sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_sil.TabIndex = 1;
            this.Pcb_sil.TabStop = false;
            this.toolTip1.SetToolTip(this.Pcb_sil, "Sil");
            this.Pcb_sil.Click += new System.EventHandler(this.Pcb_sil_Click);
            // 
            // Pcb_duzenle
            // 
            this.Pcb_duzenle.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_duzenle.Image")));
            this.Pcb_duzenle.Location = new System.Drawing.Point(401, 83);
            this.Pcb_duzenle.Name = "Pcb_duzenle";
            this.Pcb_duzenle.Size = new System.Drawing.Size(63, 61);
            this.Pcb_duzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_duzenle.TabIndex = 2;
            this.Pcb_duzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.Pcb_duzenle, "Düzenle");
            this.Pcb_duzenle.Click += new System.EventHandler(this.Pcb_duzenle_Click);
            // 
            // Lbl_akİd
            // 
            this.Lbl_akİd.AutoSize = true;
            this.Lbl_akİd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_akİd.Location = new System.Drawing.Point(46, 59);
            this.Lbl_akİd.Name = "Lbl_akİd";
            this.Lbl_akİd.Size = new System.Drawing.Size(97, 18);
            this.Lbl_akİd.TabIndex = 3;
            this.Lbl_akİd.Text = "Akaryakıt İd:";
            // 
            // Lbl_akAd
            // 
            this.Lbl_akAd.AutoSize = true;
            this.Lbl_akAd.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_akAd.Location = new System.Drawing.Point(46, 91);
            this.Lbl_akAd.Name = "Lbl_akAd";
            this.Lbl_akAd.Size = new System.Drawing.Size(100, 18);
            this.Lbl_akAd.TabIndex = 4;
            this.Lbl_akAd.Text = "Akaryakıt Ad:";
            // 
            // Lbl_akFiyat
            // 
            this.Lbl_akFiyat.AutoSize = true;
            this.Lbl_akFiyat.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_akFiyat.Location = new System.Drawing.Point(27, 122);
            this.Lbl_akFiyat.Name = "Lbl_akFiyat";
            this.Lbl_akFiyat.Size = new System.Drawing.Size(116, 18);
            this.Lbl_akFiyat.TabIndex = 5;
            this.Lbl_akFiyat.Text = "Akaryakıt Fiyat:";
            // 
            // Txt_akAd
            // 
            this.Txt_akAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_akAd.Location = new System.Drawing.Point(163, 91);
            this.Txt_akAd.Name = "Txt_akAd";
            this.Txt_akAd.Size = new System.Drawing.Size(171, 26);
            this.Txt_akAd.TabIndex = 2;
            // 
            // Txt_akFiyat
            // 
            this.Txt_akFiyat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_akFiyat.Location = new System.Drawing.Point(163, 120);
            this.Txt_akFiyat.Name = "Txt_akFiyat";
            this.Txt_akFiyat.Size = new System.Drawing.Size(171, 26);
            this.Txt_akFiyat.TabIndex = 3;
            // 
            // akaryakitBilgileriBindingSource1
            // 
            this.akaryakitBilgileriBindingSource1.DataMember = "Akaryakit_Bilgileri";
            this.akaryakitBilgileriBindingSource1.DataSource = this.personelBilgiDataSet;
            // 
            // personelBilgiDataSet
            // 
            this.personelBilgiDataSet.DataSetName = "PersonelBilgiDataSet";
            this.personelBilgiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akaryakitBilgileriBindingSource
            // 
            this.akaryakitBilgileriBindingSource.DataMember = "Akaryakit_Bilgileri";
            // 
            // Txt_akİd
            // 
            this.Txt_akİd.Enabled = false;
            this.Txt_akİd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_akİd.Location = new System.Drawing.Point(163, 59);
            this.Txt_akİd.Name = "Txt_akİd";
            this.Txt_akİd.Size = new System.Drawing.Size(171, 26);
            this.Txt_akİd.TabIndex = 1;
            // 
            // akaryakit_BilgileriTableAdapter
            // 
            this.akaryakit_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Akaryakit_fiyat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Akaryakit_fiyat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Akaryakit_Tipi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Akaryakit_Tipi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Akaryakit_İd";
            this.dataGridViewTextBoxColumn1.HeaderText = "Akaryakit_İd";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.akaryakitBilgileriBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 205);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AkaryakıtBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(149)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(534, 379);
            this.Controls.Add(this.Txt_akİd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_akFiyat);
            this.Controls.Add(this.Txt_akAd);
            this.Controls.Add(this.Lbl_akFiyat);
            this.Controls.Add(this.Lbl_akAd);
            this.Controls.Add(this.Lbl_akİd);
            this.Controls.Add(this.Pcb_duzenle);
            this.Controls.Add(this.Pcb_sil);
            this.Controls.Add(this.Pcb_ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AkaryakıtBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akaryakıt ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_ekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_sil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_duzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akaryakitBilgileriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akaryakitBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pcb_ekle;
        private System.Windows.Forms.PictureBox Pcb_sil;
        private System.Windows.Forms.PictureBox Pcb_duzenle;
        private System.Windows.Forms.Label Lbl_akİd;
        private System.Windows.Forms.Label Lbl_akAd;
        private System.Windows.Forms.Label Lbl_akFiyat;
        private System.Windows.Forms.TextBox Txt_akAd;
        private System.Windows.Forms.TextBox Txt_akFiyat;
   
        private System.Windows.Forms.BindingSource akaryakitBilgileriBindingSource;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryakitİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryakitTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryakitfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Txt_akİd;
        private System.Windows.Forms.ToolTip toolTip1;
        private PersonelBilgiDataSet personelBilgiDataSet;
        private System.Windows.Forms.BindingSource akaryakitBilgileriBindingSource1;
        private PersonelBilgiDataSetTableAdapters.Akaryakit_BilgileriTableAdapter akaryakit_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}