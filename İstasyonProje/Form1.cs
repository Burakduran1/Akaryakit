using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using DevExpress.XtraBars;

namespace İstasyonProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void giderİstatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelBilgiDataSet7.Satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter1.Fill(this.personelBilgiDataSet7.Satis);
            // TODO: This line of code loads data into the 'personelBilgiDataSet6.Satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.personelBilgiDataSet6.Satis);
            timer1.Start();
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void tarayıcıyıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome.exe");
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Personel frm = new Personel();
            frm.Show();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_list frm = new Personel_list();
            frm.Show();
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_duzenle frm = new Personel_duzenle();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v frm = new v();
            frm.Show();
        }

        private void giderGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderGuncelle frm = new GiderGuncelle();
            frm.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderListe frm = new GiderListe();
            frm.Show();
        }

        private void gelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gelir frm = new Gelir();
            frm.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Şifre frm = new Şifre();
            frm.Show();
        }

        private void personelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_list frm = new Personel_list();
            frm.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis frm = new Satis();
            frm.Show();
        }

        private void akaryakıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkaryakıtBilgi frm = new AkaryakıtBilgi();
            frm.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkaryakıtBilgi frm = new AkaryakıtBilgi();
            frm.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Not frm = new Not();
            frm.Show();
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Burak Can DURAN Tarafından , Nesne Tabanlı Programlama Dersi Kapsamında Hazırlanılmıştır.", "Akaryakıt İstasyonu Otomasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("burakduran12491@gmail.com", "İletişim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SQLbaglanti bgl = new SQLbaglanti();
            DataTable dt = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Satis where Arac_Plaka like '%" + textBox1.Text + "%' ",bgl.baglanti());
                ara.Fill(dt);
            bgl.baglanti().Close();
            dataGridView1.DataSource = dt;
            
        }
    }
}
