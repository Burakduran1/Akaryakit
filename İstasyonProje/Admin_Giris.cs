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
    public partial class Admin_Giris : Form
    {
        public Admin_Giris()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_sifre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("select * from admin where Yönetici_Ad='" + Txt_kullanici.Text + "' and Yönetici_Şifre='" + Txt_sifre.Text + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form1 frm = new Form1();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Hatali giris.");
            }
        }

        private void Admin_Giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
           
        }

        private void Lbl_kullanici_Click(object sender, EventArgs e)
        {

        }

        private void Txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_kullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giriş(object sender, DrawToolTipEventArgs e)
        {

        }
    }
    
}
