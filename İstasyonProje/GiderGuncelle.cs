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
    public partial class GiderGuncelle : Form
    {
        public GiderGuncelle()
        {
            InitializeComponent();
        }
        public string id,elektrik, su, dogalgaz, gida, diger, internet, personel;
        SQLbaglanti bgl = new SQLbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update gider set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Personel=@p5,Gida=@p6,Diger=@p7 where Gider_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txt_id.Text);
                komut.Parameters.AddWithValue("@p2", Txt_elektrik.Text);
                komut.Parameters.AddWithValue("@p3", Txt_su.Text);
                komut.Parameters.AddWithValue("@p4", Txt_dogalgaz.Text);
                komut.Parameters.AddWithValue("@p5", Txt_internet.Text);
                komut.Parameters.AddWithValue("@p6", Txt_personel.Text);
                komut.Parameters.AddWithValue("@p7", Txt_gida.Text);
                komut.Parameters.AddWithValue("@p8", Txt_diger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Güncelleme Başarılı");
            }
            catch
            {

                MessageBox.Show("İşlem Başarısız!");

            }
        }

        private void GiderGuncelle_Load(object sender, EventArgs e)
        {
            Txt_id.Text= id;
            Txt_elektrik.Text = elektrik;
            Txt_su.Text = su;
            Txt_dogalgaz.Text=dogalgaz;
            Txt_gida.Text = gida;
            Txt_diger.Text= diger ;
            Txt_internet.Text = internet;
            Txt_personel.Text = personel;
           
        }
    }
}
