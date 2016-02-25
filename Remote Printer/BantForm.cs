﻿using System;
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

        bool ilkIslem = false;

        public BantForm()
        {
            InitializeComponent();
        }

        private void BantForm_Load(object sender, EventArgs e)
        {
            var fabrikaIsimleri = veriOperasyon.fabrikaGetir();

            cmbKayitliFabrikalar.Items.AddRange(fabrikaIsimleri);

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

            cmbKayitliTesisler.Enabled = true;

            string seciliFabrika = cmbKayitliFabrikalar.SelectedItem.ToString();

            var kayitliTesisler = veriOperasyon.tesisGetir(seciliFabrika);

            cmbKayitliTesisler.Items.Clear();
            cmbKayitliTesisler.Items.AddRange(kayitliTesisler);

            // varsayılan olan seçili fabrikanın ilk tesisini seçiyor.
            cmbKayitliTesisler.SelectedIndex = 0;
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
                if (true)
                {
                    veriOperasyon.bantEkle(seciliFabrikaAdi, seciliTesisAdi, txtYeniBantAdi.Text, txtYeniBantSayisi.Text);

                    veriOperasyon.bantGetir(seciliFabrikaAdi, seciliTesisAdi, gvBantlar);

                    txtYeniBantAdi.Clear();
                    txtYeniBantSayisi.Clear();
                }
                else
                {
                    MessageBox.Show("Tesis zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Bant adı veya kanal sayısı boş bırakılamaz!");
            }
        }
    }
}
