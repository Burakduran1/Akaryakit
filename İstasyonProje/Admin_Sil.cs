using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstasyonProje
{
    public partial class Admin_Sil : Form
    {
        public Admin_Sil()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from admin where Yönetici_İd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
        }
    }
}
