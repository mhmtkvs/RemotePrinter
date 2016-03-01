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
    public partial class YaziciForm : Form
    {
        veritabaniOperasyon veriOperasyon = new veritabaniOperasyon();

        public YaziciForm()
        {
            InitializeComponent();
        }

        private void YaziciForm_Load(object sender, EventArgs e)
        {
            var fabrikaIsimleri = veriOperasyon.fabrikaGetir();

            cmbKayitliFabrika.Items.AddRange(fabrikaIsimleri);

            cmbKayitliTesis.Enabled = false;
            cmbKayitliBant.Enabled = false;

            btnYaziciEkle.Enabled = false;
            btnYaziciGuncelle.Enabled = false;
            btnYaziciSil.Enabled = false;

            // Datagridview özelliklerini ayarla.
            gvYazicilar.MultiSelect = false;
            gvYazicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvYazicilar.ReadOnly = true;
            gvYazicilar.RowHeadersVisible = false;
            gvYazicilar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvYazicilar.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvYazicilar.AllowUserToAddRows = false;
            gvYazicilar.AllowUserToDeleteRows = false;
            gvYazicilar.AllowUserToResizeRows = false;
            gvYazicilar.AutoResizeColumns();
            gvYazicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvYazicilar.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gvYazicilar.ColumnHeadersVisible = false;

        }

        private void cmbKayitliFabrika_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKayitliTesis.Enabled = true;

            string seciliFabrika = cmbKayitliFabrika.SelectedItem.ToString();

            var kayitliTesisler = veriOperasyon.tesisGetir(seciliFabrika);

            if (kayitliTesisler.Count() > 0)
            {
                cmbKayitliTesis.Enabled = true;
                cmbKayitliTesis.Items.Clear();
                cmbKayitliTesis.Items.AddRange(kayitliTesisler);
            }
        }

        private void cmbKayitliTesis_SelectedIndexChanged(object sender, EventArgs e)
        {


            string seciliFabrika = cmbKayitliFabrika.SelectedItem.ToString();
            string seciliTesis = cmbKayitliTesis.SelectedItem.ToString();

            var kayitliBantlar = veriOperasyon.bantGetir(seciliFabrika, seciliTesis);

            if (kayitliBantlar.Count() > 0)
            {
                cmbKayitliBant.Enabled = true;
                cmbKayitliBant.Items.Clear();
                cmbKayitliBant.Items.AddRange(kayitliBantlar);
                cmbKayitliBant.SelectedIndex = 0;
            }
        }

        private void cmbKayitliBant_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnYaziciEkle.Enabled = true;

            string seciliFabrika = cmbKayitliFabrika.SelectedItem.ToString();
            string seciliTesis = cmbKayitliTesis.SelectedItem.ToString();
            string seciliBant = cmbKayitliBant.SelectedItem.ToString();

            veriOperasyon.yaziciGetir(seciliFabrika, seciliTesis, seciliBant, gvYazicilar);

        }

        private void gvYazicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelYaziciAdi.Text = gvYazicilar.Rows[e.RowIndex].Cells["yaziciAdi"].Value.ToString();
            txtGuncelPortNo.Text = gvYazicilar.Rows[e.RowIndex].Cells["portNo"].Value.ToString();
            txtGuncelComID.Text = gvYazicilar.Rows[e.RowIndex].Cells["comID"].Value.ToString();

            string ipAdres = gvYazicilar.Rows[e.RowIndex].Cells["ipAdres"].Value.ToString();

            string[] ipAdresParcali = ipAdres.Split('.');

            txtGuncelIPAdres1.Text = ipAdresParcali[0];
            txtGuncelIPAdres2.Text = ipAdresParcali[1];
            txtGuncelIPAdres3.Text = ipAdresParcali[2];
            txtGuncelIPAdres4.Text = ipAdresParcali[3];

            btnYaziciGuncelle.Enabled = true;
            btnYaziciSil.Enabled = true;
        }

        private void btnYaziciEkle_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrika.SelectedItem.ToString();
            string seciliTesisAdi = cmbKayitliTesis.SelectedItem.ToString();
            string seciliBantAdi = cmbKayitliBant.SelectedItem.ToString();

            if (txtYeniYaziciAdi.Text != "" &&
                txtYeniIPAdres1.Text != "" &&
                txtYeniIPAdres2.Text != "" &&
                txtYeniIPAdres3.Text != "" &&
                txtYeniIPAdres4.Text != "" &&
                txtYeniPortNo.Text != "" &&
                txtYeniComID.Text != "")
            {
                if (veriOperasyon.yaziciMevcut(seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, this.txtYeniYaziciAdi.Text) == false)
                {
                    //
                    string ipAdres = txtYeniIPAdres1.Text + "." + txtYeniIPAdres2.Text + "." + txtYeniIPAdres3.Text + "." + txtYeniIPAdres4.Text;

                    veriOperasyon.yaziciEkle(seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, txtYeniYaziciAdi.Text, ipAdres, txtYeniPortNo.Text, txtYeniComID.Text);

                    veriOperasyon.yaziciGetir(seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, gvYazicilar);

                    txtYeniYaziciAdi.Clear();
                    txtYeniIPAdres1.Clear();
                    txtYeniIPAdres2.Clear();
                    txtYeniIPAdres3.Clear();
                    txtYeniIPAdres4.Clear();
                    txtYeniPortNo.Clear();
                    txtYeniComID.Clear();
                }
                else
                {
                    MessageBox.Show("Yazıcı zaten kayıtlı!");
                }
            }
            else 
            {
                MessageBox.Show("Yazici bilgileri boş bırakılamaz!");
            }
        }

        private void btnYaziciGuncelle_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrika.SelectedItem.ToString();
            string seciliTesisAdi = cmbKayitliTesis.SelectedItem.ToString();
            string seciliBantAdi = cmbKayitliBant.SelectedItem.ToString();

            int SeciliIndeks = gvYazicilar.CurrentCell.RowIndex;

            //int.TryParse(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaID"].Value.ToString(), out fabrikaID);

            if (txtGuncelYaziciAdi.Text != "" &&
                txtGuncelIPAdres1.Text != "" &&
                txtGuncelIPAdres2.Text != "" &&
                txtGuncelIPAdres3.Text != "" &&
                txtGuncelIPAdres4.Text != "" &&
                txtGuncelPortNo.Text != "" &&
                txtGuncelComID.Text != "")
            {
                if (veriOperasyon.yaziciMevcut(seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, this.txtYeniYaziciAdi.Text) == false)
                {

                    string ipAdres = txtGuncelIPAdres1.Text + "." + txtGuncelIPAdres2.Text + "." + txtGuncelIPAdres3.Text + "." + txtGuncelIPAdres4.Text;

                    veriOperasyon.yaziciGuncelle(SeciliIndeks, seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, this.txtGuncelYaziciAdi.Text, ipAdres, this.txtGuncelPortNo.Text, this.txtGuncelComID.Text); 

                    veriOperasyon.yaziciGetir(seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, gvYazicilar);
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemiyor. Yazici bilgileri zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Yazıcı bilgileri eksik!");
            }
        }

        private void btnYaziciSil_Click(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrika.SelectedItem.ToString();
            string seciliTesisAdi = cmbKayitliTesis.SelectedItem.ToString();
            string seciliBantAdi = cmbKayitliBant.SelectedItem.ToString();

            // listelenen tesislerden işaretli olanın indeksini döndürür.
            int seciliIndeks = gvYazicilar.CurrentCell.RowIndex;

            // seçim yapılmış ise
            if (seciliIndeks >= 0)
            {
                DialogResult uyariPenceresi = MessageBox.Show("Silmek istediğiniz fabrikaya ait tesis, bant ve yazıcı bilgileri de silinecektir. Onaylıyor musunuz?", "UYARI!", MessageBoxButtons.YesNo);

                if (uyariPenceresi == DialogResult.Yes)
                {
                    //bant sil 
                    veriOperasyon.yaziciSil(seciliIndeks, seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi);

                    veriOperasyon.yaziciGetir(seciliFabrikaAdi, seciliTesisAdi, seciliBantAdi, gvYazicilar);

                    if (gvYazicilar.RowCount == 0)
                    {
                        btnYaziciSil.Enabled = false;
                        btnYaziciGuncelle.Enabled = false;
                    }
                }
                else if (uyariPenceresi == DialogResult.No)
                {

                }
            }
            // seçim yapılmamış ise
            else
            {
                MessageBox.Show("Listeden yazıcı seçiniz!");
            }

        }

    }
}
