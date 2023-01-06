using DevExpress.Utils.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İstasyonProje
{
    public partial class Personel_duzenle : Form
    {
        public Personel_duzenle()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();
        public string id,ad,soyad,tc,telefon,adres,dogum,ogrenim,pozisyon,maas;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", " Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from Personel where Personel_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txt_personel_id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme Başarılı");
            }
            else
            {
                MessageBox.Show("Silinme İşlemii Gerçekleşmedi.", " Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Personel_duzenle_Load(object sender, EventArgs e)
        {
            Txt_personel_id.Text = id;
            Txt_ad.Text = ad;
            Txt_soyad.Text = soyad;
            Txt_tc.Text = tc;
            Txt_telefon.Text = telefon;
            Txt_adres.Text= adres;
            Txt_dogum.Text= dogum;
            Combo_ogrenim.Text = ogrenim;
            Combo_pozisyon.Text = pozisyon;
            Txt_maas.Text = maas;
        }

        private void Button_guncelle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("update Personel set  Personel_Ad=@p1,Personel_Soyad=@p2,Personel_Tc=@p3,Personel_Telefon=@p4,Personel_Adres=@p5,Personel_DogumTarihi=@p6,Personel_Ogrenim=@p7,Personel_Pozisyon=@p8, Personel_Maas=@p9 where Personel_id=@p10", bgl.baglanti());
                
                komut.Parameters.AddWithValue("@p1", Txt_ad.Text);
                komut.Parameters.AddWithValue("@p2", Txt_soyad.Text);
                komut.Parameters.AddWithValue("@p3", Txt_tc.Text);
                komut.Parameters.AddWithValue("@p4", Txt_telefon.Text);
                komut.Parameters.AddWithValue("@p5", Txt_adres.Text);
                komut.Parameters.AddWithValue("@p6", Txt_dogum.Text);
                komut.Parameters.AddWithValue("@p7", Combo_ogrenim.Text);
                komut.Parameters.AddWithValue("@p8", Combo_pozisyon.Text);
                komut.Parameters.AddWithValue("@p9", Txt_maas.Text);
                  komut.Parameters.AddWithValue("@p10", Txt_personel_id.Text);
            komut.ExecuteNonQuery();
                bgl.baglanti().Close();
               MessageBox.Show("Kaydınız Güncellendi.");
            
            
           
        }
    }
}
