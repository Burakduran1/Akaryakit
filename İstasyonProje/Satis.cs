using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace İstasyonProje
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        SQLbaglanti bgl = new SQLbaglanti();
        private void Satis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelBilgiDataSet2.Satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.personelBilgiDataSet2.Satis);
            // TODO: This line of code loads data into the 'personelBilgiDataSet12.Satis' table. You can move, or remove it, as needed.

            SqlCommand komut = new SqlCommand("select * from Akaryakit_Bilgileri  ", bgl.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Txt_tip.Items.Add(read["Akaryakit_Tipi"]);
            }
            bgl.baglanti().Close();

            //
            SqlCommand komut1 = new SqlCommand("select * from odeme_tur  ", bgl.baglanti());
            SqlDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {
                Txt_tur.Items.Add(read1["Nakit"]);
                Txt_tur.Items.Add(read1["Peşin"]);
            }
            bgl.baglanti().Close();

            //
            SqlCommand komut2 = new SqlCommand("select * from Personel ", bgl.baglanti());
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                Txt_personel.Items.Add(read2["Personel_Ad"]);
                Txt_personel.Items.Add(read2["Personel_Soyad"]);
            }
            bgl.baglanti().Close();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut_kaydet1 = new SqlCommand("insert into Satis (Arac_Plaka,Akaryakit_Tur,Tutar,Litre,Odeme_Turu,Satan_Personel) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

                komut_kaydet1.Parameters.AddWithValue("@p1", Txt_plaka.Text);
                komut_kaydet1.Parameters.AddWithValue("@p2", Txt_tip.Text);
                komut_kaydet1.Parameters.AddWithValue("@p3", Txt_tutar.Text);
                komut_kaydet1.Parameters.AddWithValue("@p4", Txt_litre.Text);
                komut_kaydet1.Parameters.AddWithValue("@p5", Txt_tur.Text);
                komut_kaydet1.Parameters.AddWithValue("@p6", Txt_personel.Text);
                komut_kaydet1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt İşlemi Başarılı");
                this.satisTableAdapter.Fill(this.personelBilgiDataSet2.Satis);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata !!Tekrar Deneyiniz");

            }


        }

      

       

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, plaka, tur, tutar, litre, nakit, personel;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            plaka = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tur = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tutar = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            litre = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            nakit = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            Txt_İd.Text = id;
            Txt_plaka.Text = plaka;
            Txt_tur.Text = nakit;
            Txt_tutar.Text = tutar;
            Txt_litre.Text = litre;
            this.satisTableAdapter.Fill(this.personelBilgiDataSet2.Satis);

            Txt_personel.Text = personel;
            Txt_tip.Text = nakit;
             
        }

        private void Txt_tip_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
