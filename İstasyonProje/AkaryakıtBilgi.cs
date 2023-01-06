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

namespace İstasyonProje
{
    public partial class AkaryakıtBilgi : Form
    {
        public AkaryakıtBilgi()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelBilgiDataSet.Akaryakit_Bilgileri' table. You can move, or remove it, as needed.
            this.akaryakit_BilgileriTableAdapter.Fill(this.personelBilgiDataSet.Akaryakit_Bilgileri);
            // TODO: This line of code loads data into the 'personelBilgiDataSet.Akaryakit_Bilgileri' table. You can move, or remove it, as needed.


        }

        private void Pcb_ekle_Click(object sender, EventArgs e)
        {
            try
            {
             
                SqlCommand komut1 = new SqlCommand("insert into Akaryakit_Bilgileri (Akaryakit_Tipi,Akaryakit_fiyat) values (@p1,@p2)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", Txt_akAd.Text);
                komut1.Parameters.AddWithValue("@p2", Txt_akFiyat.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.akaryakit_BilgileriTableAdapter.Fill(this.personelBilgiDataSet.Akaryakit_Bilgileri);
                MessageBox.Show("İşlem Başarılı");
              
            }
            catch
            {
                MessageBox.Show("Hata Oluştu !!");
            }
        }

        private void Pcb_sil_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand komut2 = new SqlCommand("delete from Akaryakit_Bilgileri where Akaryakit_İd=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", Txt_akİd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.akaryakit_BilgileriTableAdapter.Fill(this.personelBilgiDataSet.Akaryakit_Bilgileri);

            }
            else
            {
                MessageBox.Show("Silme İşlemi Gerçekleşmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                
            

        }
        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, ad, fiyat;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fiyat = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            Txt_akİd.Text = id;
            Txt_akAd.Text = ad;
            Txt_akFiyat.Text = fiyat;
            this.akaryakit_BilgileriTableAdapter.Fill(this.personelBilgiDataSet.Akaryakit_Bilgileri);

        }

        private void Pcb_duzenle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz?", "Düzenleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                SqlCommand komut3 = new SqlCommand("update Akaryakit_Bilgileri Set Akaryakit_Tipi=@p1 where Akaryakit_İd=@p2 ", bgl.baglanti());
                SqlCommand komut4 = new SqlCommand("update Akaryakit_Bilgileri Set Akaryakit_fiyat=@p3 where Akaryakit_İd=@p4 ", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", Txt_akİd.Text);
                komut3.Parameters.AddWithValue("@p1", Txt_akAd.Text);
                komut4.Parameters.AddWithValue("@p4", Txt_akİd.Text);
                komut4.Parameters.AddWithValue("@p3", Txt_akFiyat.Text);
                komut3.ExecuteNonQuery();
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.akaryakit_BilgileriTableAdapter.Fill(this.personelBilgiDataSet.Akaryakit_Bilgileri);
            }
            
            else
            {

            }
            
              
            

        }
    }
}
