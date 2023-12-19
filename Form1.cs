using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tİyatro_sinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi=new List<Tiyatro>();

        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroListesi.Add(new Tiyatro(1," İfigenya", 75 , "Fatih Reşat Nuri Sahnesi", false, 250, new DateTime(2024,01,19)));
            tiyatroListesi.Add(new Tiyatro(2," Karagöz ve Hacivat", 40 , "Gaziosmanpaşa Sahnesi", true, 240, new DateTime(2024, 01, 23)));
            tiyatroListesi.Add(new Tiyatro(3," Samanyolu'nu Bilir Misiniz?", 85 , "Ümraniye Sahnesi", true, 200, new DateTime(2024, 02, 10)));
            tiyatroListesi.Add(new Tiyatro(4," Oscar", 35, "Kağıthane Sadabad Sahnesi", true, 220, new DateTime(2024, 01, 02)));
            tiyatroListesi.Add(new Tiyatro(5," Gül'e Ağıt", 50, "Harbiye Muhsin Ertuğrul Sahnesi", false, 260, new DateTime(2024, 01, 27)));
            tiyatroListesi.Add(new Tiyatro(6," Meçhul Paşa", 30, "Müze Gazhane Meydan Sahne", true, 230, new DateTime(2024, 02, 14)));
             
            dgvTiyatro.DataSource=tiyatroListesi;



        }

        private void dgvTiyatro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOyunİd.Text = dgvTiyatro.CurrentRow.Cells["oyunİd"].Value.ToString();
            cmbOyunAd.Text = dgvTiyatro.CurrentRow.Cells["oyunAd"].Value.ToString();
            nudOyunSure.Value = (int)dgvTiyatro.CurrentRow.Cells["oyunSure"].Value;
            cmbSahne.Text = dgvTiyatro.CurrentRow.Cells["sahne"].Value.ToString();
            chbMuzikal.Checked = (bool)dgvTiyatro.CurrentRow.Cells["muzikal"].Value;
            txtFiyat.Text= dgvTiyatro.CurrentRow.Cells["fiyat"].Value.ToString();
            dtpTarihSaat.Value = (DateTime)dgvTiyatro.CurrentRow.Cells["tarihSaat"].Value;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int oyunİd = Convert.ToInt32(txtOyunİd.Text);
            string oyunAd = cmbOyunAd.Text;
            int oyunSure = Convert.ToInt32(nudOyunSure.Value);
            string oyunSahne = cmbSahne.Text;
            bool muzikal = chbMuzikal.Checked;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            DateTime tarihSaat = dtpTarihSaat.Value;

            Tiyatro yeniTiyatro = new Tiyatro(oyunİd, oyunAd, oyunSure, oyunSahne, muzikal, fiyat, tarihSaat);
            tiyatroListesi.Add(yeniTiyatro);
            dgvTiyatro.DataSource = tiyatroListesi.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvTiyatro.SelectedRows[0];
            Tiyatro secİlenTiyatro = secilenSatir.DataBoundItem as Tiyatro;
            DialogResult result=MessageBox.Show("Seçilen Tiyatro silinsin mi?","Tiyatro Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tiyatroListesi.Remove(secİlenTiyatro);
            }

            dgvTiyatro.DataSource=tiyatroListesi.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvTiyatro.SelectedRows[0];
            Tiyatro secİlenTiyatro = secilenSatir.DataBoundItem as Tiyatro;

            int oyunİd = Convert.ToInt32(txtOyunİd.Text);
            string oyunAd = cmbOyunAd.Text;
            int oyunSure = Convert.ToInt32(nudOyunSure.Value);
            string oyunSahne = cmbSahne.Text;
            bool muzikal = chbMuzikal.Checked;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            DateTime tarihSaat = dtpTarihSaat.Value;

            secİlenTiyatro.Oyunİd = oyunİd;
            secİlenTiyatro.OyunAd = oyunAd;
            secİlenTiyatro.OyunSure=oyunSure;
            secİlenTiyatro.Sahne = oyunSahne;
            secİlenTiyatro.Muzikal = muzikal;
            secİlenTiyatro.Fiyat=fiyat;
            secİlenTiyatro.TarihSaat = tarihSaat;
            dgvTiyatro.DataSource = null;
            dgvTiyatro.DataSource = tiyatroListesi.ToList();

        }
    }
}
