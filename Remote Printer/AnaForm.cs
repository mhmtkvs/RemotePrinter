using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;



namespace Remote_Printer
{
    public partial class AnaForm : Form
    {
        private const int KANAL_SAYISI = 10;

        veritabaniOperasyon veriOperasyon = new veritabaniOperasyon();

        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string dosyayolu = Application.ExecutablePath.ToString();
            //fabrikaGetir();
            this.gvKanal.MultiSelect = false;
            this.gvKanal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gvKanal.RowHeadersVisible = false;
            this.gvKanal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.gvKanal.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.gvKanal.AllowUserToAddRows = false;
            this.gvKanal.AllowUserToDeleteRows = false;
            this.gvKanal.AllowUserToResizeRows = false;
            this.gvKanal.AllowUserToResizeColumns = false;
            this.gvKanal.AutoResizeColumns();
            this.gvKanal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKanal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.gvKanal.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            this.gvKanal.ColumnCount = 8;

            this.gvKanal.Columns[0].Name = "Kombinasyon Barkod Kodu";
            this.gvKanal.Columns[1].Name = "Ürün Adı";
            this.gvKanal.Columns[2].Name = "Ürün Kodu";
            this.gvKanal.Columns[3].Name = "Barkod Kodu";
            this.gvKanal.Columns[4].Name = "Personel Sicil No";
            this.gvKanal.Columns[5].Name = "Ton";
            this.gvKanal.Columns[6].Name = "Kalibre";
            this.gvKanal.Columns[7].Name = "Üretim Tarihi";

            DataGridViewButtonColumn webServis = new DataGridViewButtonColumn();
            this.gvKanal.Columns.Insert(8, webServis);

            webServis.Text = "Veri";

            webServis.UseColumnTextForButtonValue = true;


            for(int i = 0; i < KANAL_SAYISI; i++)
            {
                this.gvKanal.Rows.Add("", "", "", "", "", "", "", "");
            }

            foreach (DataGridViewRow satir in gvKanal.Rows)
            {
                satir.Height = 32;
            }

     }

        private void fabrikaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FabrikaForm fabrikaIslemleri = new FabrikaForm();
            fabrikaIslemleri.Show();
        }

        private void tesisİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesisForm tesisIslemleri = new TesisForm();
            tesisIslemleri.Show();
        }

        private void bantİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BantForm bantIslemleri = new BantForm();
            bantIslemleri.Show();
        }

        private void yazıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziciForm yaziciIslemleri = new YaziciForm();
            yaziciIslemleri.Show();
        }

        private void gvKanal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }

    }
}
