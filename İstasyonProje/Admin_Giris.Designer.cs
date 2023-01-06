namespace İstasyonProje
{
    partial class Admin_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Giris));
            this.Lbl_kullanici = new System.Windows.Forms.Label();
            this.Txt_kullanici = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Lbl_sifre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_kullanici
            // 
            this.Lbl_kullanici.AutoSize = true;
            this.Lbl_kullanici.BackColor = System.Drawing.Color.White;
            this.Lbl_kullanici.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_kullanici.Location = new System.Drawing.Point(9, 76);
            this.Lbl_kullanici.Name = "Lbl_kullanici";
            this.Lbl_kullanici.Size = new System.Drawing.Size(98, 18);
            this.Lbl_kullanici.TabIndex = 0;
            this.Lbl_kullanici.Text = "Kullanıcı Adı:";
            this.Lbl_kullanici.Click += new System.EventHandler(this.Lbl_kullanici_Click);
            // 
            // Txt_kullanici
            // 
            this.Txt_kullanici.BackColor = System.Drawing.Color.White;
            this.Txt_kullanici.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_kullanici.Location = new System.Drawing.Point(113, 73);
            this.Txt_kullanici.Name = "Txt_kullanici";
            this.Txt_kullanici.Size = new System.Drawing.Size(100, 21);
            this.Txt_kullanici.TabIndex = 1;
            this.Txt_kullanici.TextChanged += new System.EventHandler(this.Txt_kullanici_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(51, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.BackColor = System.Drawing.Color.White;
            this.Txt_sifre.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_sifre.Location = new System.Drawing.Point(113, 104);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(100, 21);
            this.Txt_sifre.TabIndex = 2;
            this.Txt_sifre.UseSystemPasswordChar = true;
            this.Txt_sifre.TextChanged += new System.EventHandler(this.Txt_sifre_TextChanged);
            // 
            // Lbl_sifre
            // 
            this.Lbl_sifre.AutoSize = true;
            this.Lbl_sifre.BackColor = System.Drawing.Color.White;
            this.Lbl_sifre.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_sifre.Location = new System.Drawing.Point(38, 107);
            this.Lbl_sifre.Name = "Lbl_sifre";
            this.Lbl_sifre.Size = new System.Drawing.Size(43, 18);
            this.Lbl_sifre.TabIndex = 5;
            this.Lbl_sifre.Text = "Şifre:";
            this.Lbl_sifre.Click += new System.EventHandler(this.Lbl_sifre_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.Giriş);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(123, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Akaryakıt İstasyonu Otomasyonu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Admin_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_sifre);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_kullanici);
            this.Controls.Add(this.Lbl_kullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Admin_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_kullanici;
        private System.Windows.Forms.TextBox Txt_kullanici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.Label Lbl_sifre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}