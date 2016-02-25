using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Remote_Printer
{
    public partial class TesisForm : Form
    {
        veritabaniOperasyon veriOperasyon = new veritabaniOperasyon();

        public TesisForm()
        {
            InitializeComponent();
        }


        private void TesisForm_Load(object sender, EventArgs e)
        {
            var fabrikaIsimleri = veriOperasyon.fabrikaGetir();

            cmbKayitliFabrikalar.Items.AddRange(fabrikaIsimleri);

            btnTesisSil.Enabled = false;
            btnTesisGuncelle.Enabled = false;

            // Datagridview özelliklerini ayarla.
            gvTesisler.MultiSelect = false;
            gvTesisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvTesisler.ReadOnly = true;
            gvTesisler.RowHeadersVisible = false;
            gvTesisler.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvTesisler.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvTesisler.AllowUserToAddRows = false;
            gvTesisler.AllowUserToDeleteRows = false;
            gvTesisler.AllowUserToResizeRows = false;
            gvTesisler.AutoResizeColumns();
            gvTesisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvTesisler.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gvTesisler.ColumnHeadersVisible = false;
        }

        private void cmbKayitliFabrikalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();

            veriOperasyon.tesisGetir(seciliFabrikaAdi,gvTesisler);
        }


        private void btnTesisEkle_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();

            if (txtYeniTesisAdi.Text != "")
            {
                if (veriOperasyon.tesisMevcut(this.txtYeniTesisAdi.Text, seciliFabrikaAdi) == false)
                {
                    veriOperasyon.tesisEkle(txtYeniTesisAdi.Text, seciliFabrikaAdi);

                    veriOperasyon.tesisGetir(seciliFabrikaAdi, gvTesisler);

                    txtYeniTesisAdi.Clear();
                }
                else
                {
                    MessageBox.Show("Tesis zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Yeni tesis adı giriniz!");
            }
        }

        private void btnTesisSil_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();

            // listelenen tesislerden işaretli olanın indeksini döndürür.
            int seciliIndeks = gvTesisler.CurrentCell.RowIndex;

            // seçim yapılmış ise
            if (seciliIndeks >= 0)
            {
                DialogResult uyariPenceresi = MessageBox.Show("Silmek istediğiniz fabrikaya ait tesis, bant ve yazıcı bilgileri de silinecektir. Onaylıyor musunuz?","UYARI!",MessageBoxButtons.YesNo);

                if (uyariPenceresi == DialogResult.Yes)
                {
                    //MessageBox.Show(seciliIndeks.ToString());

                    veriOperasyon.tesisSil(seciliIndeks, seciliFabrikaAdi);

                    if (gvTesisler.RowCount == 0)
                    {
                        btnTesisSil.Enabled = false;
                        btnTesisGuncelle.Enabled = false;
                    }
                }
                else if (uyariPenceresi == DialogResult.No)
                {
 
                }
                veriOperasyon.tesisGetir(seciliFabrikaAdi, gvTesisler);
            }
            // seçim yapılmamış ise
            else
            {
                MessageBox.Show("Listeden tesis seçiniz!");
            }

        }

        private void btnTesisGuncelle_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();

            int SeciliIndeks = gvTesisler.CurrentCell.RowIndex;

            //int.TryParse(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaID"].Value.ToString(), out fabrikaID);

            if (this.txtGuncelTesisAdi.Text != "")
            {
                if (veriOperasyon.tesisMevcut(this.txtGuncelTesisAdi.Text, seciliFabrikaAdi) == false)
                {
                    veriOperasyon.tesisGuncelle(SeciliIndeks, seciliFabrikaAdi, this.txtGuncelTesisAdi.Text);

                    //veriOperasyon.fabrikaGuncelle(SeciliIndeks, this.txtGuncelFabrikaAdi.Text);
                    veriOperasyon.tesisGetir(seciliFabrikaAdi, gvTesisler);
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemiyor. Tesis ismi zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Güncel tesis ismi giriniz!");
            }
        }

        private void gvTesisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelTesisAdi.Text = gvTesisler.Rows[e.RowIndex].Cells["tesisAdi"].Value.ToString();
            btnTesisGuncelle.Enabled = true;
            btnTesisSil.Enabled = true;
        }


    }
}
