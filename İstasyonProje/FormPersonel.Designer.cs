namespace İstasyonProje
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.Lbl_ad = new System.Windows.Forms.Label();
            this.Lbl_soyad = new System.Windows.Forms.Label();
            this.Lbl_tc = new System.Windows.Forms.Label();
            this.Lbl_telefon = new System.Windows.Forms.Label();
            this.Lbl_adres = new System.Windows.Forms.Label();
            this.Lbl_dogum = new System.Windows.Forms.Label();
            this.Lbl_pozisyon = new System.Windows.Forms.Label();
            this.Lbl_maas = new System.Windows.Forms.Label();
            this.Txt_ad = new System.Windows.Forms.TextBox();
            this.Txt_soyad = new System.Windows.Forms.TextBox();
            this.Txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.Txt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.Txt_adres = new System.Windows.Forms.RichTextBox();
            this.Combo_pozisyon = new System.Windows.Forms.ComboBox();
            this.Txt_dogum = new System.Windows.Forms.MaskedTextBox();
            this.Txt_maas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_ogrenim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ad
            // 
            this.Lbl_ad.AutoSize = true;
            this.Lbl_ad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_ad.Location = new System.Drawing.Point(47, 33);
            this.Lbl_ad.Name = "Lbl_ad";
            this.Lbl_ad.Size = new System.Drawing.Size(91, 18);
            this.Lbl_ad.TabIndex = 0;
            this.Lbl_ad.Text = "Personel Ad:";
            this.Lbl_ad.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_soyad
            // 
            this.Lbl_soyad.AutoSize = true;
            this.Lbl_soyad.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_soyad.Location = new System.Drawing.Point(29, 72);
            this.Lbl_soyad.Name = "Lbl_soyad";
            this.Lbl_soyad.Size = new System.Drawing.Size(113, 18);
            this.Lbl_soyad.TabIndex = 1;
            this.Lbl_soyad.Text = "Personel Soyad:";
            // 
            // Lbl_tc
            // 
            this.Lbl_tc.AutoSize = true;
            this.Lbl_tc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_tc.Location = new System.Drawing.Point(29, 104);
            this.Lbl_tc.Name = "Lbl_tc";
            this.Lbl_tc.Size = new System.Drawing.Size(113, 18);
            this.Lbl_tc.TabIndex = 2;
            this.Lbl_tc.Text = "Personel Tc No:";
            // 
            // Lbl_telefon
            // 
            this.Lbl_telefon.AutoSize = true;
            this.Lbl_telefon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_telefon.Location = new System.Drawing.Point(76, 138);
            this.Lbl_telefon.Name = "Lbl_telefon";
            this.Lbl_telefon.Size = new System.Drawing.Size(62, 18);
            this.Lbl_telefon.TabIndex = 3;
            this.Lbl_telefon.Text = "Telefon:";
            // 
            // Lbl_adres
            // 
            this.Lbl_adres.AutoSize = true;
            this.Lbl_adres.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_adres.Location = new System.Drawing.Point(84, 177);
            this.Lbl_adres.Name = "Lbl_adres";
            this.Lbl_adres.Size = new System.Drawing.Size(54, 18);
            this.Lbl_adres.TabIndex = 4;
            this.Lbl_adres.Text = " Adres:";
            // 
            // Lbl_dogum
            // 
            this.Lbl_dogum.AutoSize = true;
            this.Lbl_dogum.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_dogum.Location = new System.Drawing.Point(31, 280);
            this.Lbl_dogum.Name = "Lbl_dogum";
            this.Lbl_dogum.Size = new System.Drawing.Size(107, 18);
            this.Lbl_dogum.TabIndex = 5;
            this.Lbl_dogum.Text = "Doğum Tarihi:";
            // 
            // Lbl_pozisyon
            // 
            this.Lbl_pozisyon.AutoSize = true;
            this.Lbl_pozisyon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_pozisyon.Location = new System.Drawing.Point(2, 357);
            this.Lbl_pozisyon.Name = "Lbl_pozisyon";
            this.Lbl_pozisyon.Size = new System.Drawing.Size(132, 18);
            this.Lbl_pozisyon.TabIndex = 6;
            this.Lbl_pozisyon.Text = "Personel Pozisyon:";
            // 
            // Lbl_maas
            // 
            this.Lbl_maas.AutoSize = true;
            this.Lbl_maas.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_maas.Location = new System.Drawing.Point(29, 400);
            this.Lbl_maas.Name = "Lbl_maas";
            this.Lbl_maas.Size = new System.Drawing.Size(109, 18);
            this.Lbl_maas.TabIndex = 7;
            this.Lbl_maas.Text = "Personel Maaş:";
            // 
            // Txt_ad
            // 
            this.Txt_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_ad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_ad.Location = new System.Drawing.Point(148, 33);
            this.Txt_ad.Name = "Txt_ad";
            this.Txt_ad.Size = new System.Drawing.Size(184, 26);
            this.Txt_ad.TabIndex = 1;
            // 
            // Txt_soyad
            // 
            this.Txt_soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_soyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_soyad.Location = new System.Drawing.Point(148, 72);
            this.Txt_soyad.Name = "Txt_soyad";
            this.Txt_soyad.Size = new System.Drawing.Size(184, 26);
            this.Txt_soyad.TabIndex = 2;
            // 
            // Txt_tc
            // 
            this.Txt_tc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_tc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_tc.Location = new System.Drawing.Point(148, 104);
            this.Txt_tc.Mask = "00000000000";
            this.Txt_tc.Name = "Txt_tc";
            this.Txt_tc.Size = new System.Drawing.Size(184, 26);
            this.Txt_tc.TabIndex = 3;
            this.Txt_tc.ValidatingType = typeof(int);
            // 
            // Txt_telefon
            // 
            this.Txt_telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_telefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_telefon.Location = new System.Drawing.Point(148, 138);
            this.Txt_telefon.Mask = "(999) 000-0000";
            this.Txt_telefon.Name = "Txt_telefon";
            this.Txt_telefon.Size = new System.Drawing.Size(184, 26);
            this.Txt_telefon.TabIndex = 4;
            // 
            // Txt_adres
            // 
            this.Txt_adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_adres.Location = new System.Drawing.Point(148, 178);
            this.Txt_adres.Name = "Txt_adres";
            this.Txt_adres.Size = new System.Drawing.Size(184, 96);
            this.Txt_adres.TabIndex = 5;
            this.Txt_adres.Text = "";
            // 
            // Combo_pozisyon
            // 
            this.Combo_pozisyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Combo_pozisyon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Combo_pozisyon.FormattingEnabled = true;
            this.Combo_pozisyon.Location = new System.Drawing.Point(148, 354);
            this.Combo_pozisyon.Name = "Combo_pozisyon";
            this.Combo_pozisyon.Size = new System.Drawing.Size(227, 26);
            this.Combo_pozisyon.TabIndex = 8;
            // 
            // Txt_dogum
            // 
            this.Txt_dogum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_dogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_dogum.Location = new System.Drawing.Point(148, 280);
            this.Txt_dogum.Mask = "00/00/0000";
            this.Txt_dogum.Name = "Txt_dogum";
            this.Txt_dogum.Size = new System.Drawing.Size(100, 26);
            this.Txt_dogum.TabIndex = 6;
            this.Txt_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_maas
            // 
            this.Txt_maas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Txt_maas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_maas.Location = new System.Drawing.Point(148, 392);
            this.Txt_maas.Name = "Txt_maas";
            this.Txt_maas.Size = new System.Drawing.Size(184, 26);
            this.Txt_maas.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(361, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Button_kaydet
            // 
            this.Button_kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button_kaydet.Location = new System.Drawing.Point(186, 447);
            this.Button_kaydet.Name = "Button_kaydet";
            this.Button_kaydet.Size = new System.Drawing.Size(119, 33);
            this.Button_kaydet.TabIndex = 10;
            this.Button_kaydet.Text = "Kaydet";
            this.Button_kaydet.UseVisualStyleBackColor = true;
            this.Button_kaydet.Click += new System.EventHandler(this.Button_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Öğrenim Durumu:";
            // 
            // Combo_ogrenim
            // 
            this.Combo_ogrenim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Combo_ogrenim.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Combo_ogrenim.FormattingEnabled = true;
            this.Combo_ogrenim.Location = new System.Drawing.Point(148, 317);
            this.Combo_ogrenim.Name = "Combo_ogrenim";
            this.Combo_ogrenim.Size = new System.Drawing.Size(227, 26);
            this.Combo_ogrenim.TabIndex = 7;
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(149)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(468, 496);
            this.Controls.Add(this.Combo_ogrenim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_kaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_maas);
            this.Controls.Add(this.Txt_dogum);
            this.Controls.Add(this.Combo_pozisyon);
            this.Controls.Add(this.Txt_adres);
            this.Controls.Add(this.Txt_telefon);
            this.Controls.Add(this.Txt_tc);
            this.Controls.Add(this.Txt_soyad);
            this.Controls.Add(this.Txt_ad);
            this.Controls.Add(this.Lbl_maas);
            this.Controls.Add(this.Lbl_pozisyon);
            this.Controls.Add(this.Lbl_dogum);
            this.Controls.Add(this.Lbl_adres);
            this.Controls.Add(this.Lbl_telefon);
            this.Controls.Add(this.Lbl_tc);
            this.Controls.Add(this.Lbl_soyad);
            this.Controls.Add(this.Lbl_ad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ad;
        private System.Windows.Forms.Label Lbl_soyad;
        private System.Windows.Forms.Label Lbl_tc;
        private System.Windows.Forms.Label Lbl_telefon;
        private System.Windows.Forms.Label Lbl_adres;
        private System.Windows.Forms.Label Lbl_dogum;
        private System.Windows.Forms.Label Lbl_pozisyon;
        private System.Windows.Forms.Label Lbl_maas;
        private System.Windows.Forms.TextBox Txt_ad;
        private System.Windows.Forms.TextBox Txt_soyad;
        private System.Windows.Forms.MaskedTextBox Txt_tc;
        private System.Windows.Forms.MaskedTextBox Txt_telefon;
        private System.Windows.Forms.RichTextBox Txt_adres;
        private System.Windows.Forms.ComboBox Combo_pozisyon;
        private System.Windows.Forms.MaskedTextBox Txt_dogum;
        private System.Windows.Forms.TextBox Txt_maas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_ogrenim;
    }
}

