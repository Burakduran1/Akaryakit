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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            // Pozisyonları Listeleme
            
            SqlCommand komut = new SqlCommand("Select Pozisyon_Ad from Pozisyonlar",bgl.baglanti());
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
                Combo_pozisyon.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Egitim Durumları Gorme
            
            SqlCommand komut2 = new SqlCommand("Select Egitim_duzeyi from Egitim", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Combo_ogrenim.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();

        }

        private void Button_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut_kaydet = new SqlCommand("insert into Personel (Personel_Ad,Personel_Soyad,Personel_Tc,Personel_Telefon,Personel_Adres,Personel_DogumTarihi,Personel_Ogrenim,Personel_Pozisyon,Personel_Maas) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut_kaydet.Parameters.AddWithValue("@p1", Txt_ad.Text);
                komut_kaydet.Parameters.AddWithValue("@p2", Txt_soyad.Text);
                komut_kaydet.Parameters.AddWithValue("@p3", Txt_tc.Text);
                komut_kaydet.Parameters.AddWithValue("@p4", Txt_telefon.Text);
                komut_kaydet.Parameters.AddWithValue("@p5", Txt_adres.Text);
                komut_kaydet.Parameters.AddWithValue("@p6", Txt_dogum.Text);
                komut_kaydet.Parameters.AddWithValue("@p7", Combo_ogrenim.Text);
                komut_kaydet.Parameters.AddWithValue("@p8", Combo_pozisyon.Text);
                komut_kaydet.Parameters.AddWithValue("p9", Txt_maas.Text);
                komut_kaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt İşlemi Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !!Tekrar Deneyiniz");
               
            }
        }
    }
}
//Data Source=BURAK\SQLEXPRESS;Initial Catalog=PersonelBilgi;Integrated Security=True