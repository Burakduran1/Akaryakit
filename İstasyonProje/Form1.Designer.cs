namespace İstasyonProje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akaryakıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akaryakıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarayıcıyıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelBilgiDataSet6 = new İstasyonProje.PersonelBilgiDataSet6();
            this.satisTableAdapter = new İstasyonProje.PersonelBilgiDataSet6TableAdapters.SatisTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelBilgiDataSet7 = new İstasyonProje.PersonelBilgiDataSet7();
            this.satisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.satisTableAdapter1 = new İstasyonProje.PersonelBilgiDataSet7TableAdapters.SatisTableAdapter();
            this.aracPlakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akaryakitTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satanPersonelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akaryakıtToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.gelirToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akaryakıtToolStripMenuItem
            // 
            this.akaryakıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akaryakıtEkleToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.akaryakıtToolStripMenuItem.Name = "akaryakıtToolStripMenuItem";
            this.akaryakıtToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.akaryakıtToolStripMenuItem.Text = "Akaryakıt";
            // 
            // akaryakıtEkleToolStripMenuItem
            // 
            this.akaryakıtEkleToolStripMenuItem.Name = "akaryakıtEkleToolStripMenuItem";
            this.akaryakıtEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.akaryakıtEkleToolStripMenuItem.Text = "Fiyat Bilgisi";
            this.akaryakıtEkleToolStripMenuItem.Click += new System.EventHandler(this.akaryakıtEkleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Fiyat Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelSilmeToolStripMenuItem,
            this.personelDüzenlemeToolStripMenuItem,
            this.personelListesiToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelSilmeToolStripMenuItem
            // 
            this.personelSilmeToolStripMenuItem.Name = "personelSilmeToolStripMenuItem";
            this.personelSilmeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personelSilmeToolStripMenuItem.Text = "Personel Silme";
            this.personelSilmeToolStripMenuItem.Click += new System.EventHandler(this.personelSilmeToolStripMenuItem_Click);
            // 
            // personelDüzenlemeToolStripMenuItem
            // 
            this.personelDüzenlemeToolStripMenuItem.Name = "personelDüzenlemeToolStripMenuItem";
            this.personelDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personelDüzenlemeToolStripMenuItem.Text = "Personel Düzenleme";
            this.personelDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenlemeToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderGüncelleToolStripMenuItem,
            this.giderListesiToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            this.giderEkleToolStripMenuItem.Click += new System.EventHandler(this.giderEkleToolStripMenuItem_Click);
            // 
            // giderGüncelleToolStripMenuItem
            // 
            this.giderGüncelleToolStripMenuItem.Name = "giderGüncelleToolStripMenuItem";
            this.giderGüncelleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.giderGüncelleToolStripMenuItem.Text = "Gider Güncelle";
            this.giderGüncelleToolStripMenuItem.Click += new System.EventHandler(this.giderGüncelleToolStripMenuItem_Click);
            // 
            // giderListesiToolStripMenuItem
            // 
            this.giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            this.giderListesiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.giderListesiToolStripMenuItem.Text = "Gider Listesi";
            this.giderListesiToolStripMenuItem.Click += new System.EventHandler(this.giderListesiToolStripMenuItem_Click);
            // 
            // gelirToolStripMenuItem
            // 
            this.gelirToolStripMenuItem.Name = "gelirToolStripMenuItem";
            this.gelirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.gelirToolStripMenuItem.Text = "Gelir";
            this.gelirToolStripMenuItem.Click += new System.EventHandler(this.gelirToolStripMenuItem_Click);
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.tarayıcıyıAçToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem1,
            this.notEkleToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.hakkımızdaToolStripMenuItem.Text = "Ek Araçlar";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // tarayıcıyıAçToolStripMenuItem
            // 
            this.tarayıcıyıAçToolStripMenuItem.Name = "tarayıcıyıAçToolStripMenuItem";
            this.tarayıcıyıAçToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tarayıcıyıAçToolStripMenuItem.Text = "Tarayıcıyı Aç";
            this.tarayıcıyıAçToolStripMenuItem.Click += new System.EventHandler(this.tarayıcıyıAçToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem1
            // 
            this.hakkımızdaToolStripMenuItem1.Name = "hakkımızdaToolStripMenuItem1";
            this.hakkımızdaToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.hakkımızdaToolStripMenuItem1.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem1.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem1_Click);
            // 
            // notEkleToolStripMenuItem
            // 
            this.notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            this.notEkleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.notEkleToolStripMenuItem.Text = "Not Ekle";
            this.notEkleToolStripMenuItem.Click += new System.EventHandler(this.notEkleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(447, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(482, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "Satis";
            this.satisBindingSource.DataSource = this.personelBilgiDataSet6;
            // 
            // personelBilgiDataSet6
            // 
            this.personelBilgiDataSet6.DataSetName = "PersonelBilgiDataSet6";
            this.personelBilgiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aracPlakaDataGridViewTextBoxColumn,
            this.akaryakitTurDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.satanPersonelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 162);
            this.dataGridView1.TabIndex = 4;
            // 
            // personelBilgiDataSet7
            // 
            this.personelBilgiDataSet7.DataSetName = "PersonelBilgiDataSet7";
            this.personelBilgiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBindingSource1
            // 
            this.satisBindingSource1.DataMember = "Satis";
            this.satisBindingSource1.DataSource = this.personelBilgiDataSet7;
            // 
            // satisTableAdapter1
            // 
            this.satisTableAdapter1.ClearBeforeFill = true;
            // 
            // aracPlakaDataGridViewTextBoxColumn
            // 
            this.aracPlakaDataGridViewTextBoxColumn.DataPropertyName = "Arac_Plaka";
            this.aracPlakaDataGridViewTextBoxColumn.HeaderText = "Arac_Plaka";
            this.aracPlakaDataGridViewTextBoxColumn.Name = "aracPlakaDataGridViewTextBoxColumn";
            // 
            // akaryakitTurDataGridViewTextBoxColumn
            // 
            this.akaryakitTurDataGridViewTextBoxColumn.DataPropertyName = "Akaryakit_Tur";
            this.akaryakitTurDataGridViewTextBoxColumn.HeaderText = "Akaryakit_Tur";
            this.akaryakitTurDataGridViewTextBoxColumn.Name = "akaryakitTurDataGridViewTextBoxColumn";
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            // 
            // satanPersonelDataGridViewTextBoxColumn
            // 
            this.satanPersonelDataGridViewTextBoxColumn.DataPropertyName = "Satan_Personel";
            this.satanPersonelDataGridViewTextBoxColumn.HeaderText = "Satan_Personel";
            this.satanPersonelDataGridViewTextBoxColumn.Name = "satanPersonelDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-3, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plaka Ara;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akaryakıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akaryakıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private PersonelBilgiDataSet6 personelBilgiDataSet6;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private PersonelBilgiDataSet6TableAdapters.SatisTableAdapter satisTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem tarayıcıyıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelBilgiDataSet7 personelBilgiDataSet7;
        private System.Windows.Forms.BindingSource satisBindingSource1;
        private PersonelBilgiDataSet7TableAdapters.SatisTableAdapter satisTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracPlakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryakitTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satanPersonelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}