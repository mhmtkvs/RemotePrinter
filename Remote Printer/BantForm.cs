using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Remote_Printer
{
    public partial class BantForm : Form
    {
        veritabaniOperasyon veriOperasyon = new veritabaniOperasyon();

        public BantForm()
        {
            InitializeComponent();
        }

        private void BantForm_Load(object sender, EventArgs e)
        {
            var fabrikaIsimleri = veriOperasyon.fabrikaGetir();

            if (fabrikaIsimleri.Count() == 0)
            {
                cmbKayitliFabrikalar.Enabled = false;
            }
            else
            {
                cmbKayitliFabrikalar.Enabled = true;
                cmbKayitliFabrikalar.Items.AddRange(fabrikaIsimleri);
            }


            cmbKayitliTesisler.Enabled = false;

            btnBantGuncelle.Enabled = false;
            btnBantSil.Enabled = false;
            btnBantEkle.Enabled = false;

            // Datagridview özelliklerini ayarla.
            gvBantlar.MultiSelect = false;
            gvBantlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvBantlar.ReadOnly = true;
            gvBantlar.RowHeadersVisible = false;
            gvBantlar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvBantlar.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvBantlar.AllowUserToAddRows = false;
            gvBantlar.AllowUserToDeleteRows = false;
            gvBantlar.AllowUserToResizeRows = false;
            gvBantlar.AutoResizeColumns();
            gvBantlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvBantlar.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gvBantlar.ColumnHeadersVisible = false;
        }

        private void cmbKayitliFabrikalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliFabrika = cmbKayitliFabrikalar.SelectedItem.ToString();

            var kayitliTesisler = veriOperasyon.tesisGetir(seciliFabrika);

            if (kayitliTesisler.Count() > 0)
            {
                cmbKayitliTesisler.Enabled = true;
                cmbKayitliTesisler.Items.Clear();
                cmbKayitliTesisler.Items.AddRange(kayitliTesisler);
                // varsayılan olan seçili fabrikanın ilk tesisini seçiyor.
                cmbKayitliTesisler.SelectedIndex = 0;
            }
        }

        private void cmbKayitliTesisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBantEkle.Enabled = true;

            string seciliFabrika = cmbKayitliFabrikalar.SelectedItem.ToString();
            string seciliTesis = cmbKayitliTesisler.SelectedItem.ToString();

            veriOperasyon.bantGetir(seciliFabrika, seciliTesis, gvBantlar);
        }

        private void btnBantEkle_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();
            string seciliTesisAdi = cmbKayitliTesisler.SelectedItem.ToString();

            if (txtYeniBantAdi.Text != "" && txtYeniBantSayisi.Text !="")
            {
                if (veriOperasyon.bantMevcut(seciliFabrikaAdi,seciliTesisAdi,this.txtYeniBantAdi.Text) == false)
                {
                    veriOperasyon.bantEkle(seciliFabrikaAdi, seciliTesisAdi, txtYeniBantAdi.Text, txtYeniBantSayisi.Text);

                    veriOperasyon.bantGetir(seciliFabrikaAdi, seciliTesisAdi, gvBantlar);

                    txtYeniBantAdi.Clear();
                    txtYeniBantSayisi.Clear();
                }
                else
                {
                    MessageBox.Show("Bant zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Bant adı veya kanal sayısı boş bırakılamaz!");
            }
        }

        private void btnBantGuncelle_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();
            string seciliTesisAdi = cmbKayitliTesisler.SelectedItem.ToString();

            int SeciliIndeks = gvBantlar.CurrentCell.RowIndex;

            //int.TryParse(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaID"].Value.ToString(), out fabrikaID);

            if (this.txtGuncelBantAdi.Text != "" && this.txtGuncelKanalSayisi.Text != "")
            {
                if (veriOperasyon.bantMevcut(seciliFabrikaAdi,seciliTesisAdi,this.txtGuncelBantAdi.Text) == false)
                {
                    // bant güncelle
                    veriOperasyon.bantGuncelle(SeciliIndeks, seciliFabrikaAdi, seciliTesisAdi, this.txtGuncelBantAdi.Text, this.txtGuncelKanalSayisi.Text);
                    //veriOperasyon.fabrikaGuncelle(SeciliIndeks, this.txtGuncelFabrikaAdi.Text);
                    veriOperasyon.bantGetir(seciliFabrikaAdi, seciliTesisAdi, gvBantlar);
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemiyor. Bant ismi zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Güncel bant ismi giriniz!");
            }
        }

        private void gvBantlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelBantAdi.Text = gvBantlar.Rows[e.RowIndex].Cells["bantAdi"].Value.ToString();
            txtGuncelKanalSayisi.Text = gvBantlar.Rows[e.RowIndex].Cells["kanalSayisi"].Value.ToString();
            //txtGuncelKanalSayisi.Text = gvBantlar.Rows
            btnBantGuncelle.Enabled = true;
            btnBantSil.Enabled = true;
        }

        private void btnBantSil_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();
            string seciliTesisAdi = cmbKayitliTesisler.SelectedItem.ToString();

            // listelenen tesislerden işaretli olanın indeksini döndürür.
            int seciliIndeks = gvBantlar.CurrentCell.RowIndex;

            // seçim yapılmış ise
            if (seciliIndeks >= 0)
            {
                DialogResult uyariPenceresi = MessageBox.Show("Silmek istediğiniz fabrikaya ait tesis, bant ve yazıcı bilgileri de silinecektir. Onaylıyor musunuz?", "UYARI!", MessageBoxButtons.YesNo);

                if (uyariPenceresi == DialogResult.Yes)
                {
                    //bant sil 
                    veriOperasyon.bantSil(seciliIndeks, seciliFabrikaAdi, seciliTesisAdi);

                    veriOperasyon.bantGetir(seciliFabrikaAdi, seciliTesisAdi, gvBantlar);

                    if (gvBantlar.RowCount == 0)
                    {
                        btnBantSil.Enabled = false;
                        btnBantGuncelle.Enabled = false;
                    }
                }
                else if (uyariPenceresi == DialogResult.No)
                {

                }

            }
            // seçim yapılmamış ise
            else
            {
                MessageBox.Show("Listeden tesis seçiniz!");
            }
        }
    }
}
