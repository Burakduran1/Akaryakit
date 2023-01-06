using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace İstasyonProje
{
    public partial class Şifre : Form
    {
        public Şifre()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();
        private void Şifre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelBilgiDataSet3.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.personelBilgiDataSet3.admin);
            // TODO: This line of code loads data into the 'personelBilgiDataSet13.admin' table. You can move, or remove it, as needed.


        }

        private void Button_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into admin (Yönetici_Ad,Yönetici_Şifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.adminTableAdapter.Fill(this.personelBilgiDataSet3.admin);
            MessageBox.Show("Yönetici Eklendi");
           


        }

        private void Button_sil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Satırı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from admin where Yönetici_İd=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txt_id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.adminTableAdapter.Fill(this.personelBilgiDataSet3.admin);

            }
            else
            {
                MessageBox.Show("Silinme İşlemi Gerçekleşmedi.","Satırı Silme",MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }

        }

        public  void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre,id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Txt_ad.Text = ad;
            Txt_sifre.Text = sifre;
            Txt_id.Text = id;
            this.adminTableAdapter.Fill(this.personelBilgiDataSet3.admin);
        }

        private void Button_guncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?", "Düzenle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("update admin set Yönetici_Ad=@p1,Yönetici_Şifre=@p2 where Yönetici_İd=@p3", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", Txt_ad.Text);
                komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);
                komut.Parameters.AddWithValue("@p3", Txt_id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.adminTableAdapter.Fill(this.personelBilgiDataSet3.admin);
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Gerçekleşmedi.", "Düzenleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
