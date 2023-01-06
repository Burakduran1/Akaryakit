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
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();
        private void Gelir_Load(object sender, EventArgs e)
        { 
            // aylik kazanc
            this.chart1.Series["Günlük"].Points.AddY(1500);
            this.chart1.Series["Günlük"].Points.AddY(1200);




            SqlCommand komut = new SqlCommand("Select sum(Tutar) from Satis", bgl.baglanti());
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
                Lbl_toplam.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
