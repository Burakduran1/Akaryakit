namespace İstasyonProje
{
    partial class Satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
            this.Lbl_plaka = new System.Windows.Forms.Label();
            this.Txt_plaka = new System.Windows.Forms.TextBox();
            this.Lbl_akaryakit = new System.Windows.Forms.Label();
            this.Lbl_odeme = new System.Windows.Forms.Label();
            this.Lbl_tutar = new System.Windows.Forms.Label();
            this.Lbl_litre = new System.Windows.Forms.Label();
            this.Lbl_Personel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_tutar = new System.Windows.Forms.TextBox();
            this.Txt_litre = new System.Windows.Forms.TextBox();
            this.Txt_İd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.satisBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgiDataSet2 = new İstasyonProje.PersonelBilgiDataSet2();
            this.satisBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.satisTableAdapter = new İstasyonProje.PersonelBilgiDataSet2TableAdapters.SatisTableAdapter();
            this.Txt_tip = new System.Windows.Forms.ComboBox();
            this.Txt_personel = new System.Windows.Forms.ComboBox();
            this.Txt_tur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_plaka
            // 
            this.Lbl_plaka.AutoSize = true;
            this.Lbl_plaka.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_plaka.Location = new System.Drawing.Point(40, 220);
            this.Lbl_plaka.Name = "Lbl_plaka";
            this.Lbl_plaka.Size = new System.Drawing.Size(85, 18);
            this.Lbl_plaka.TabIndex = 0;
            this.Lbl_plaka.Text = "Araç Plaka:";
            // 
            // Txt_plaka
            // 
            this.Txt_plaka.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_plaka.Location = new System.Drawing.Point(140, 212);
            this.Txt_plaka.Name = "Txt_plaka";
            this.Txt_plaka.Size = new System.Drawing.Size(100, 26);
            this.Txt_plaka.TabIndex = 2;
            // 
            // Lbl_akaryakit
            // 
            this.Lbl_akaryakit.AutoSize = true;
            this.Lbl_akaryakit.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_akaryakit.Location = new System.Drawing.Point(14, 259);
            this.Lbl_akaryakit.Name = "Lbl_akaryakit";
            this.Lbl_akaryakit.Size = new System.Drawing.Size(111, 18);
            this.Lbl_akaryakit.TabIndex = 3;
            this.Lbl_akaryakit.Text = " Akaryakıt Tipi:";
            // 
            // Lbl_odeme
            // 
            this.Lbl_odeme.AutoSize = true;
            this.Lbl_odeme.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_odeme.Location = new System.Drawing.Point(377, 280);
            this.Lbl_odeme.Name = "Lbl_odeme";
            this.Lbl_odeme.Size = new System.Drawing.Size(98, 18);
            this.Lbl_odeme.TabIndex = 4;
            this.Lbl_odeme.Text = "Ödeme Türü:";
            // 
            // Lbl_tutar
            // 
            this.Lbl_tutar.AutoSize = true;
            this.Lbl_tutar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_tutar.Location = new System.Drawing.Point(425, 212);
            this.Lbl_tutar.Name = "Lbl_tutar";
            this.Lbl_tutar.Size = new System.Drawing.Size(50, 18);
            this.Lbl_tutar.TabIndex = 5;
            this.Lbl_tutar.Text = "Tutar:";
            // 
            // Lbl_litre
            // 
            this.Lbl_litre.AutoSize = true;
            this.Lbl_litre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_litre.Location = new System.Drawing.Point(431, 245);
            this.Lbl_litre.Name = "Lbl_litre";
            this.Lbl_litre.Size = new System.Drawing.Size(44, 18);
            this.Lbl_litre.TabIndex = 6;
            this.Lbl_litre.Text = "Litre:";
            // 
            // Lbl_Personel
            // 
            this.Lbl_Personel.AutoSize = true;
            this.Lbl_Personel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Personel.Location = new System.Drawing.Point(56, 291);
            this.Lbl_Personel.Name = "Lbl_Personel";
            this.Lbl_Personel.Size = new System.Drawing.Size(69, 18);
            this.Lbl_Personel.TabIndex = 14;
            this.Lbl_Personel.Text = "Personel:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(284, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Satışı Sonlandır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "Satis";
            // 
            // satisBindingSource1
            // 
            this.satisBindingSource1.DataMember = "Satis";
            // 
            // Txt_tutar
            // 
            this.Txt_tutar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_tutar.Location = new System.Drawing.Point(481, 204);
            this.Txt_tutar.Name = "Txt_tutar";
            this.Txt_tutar.Size = new System.Drawing.Size(100, 26);
            this.Txt_tutar.TabIndex = 5;
            // 
            // Txt_litre
            // 
            this.Txt_litre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_litre.Location = new System.Drawing.Point(481, 237);
            this.Txt_litre.Name = "Txt_litre";
            this.Txt_litre.Size = new System.Drawing.Size(100, 26);
            this.Txt_litre.TabIndex = 6;
            // 
            // Txt_İd
            // 
            this.Txt_İd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_İd.Location = new System.Drawing.Point(140, 172);
            this.Txt_İd.Name = "Txt_İd";
            this.Txt_İd.ReadOnly = true;
            this.Txt_İd.Size = new System.Drawing.Size(100, 26);
            this.Txt_İd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Araç İd:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.satisBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 152);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_2);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Arac_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Arac_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Arac_Plaka";
            this.dataGridViewTextBoxColumn2.HeaderText = "Arac_Plaka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Akaryakit_Tur";
            this.dataGridViewTextBoxColumn3.HeaderText = "Akaryakit_Tur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tutar";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tutar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Litre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Litre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Odeme_Turu";
            this.dataGridViewTextBoxColumn6.HeaderText = "Odeme_Turu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Satan_Personel";
            this.dataGridViewTextBoxColumn7.HeaderText = "Satan_Personel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // satisBindingSource2
            // 
            this.satisBindingSource2.DataMember = "Satis";
            this.satisBindingSource2.DataSource = this.personelBilgiDataSet2;
            // 
            // personelBilgiDataSet2
            // 
            this.personelBilgiDataSet2.DataSetName = "PersonelBilgiDataSet2";
            this.personelBilgiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBindingSource4
            // 
            this.satisBindingSource4.DataMember = "Satis";
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_tip
            // 
            this.Txt_tip.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_tip.FormattingEnabled = true;
            this.Txt_tip.Location = new System.Drawing.Point(140, 251);
            this.Txt_tip.Name = "Txt_tip";
            this.Txt_tip.Size = new System.Drawing.Size(100, 26);
            this.Txt_tip.TabIndex = 28;
            this.Txt_tip.SelectedIndexChanged += new System.EventHandler(this.Txt_tip_SelectedIndexChanged);
            // 
            // Txt_personel
            // 
            this.Txt_personel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_personel.FormattingEnabled = true;
            this.Txt_personel.Location = new System.Drawing.Point(140, 283);
            this.Txt_personel.Name = "Txt_personel";
            this.Txt_personel.Size = new System.Drawing.Size(100, 26);
            this.Txt_personel.TabIndex = 29;
            // 
            // Txt_tur
            // 
            this.Txt_tur.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_tur.FormattingEnabled = true;
            this.Txt_tur.Location = new System.Drawing.Point(481, 277);
            this.Txt_tur.Name = "Txt_tur";
            this.Txt_tur.Size = new System.Drawing.Size(100, 26);
            this.Txt_tur.TabIndex = 30;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(149)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(751, 373);
            this.Controls.Add(this.Txt_tur);
            this.Controls.Add(this.Txt_personel);
            this.Controls.Add(this.Txt_tip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_İd);
            this.Controls.Add(this.Txt_litre);
            this.Controls.Add(this.Txt_tutar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Personel);
            this.Controls.Add(this.Lbl_litre);
            this.Controls.Add(this.Lbl_tutar);
            this.Controls.Add(this.Lbl_odeme);
            this.Controls.Add(this.Lbl_akaryakit);
            this.Controls.Add(this.Txt_plaka);
            this.Controls.Add(this.Lbl_plaka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.Satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_plaka;
        private System.Windows.Forms.TextBox Txt_plaka;
        private System.Windows.Forms.Label Lbl_akaryakit;
        private System.Windows.Forms.Label Lbl_odeme;
        private System.Windows.Forms.Label Lbl_tutar;
        private System.Windows.Forms.Label Lbl_litre;
        private System.Windows.Forms.Label Lbl_Personel;
        private System.Windows.Forms.Button button1;
       
        private System.Windows.Forms.BindingSource satisBindingSource;
       
        
        private System.Windows.Forms.BindingSource satisBindingSource1;
      
        private System.Windows.Forms.TextBox Txt_tutar;
        private System.Windows.Forms.TextBox Txt_litre;
        private System.Windows.Forms.TextBox Txt_İd;
        private System.Windows.Forms.Label label1;
        
        
       
        
        private System.Windows.Forms.BindingSource satisBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource satisBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryakitTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satanPersonelDataGridViewTextBoxColumn;
        private PersonelBilgiDataSet2 personelBilgiDataSet2;
        private System.Windows.Forms.BindingSource satisBindingSource2;
        private PersonelBilgiDataSet2TableAdapters.SatisTableAdapter satisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox Txt_tip;
        private System.Windows.Forms.ComboBox Txt_personel;
        private System.Windows.Forms.ComboBox Txt_tur;
    }
}