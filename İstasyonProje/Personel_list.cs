using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstasyonProje
{
    public partial class Personel_list : Form
    {
        public Personel_list()
        {
            InitializeComponent();
        }
        int secilen;

        private void Personel_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelBilgiDataSet4.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.personelBilgiDataSet4.Personel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            Personel_duzenle frm = new Personel_duzenle();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.adres = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.dogum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.ogrenim= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.pozisyon = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm.maas = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            
            frm.Show();
            this.personelTableAdapter.Fill(this.personelBilgiDataSet4.Personel);
        }
    }
}
