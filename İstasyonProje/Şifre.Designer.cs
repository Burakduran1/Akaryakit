namespace İstasyonProje
{
    partial class Şifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Şifre));
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Button_kaydet = new System.Windows.Forms.Button();
            this.Lbl_sifre = new System.Windows.Forms.Label();
            this.Lbl_ad = new System.Windows.Forms.Label();
            this.Txt_ad = new System.Windows.Forms.TextBox();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Button_guncelle = new System.Windows.Forms.Button();
            this.Button_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgiDataSet3 = new İstasyonProje.PersonelBilgiDataSet3();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new İstasyonProje.PersonelBilgiDataSet3TableAdapters.adminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_id.Location = new System.Drawing.Point(39, 50);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(87, 18);
            this.Lbl_id.TabIndex = 0;
            this.Lbl_id.Text = "Yönetici İd:";
            // 
            // Txt_id
            // 
            this.Txt_id.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_id.Location = new System.Drawing.Point(132, 43);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.ReadOnly = true;
            this.Txt_id.Size = new System.Drawing.Size(100, 25);
            this.Txt_id.TabIndex = 1;
            // 
            // Button_kaydet
            // 
            this.Button_kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_kaydet.Location = new System.Drawing.Point(31, 172);
            this.Button_kaydet.Name = "Button_kaydet";
            this.Button_kaydet.Size = new System.Drawing.Size(89, 27);
            this.Button_kaydet.TabIndex = 4;
            this.Button_kaydet.Text = "Kaydet";
            this.Button_kaydet.UseVisualStyleBackColor = true;
            this.Button_kaydet.Click += new System.EventHandler(this.Button_kaydet_Click);
            // 
            // Lbl_sifre
            // 
            this.Lbl_sifre.AutoSize = true;
            this.Lbl_sifre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_sifre.Location = new System.Drawing.Point(83, 120);
            this.Lbl_sifre.Name = "Lbl_sifre";
            this.Lbl_sifre.Size = new System.Drawing.Size(43, 18);
            this.Lbl_sifre.TabIndex = 3;
            this.Lbl_sifre.Text = "Şifre:";
            // 
            // Lbl_ad
            // 
            this.Lbl_ad.AutoSize = true;
            this.Lbl_ad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_ad.Location = new System.Drawing.Point(28, 85);
            this.Lbl_ad.Name = "Lbl_ad";
            this.Lbl_ad.Size = new System.Drawing.Size(98, 18);
            this.Lbl_ad.TabIndex = 4;
            this.Lbl_ad.Text = "Kullanıcı Adı:";
            // 
            // Txt_ad
            // 
            this.Txt_ad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_ad.Location = new System.Drawing.Point(132, 78);
            this.Txt_ad.Name = "Txt_ad";
            this.Txt_ad.Size = new System.Drawing.Size(100, 25);
            this.Txt_ad.TabIndex = 2;
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_sifre.Location = new System.Drawing.Point(132, 113);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(100, 25);
            this.Txt_sifre.TabIndex = 3;
            // 
            // Button_guncelle
            // 
            this.Button_guncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_guncelle.Location = new System.Drawing.Point(240, 172);
            this.Button_guncelle.Name = "Button_guncelle";
            this.Button_guncelle.Size = new System.Drawing.Size(89, 27);
            this.Button_guncelle.TabIndex = 6;
            this.Button_guncelle.Text = "Güncelle";
            this.Button_guncelle.UseVisualStyleBackColor = true;
            this.Button_guncelle.Click += new System.EventHandler(this.Button_guncelle_Click);
            // 
            // Button_sil
            // 
            this.Button_sil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_sil.Location = new System.Drawing.Point(132, 172);
            this.Button_sil.Name = "Button_sil";
            this.Button_sil.Size = new System.Drawing.Size(89, 27);
            this.Button_sil.TabIndex = 5;
            this.Button_sil.Text = "Sil";
            this.Button_sil.UseVisualStyleBackColor = true;
            this.Button_sil.Click += new System.EventHandler(this.Button_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.adminBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(345, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 187);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Yönetici_İd";
            this.dataGridViewTextBoxColumn1.HeaderText = "Yönetici_İd";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Yönetici_Ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Yönetici_Ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yönetici_Şifre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yönetici_Şifre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "admin";
            this.adminBindingSource1.DataSource = this.personelBilgiDataSet3;
            // 
            // personelBilgiDataSet3
            // 
            this.personelBilgiDataSet3.DataSetName = "PersonelBilgiDataSet3";
            this.personelBilgiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // Şifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(149)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(719, 221);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_sil);
            this.Controls.Add(this.Button_guncelle);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.Txt_ad);
            this.Controls.Add(this.Lbl_ad);
            this.Controls.Add(this.Lbl_sifre);
            this.Controls.Add(this.Button_kaydet);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.Lbl_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Şifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre";
            this.Load += new System.EventHandler(this.Şifre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Button Button_kaydet;
        private System.Windows.Forms.Label Lbl_sifre;
        private System.Windows.Forms.Label Lbl_ad;
        private System.Windows.Forms.TextBox Txt_ad;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.Button Button_guncelle;
        private System.Windows.Forms.Button Button_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.BindingSource adminBindingSource;
      
       
        private PersonelBilgiDataSet3 personelBilgiDataSet3;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private PersonelBilgiDataSet3TableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}