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
        private SQLiteConnection veritabaniBaglanti = new SQLiteConnection();
        private SQLiteCommand veritabaniKomut;
        private SQLiteDataReader veritabaniOkuyucu;
        string connString = "Data Source=D:\\RemotePrinter\\Remote Printer\\Database\\remotePrinter.db";

        public TesisForm()
        {
            InitializeComponent();
        }

        private void cmbKayitliFabrikalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();

            //MessageBox.Show(seciliFabrikaAdi);

            tesisGetir(seciliFabrikaAdi);
        }

        private void tesisGetir(string fabrikaAdi)
        {
            veritabaniBaglanti.ConnectionString = connString;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT tesisAdi FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", fabrikaAdi);

                DataTable datatable = new DataTable();
                datatable.Load(veritabaniKomut.ExecuteReader());
                gvTesisler.DataSource = datatable;
            }
            veritabaniBaglanti.Close();
        }

        private void TesisForm_Load(object sender, EventArgs e)
        {
            var fabrikaIsimleri = fabrikaGetir();

            cmbKayitliFabrikalar.Items.AddRange(fabrikaIsimleri);

            gvTesisler.MultiSelect = false;
            gvTesisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvTesisler.ReadOnly = true;
            gvTesisler.ColumnHeadersVisible = false;
            gvTesisler.RowHeadersVisible = false;
        }

        private string[] fabrikaGetir()
        {
            DataTable datatable = new DataTable();
            
            veritabaniBaglanti.ConnectionString = connString;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Fabrika";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {

                datatable.Load(veritabaniKomut.ExecuteReader());
            }
            veritabaniBaglanti.Close();

            var stringarr = datatable.AsEnumerable().Select(row => row.Field<string>("fabrikaAdi")).ToArray();

            return stringarr;
        }

        private void btnTesisEkle_Click(object sender, EventArgs e)
        {
            if (txtYeniTesisAdi.Text != "")
            {
                string seciliFabrikaAdi = cmbKayitliFabrikalar.SelectedItem.ToString();

                veritabaniBaglanti.ConnectionString = connString;

                veritabaniBaglanti.Open();

                string sorgu = "INSERT INTO Tesis (fabrikaID,tesisAdi) VALUES ((SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi),@tesisAdi)";

                using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
                {
                    veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", seciliFabrikaAdi);
                    veritabaniKomut.Parameters.AddWithValue("@tesisAdi", txtYeniTesisAdi.Text);

                    veritabaniKomut.ExecuteNonQuery();
                }

                veritabaniBaglanti.Close();

                tesisGetir(seciliFabrikaAdi);

                txtYeniTesisAdi.Clear();
            }
            else
            {
                MessageBox.Show("Yeni tesis adı giriniz!");
            }
        }

        private void btnFabrikaSil_Click(object sender, EventArgs e)
        {

        }

        private void btnTesisGüncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
