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
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutt = new SqlCommand("insert into gider ( Elektrik,Su,Dogalgaz,internet,Personel,Gida,Diger) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());

                komutt.Parameters.AddWithValue("@p1", Txt_elektrik.Text);
                komutt.Parameters.AddWithValue("@p2", Txt_su.Text);
                komutt.Parameters.AddWithValue("@p3", Txt_dogalgaz.Text);
                komutt.Parameters.AddWithValue("@p4", Txt_internet.Text);
                komutt.Parameters.AddWithValue("@p5", Txt_personel.Text);
                komutt.Parameters.AddWithValue("@p6", Txt_gida.Text);
                komutt.Parameters.AddWithValue("@p7", Txt_diger.Text);
                komutt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydedildi");
            }
            catch
            {
                MessageBox.Show("Hata");
            }

        }

        private void v_Load(object sender, EventArgs e)
        {

        }
    }
}
