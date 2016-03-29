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

        // veritabani işlemleri için veritabaniOperasyon sınıfından bir nesne yaratılıyor.
        veritabaniOperasyon veriOperasyon = new veritabaniOperasyon();

        // sisteme kayitli yazıcıların yazılım çalışması boyunca tutulması için ilgili surucu nesnelerinden listeler oluşturuluyor.
        List<logoPrinterSurucu> kayitliLogoPrinter = new List<logoPrinterSurucu>();
        List<hr500Surucu> kayitliHR500 = new List<hr500Surucu>();
        List<tiflexSurucu> kayitliTiflex = new List<tiflexSurucu>();

        public AnaForm()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnYazdir.Enabled = false;
            // Form yüklenirken veritabanına kayıtlı fabrika isimleri getiriliyor.
            string[] kayitliFabrikalar = veriOperasyon.fabrikaGetir();

            // Veritabanından çekilen kayıt yok ise Fabrika combobox pasif yapılıyor.
            if (kayitliFabrikalar.Count() == 0)
            {
                cmbFabrika.Enabled = false;
            }
            else
            {
                // kayıt var ise Fabrika combobox aktif olacak ve combobox içeriği dolduruluyor.
                cmbFabrika.Enabled = true;
                cmbFabrika.Items.Clear();
                cmbFabrika.Items.AddRange(veriOperasyon.fabrikaGetir());
                //cmbFabrika.SelectedIndex = 0;
            }

            // Form yüklenirken Tesis,Bant ve Yazıcı comboboxları pasif yapılıyor.
            cmbTesis.Enabled = false;
            cmbBant.Enabled = false;
            cmbYazici.Enabled = false;



            // kanal bilgilerini gösterecek datagridview görsel ayarları yapılıyor.
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

            // form yüklenirken yazıcı nesnelerini oluştur.
            DataTable yaziciTablosu = veriOperasyon.yaziciTablosuGetir();

            int yaziciSayisi = yaziciTablosu.Rows.Count;

            string ipAdres;
            int portNo;
            int yaziciID;
            int yaziciTipiSecim;

            for (int i = 0; i < yaziciSayisi; i++)
            {
                yaziciTipiSecim = Convert.ToInt32(yaziciTablosu.Rows[i]["yaziciTipi"]);
                ipAdres = yaziciTablosu.Rows[i]["ipAdres"].ToString();
                portNo = Convert.ToInt32(yaziciTablosu.Rows[i]["portNo"]);
                yaziciID = Convert.ToInt32(yaziciTablosu.Rows[i]["yaziciID"]);

                if (yaziciTipiSecim == 0)
                {
                    kayitliLogoPrinter.Add(new logoPrinterSurucu(ipAdres, portNo, yaziciID));
                }
                else if (yaziciTipiSecim == 1)
                {
                    kayitliHR500.Add(new hr500Surucu(ipAdres, portNo, yaziciID));
                }
                else if (yaziciTipiSecim == 2)
                {
                    kayitliTiflex.Add(new tiflexSurucu(ipAdres, portNo, yaziciID));
                }
            }

            //MessageBox.Show(kayitliLogoPrinter.Count.ToString());
            //MessageBox.Show(kayitliHR500.Count.ToString());
            //MessageBox.Show(kayitliTiflex.Count.ToString());

     }

        private void fabrikaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menüden fabrika işlemleri seçildiğinde fabrika formu açılıyor.
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

        /*
         * Yazıcı bağlantıları kontrol edilecek.
         * **/
        public void baglantiKontrol()
        {
 
        }

        private void cmbFabrika_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fabrika comboboxından seçim yapıldığında fabrika adına göre tesisler veritabanından getiriliyor.
            string[] kayitliTesisler = veriOperasyon.tesisGetir(cmbFabrika.SelectedItem.ToString());

            // Fabrikaya kayıtlı tesis yok ise Tesis combobox pasif yapılıyor.
            if (kayitliTesisler.Count() == 0)
            {
                cmbTesis.Enabled = false;
            }
            else
            {
                // Fabrikaya kayıtlı tesis var ise Tesis combobox aktif yapılıyor ve Tesis combobox içeriği dolduruluyor.
                cmbTesis.Enabled = true;
                cmbTesis.Items.Clear();
                cmbTesis.Items.AddRange(kayitliTesisler);
                cmbTesis.SelectedIndex = 0;
            }
        }

        private void cmbBant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliFabrika = cmbFabrika.SelectedItem.ToString();
            string seciliTesis = cmbTesis.SelectedItem.ToString();
            string seciliBant = cmbBant.SelectedItem.ToString();

            string[] kayitliYazicilar = veriOperasyon.yaziciGetir(seciliFabrika, seciliTesis, seciliBant);

            if (kayitliYazicilar.Count() == 0)
            {
                cmbYazici.Enabled = false;
            }
            else
            {
                cmbYazici.Enabled = true;
                cmbYazici.Items.Clear();
                cmbYazici.Items.AddRange(kayitliYazicilar);
                cmbYazici.SelectedIndex = 0;
            }

        }

        private void cmbTesis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tesis comboboxından bant seçimi yapıldığında veritabanında kayıtlı bant bilgileri getiriliyor.
            string[] kayitliBantlar = veriOperasyon.bantGetir(cmbFabrika.SelectedItem.ToString(), cmbTesis.SelectedItem.ToString());

            // Kayıtlı bant yok ise Bant comboboxı pasif yaplıyor.
            if (kayitliBantlar.Count() == 0)
            {
                cmbBant.Enabled = false;
            }
            else
            {
                // kayıtlı bant var ise Bant comboboxı aktif yapılıyor ve combobox içeriği dolduruluyor.
                cmbBant.Enabled = true;
                cmbBant.Items.Clear();
                cmbBant.Items.AddRange(kayitliBantlar);
                cmbBant.SelectedIndex = 0;
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int seciliYazici = veriOperasyon.yaziciIDGetir(cmbYazici.SelectedItem.ToString());

            //MessageBox.Show(seciliYazici.ToString());

            bool logoPrinterSecili = kayitliLogoPrinter.Exists(x => x.getYaziciID() == seciliYazici);
            bool hr500Secili = kayitliHR500.Exists(x => x.getYaziciID() == seciliYazici);
            bool tiflexSecili = kayitliTiflex.Exists(x => x.getYaziciID() == seciliYazici);

            if (logoPrinterSecili == true)
            {
                int listIndeks = kayitliLogoPrinter.FindIndex(x => x.getYaziciID() == seciliYazici);

                //kayitliLogoPrinter[listIndeks].sendMessage("ABC", "Merhaba");

            }

            if (hr500Secili == true)
            {
                int listIndeks = kayitliHR500.FindIndex(x => x.getYaziciID() == seciliYazici);

               //kayitliHR500[listIndeks].sendMessage();
            }

            if (tiflexSecili == true)
            {
                int listIndeks = kayitliTiflex.FindIndex(x => x.getYaziciID() == seciliYazici);
            }


        }

        private void cmbYazici_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnYazdir.Enabled = true;
        }

    }
}
