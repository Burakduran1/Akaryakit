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
    public partial class GiderListe : Form
    {
        public GiderListe()
        {
            InitializeComponent();
        }

        private void GiderListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelBilgiDataSet1.gider' table. You can move, or remove it, as needed.
            this.giderTableAdapter.Fill(this.personelBilgiDataSet1.gider);
            // TODO: This line of code loads data into the 'personelBilgiDataSet11.gider' table. You can move, or remove it, as needed.


        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GiderGuncelle frm = new GiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.gida = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.diger = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.internet = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.personel = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
            frm.Show();
            this.giderTableAdapter.Fill(this.personelBilgiDataSet1.gider);

        }
    }
}
