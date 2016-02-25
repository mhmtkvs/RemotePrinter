using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Remote_Printer
{
    class veritabaniOperasyon
    {
        /* Veritabanı bağlantı değişkenleri ve bağlantı cümlesi tanımlanıyor.*/
        private SQLiteConnection veritabaniBaglanti = new SQLiteConnection();
        private SQLiteCommand veritabaniKomut;

        private string baglantiCumlesi;


        public veritabaniOperasyon()
        {
            this.baglantiCumlesi = "Data Source=D:\\RemotePrinter\\Remote Printer\\Database\\remotePrinter.db";
        }

        public veritabaniOperasyon(string _baglantiCumlesi)
        {
            if (_baglantiCumlesi != "")
            {
                this.baglantiCumlesi = _baglantiCumlesi;
            }
            else
            {
                this.baglantiCumlesi = "Data Source=D:\\RemotePrinter\\Remote Printer\\Database\\remotePrinter.db";
            }
        }

        public void fabrikaGetir(DataGridView _fabrikalar)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;
            veritabaniBaglanti.Open();

            string sorgu = "SELECT fabrikaAdi FROM Fabrika";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                datatable.Load(veritabaniKomut.ExecuteReader());
                _fabrikalar.DataSource = datatable;
            }
            veritabaniBaglanti.Close();
        }

        public string[] fabrikaGetir()
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

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

        public void fabrikaEkle(string _yeniFabrikaAdi)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "INSERT INTO Fabrika (FabrikaAdi) VALUES (@yeniFabrika)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@yeniFabrika", _yeniFabrikaAdi);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

        public void fabrikaSil(int _fabrikaIndeks)
        {
            int fabrikaID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Fabrika";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_fabrikaIndeks]["fabrikaID"].ToString(), out fabrikaID);

            sorgu = "DELETE FROM Fabrika WHERE fabrikaID = @silinecekFabrika";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@silinecekFabrika", fabrikaID);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

        public void fabrikaGuncelle(int _fabrikaIndeks, string _guncelFabrikaAdi)
        {
            int fabrikaID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            // fabrika ismine göre fabrika id bulunuyor.
            string sorgu = "SELECT * FROM Fabrika";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_fabrikaIndeks]["fabrikaID"].ToString(), out fabrikaID);

            //MessageBox.Show(fabrikaID.ToString());

            // fabrika id ye göre fabrika adi güncelleniyor.
            sorgu = "UPDATE Fabrika SET FabrikaAdi=@guncelFabrika WHERE fabrikaID=@fabrikaID";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@guncelFabrika", _guncelFabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@fabrikaID", fabrikaID);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }
        /*
 * Veritabanına kayıtlı fabrikalar içerisinde arama yapar.**/
        public bool fabrikaMevcut(string fabrikaAdi)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT fabrikaAdi FROM Fabrika";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {

                datatable.Load(veritabaniKomut.ExecuteReader());
            }
            veritabaniBaglanti.Close();

            var fabrikaAdlari = datatable.AsEnumerable().Select(row => row.Field<string>("fabrikaAdi")).ToArray();

            return fabrikaAdlari.Contains(fabrikaAdi);
        }

        /*
 * Veritabanından tesis isimlerini getirir.
 * */
        public void tesisGetir(string fabrikaAdi, DataGridView _tesisler)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT tesisAdi FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", fabrikaAdi);

                DataTable datatable = new DataTable();
                datatable.Load(veritabaniKomut.ExecuteReader());
                _tesisler.DataSource = datatable;
            }
            veritabaniBaglanti.Close();
        }


        public bool tesisMevcut(string _tesisAdi, string _seciliFabrikaAdi)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT tesisAdi FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _seciliFabrikaAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }
            veritabaniBaglanti.Close();

            var tesisAdlari = datatable.AsEnumerable().Select(row => row.Field<string>("tesisAdi")).ToArray();

            return tesisAdlari.Contains(_tesisAdi);
        }

        public void tesisEkle(string _yeniTesisAdi, string _eklenecekFabrika)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "INSERT INTO Tesis (fabrikaID,tesisAdi) VALUES ((SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi),@tesisAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", _eklenecekFabrika);
                veritabaniKomut.Parameters.AddWithValue("@tesisAdi", _yeniTesisAdi);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

        public void tesisSil(int _tesisIndeks, string _seciliFabrika)
        {
            int fabrikaID;
            int tesisID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi)";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", _seciliFabrika);
                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_tesisIndeks]["fabrikaID"].ToString(), out fabrikaID);
            int.TryParse(datatable.Rows[_tesisIndeks]["tesisID"].ToString(), out tesisID);

            //MessageBox.Show(fabrikaID.ToString() + " " + tesisID.ToString());

            sorgu = "DELETE FROM Tesis WHERE fabrikaID = @fabrikaID AND tesisID = @silinecekTesisID";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaID", fabrikaID);
                veritabaniKomut.Parameters.AddWithValue("@silinecekTesisID", tesisID);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

        public void tesisGuncelle(int _tesisIndeks, string _seciliFabrika, string _guncelTesisAdi)
        {
            int fabrikaID;
            int tesisID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi)";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", _seciliFabrika);
                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_tesisIndeks]["fabrikaID"].ToString(), out fabrikaID);
            int.TryParse(datatable.Rows[_tesisIndeks]["tesisID"].ToString(), out tesisID);

            //MessageBox.Show(fabrikaID.ToString() + " " + tesisID.ToString());

            sorgu = "UPDATE Tesis SET TesisAdi=@guncelTesis WHERE fabrikaID=@fabrikaID AND tesisID=@tesisID";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaID", fabrikaID);
                veritabaniKomut.Parameters.AddWithValue("@tesisID", tesisID);
                veritabaniKomut.Parameters.AddWithValue("@guncelTesis", _guncelTesisAdi);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

    }
}
