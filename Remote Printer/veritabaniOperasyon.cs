﻿using System;
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
        public void tesisGetir(string _fabrikaAdi, DataGridView _tesisler)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT tesisAdi FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", _fabrikaAdi);

                DataTable datatable = new DataTable();
                datatable.Load(veritabaniKomut.ExecuteReader());
                _tesisler.DataSource = datatable;
            }
            veritabaniBaglanti.Close();
        }
        
        public string[] tesisGetir(string fabrikaAdi)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT tesisAdi FROM Tesis WHERE fabrikaID = (SELECT fabrikaID FROM Fabrika WHERE fabrikaAdi = @fabrikaAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@fabrikaAdi", fabrikaAdi);
                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            veritabaniBaglanti.Close();

            var stringarr = datatable.AsEnumerable().Select(row => row.Field<string>("tesisAdi")).ToArray();

            return stringarr;
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

        public void bantGetir(string _fabrikaAdi, string _tesisAdi, DataGridView _bantlar)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT bantAdi,kanalSayisi FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi) AND tesisAdi = @seciliTesisAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesisAdi", _tesisAdi);

                DataTable datatable = new DataTable();
                datatable.Load(veritabaniKomut.ExecuteReader());
                _bantlar.DataSource = datatable;
            }
            veritabaniBaglanti.Close();
        }

        public string[] bantGetir(string _fabrikaAdi, string _tesisAdi)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            DataTable datatable = new DataTable();

            string sorgu = "SELECT bantAdi FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi) AND tesisAdi = @seciliTesisAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesisAdi", _tesisAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }
            veritabaniBaglanti.Close();

            var stringarr = datatable.AsEnumerable().Select(row => row.Field<string>("bantAdi")).ToArray();

            return stringarr;
 
        }

        public bool bantMevcut(string _fabrikaAdi, string _tesisAdi, string _eklenecekBant)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT bantAdi,kanalSayisi FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi) AND tesisAdi = @seciliTesisAdi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesisAdi", _tesisAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }
            veritabaniBaglanti.Close();

            var bantAdlari = datatable.AsEnumerable().Select(row => row.Field<string>("bantAdi")).ToArray();
            //var kanalSayilari = datatable.AsEnumerable().Select(row => row.Field<string>("kanalSayisi")).ToArray();

            bool bantAdiMevcut = bantAdlari.Contains(_eklenecekBant);

            return bantAdlari.Contains(_eklenecekBant);
        }

        public void bantEkle(string _fabrikaAdi, string _tesisAdi, string _yeniBantAdi, string _yeniKanalSayisi)
        {

            //MessageBox.Show(_fabrikaAdi + " " + _tesisAdi + " " + _yeniBantAdi + " " + _yeniKanalSayisi);

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "INSERT INTO Bant (tesisID,bantAdi,kanalSayisi) VALUES ((SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi) AND tesisAdi = @seciliTesisAdi),@yeniBantAdi,@yeniKanalSayisi)";
            
            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesisAdi", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@yeniBantAdi", _yeniBantAdi);
                veritabaniKomut.Parameters.AddWithValue("@yeniKanalSayisi", _yeniKanalSayisi);

                veritabaniKomut.ExecuteNonQuery();
            }
            veritabaniBaglanti.Close();
        }

        public void bantGuncelle(int _bantIndeks, string _seciliFabrika, string _seciliTesis, string _guncelBantAdi, string _guncelKanalSayisi)
        {
            int tesisID;
            int bantID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi) AND tesisAdi = @seciliTesisAdi)";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _seciliFabrika);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesisAdi", _seciliTesis);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_bantIndeks]["tesisID"].ToString(), out tesisID);
            int.TryParse(datatable.Rows[_bantIndeks]["bantID"].ToString(), out bantID);

            sorgu = "UPDATE Bant SET bantAdi=@guncelBant, kanalSayisi=@guncelKanalSayisi WHERE bantID=@bantID AND tesisID=@tesisID";
            
            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@guncelBant", _guncelBantAdi);
                veritabaniKomut.Parameters.AddWithValue("@guncelKanalSayisi", _guncelKanalSayisi);
                veritabaniKomut.Parameters.AddWithValue("@bantID", bantID);
                veritabaniKomut.Parameters.AddWithValue("@tesisID", tesisID);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

        public void bantSil(int _bantIndeks, string _seciliFabrika, string _seciliTesis)
        {
            int tesisID;
            int bantID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrikaAdi) AND tesisAdi = @seciliTesisAdi)";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrikaAdi", _seciliFabrika);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesisAdi", _seciliTesis);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_bantIndeks]["tesisID"].ToString(), out tesisID);
            int.TryParse(datatable.Rows[_bantIndeks]["bantID"].ToString(), out bantID);

            sorgu = "DELETE FROM Bant WHERE tesisID = @tesisID AND bantID = @silinecekBantID";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@tesisID", tesisID);
                veritabaniKomut.Parameters.AddWithValue("@silinecekBantID", bantID);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }

        public void yaziciGetir(string _fabrikaAdi, string _tesisAdi, string _bantAdi, DataGridView _yazicilar)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT yaziciAdi,ipAdres,portNo,comID FROM Yazici WHERE bantID = (SELECT bantID FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrika) AND tesisAdi = @seciliTesis) AND bantAdi = @seciliBant)";
            
            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);

                DataTable datatable = new DataTable();

                datatable.Load(veritabaniKomut.ExecuteReader());
                
                _yazicilar.DataSource = datatable;
            }
            veritabaniBaglanti.Close();
        }

        public string[] yaziciGetir(string _fabrikaAdi, string _tesisAdi, string _bantAdi)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT yaziciAdi,ipAdres,portNo,comID,yaziciTipi FROM Yazici WHERE bantID = (SELECT bantID FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrika) AND tesisAdi = @seciliTesis) AND bantAdi = @seciliBant)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);



                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            veritabaniBaglanti.Close();

            var stringarr = datatable.AsEnumerable().Select(row => row.Field<string>("YaziciAdi")).ToArray();

            return stringarr;
        }

        public DataTable yaziciTablosuGetir()
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Yazici";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                //veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                //veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                //veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);
                
                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            veritabaniBaglanti.Close();

            return datatable;
        }

        public int yaziciIDGetir(string _yaziciAdi)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT yaziciID FROM Yazici WHERE yaziciAdi = @yaziciAdi";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@yaziciAdi", _yaziciAdi);
                //veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                //veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            veritabaniBaglanti.Close();

            return Convert.ToInt32(datatable.Rows[0]["yaziciID"]);
        }

        public bool yaziciMevcut(string _fabrikaAdi, string _tesisAdi, string _BantAdi, string _eklenecekYazici)
        {
            DataTable datatable = new DataTable();

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT yaziciAdi FROM Yazici WHERE bantID = (SELECT bantID FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrika) AND tesisAdi = @seciliTesis) AND bantAdi = @seciliBant)";
            
            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliBant", _BantAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }
            veritabaniBaglanti.Close();

            var yaziciAdlari = datatable.AsEnumerable().Select(row => row.Field<string>("yaziciAdi")).ToArray();

            return yaziciAdlari.Contains(_eklenecekYazici);
        }

        public void yaziciEkle(string _fabrikaAdi,
                               string _tesisAdi,
                               string _bantAdi,
                               string _yeniYaziciAdi,
                               string _yeniIPAdres,
                               string _yeniPortNo,
                               string _yeniCOMID,
                                int _yeniYaziciTipi)
        {
            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "INSERT INTO Yazici (bantID,yaziciAdi,ipAdres,portNo,comID,yaziciTipi) VALUES ((SELECT bantID FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrika) AND tesisAdi = @seciliTesis) AND bantAdi = @seciliBant),@yaziciAdi, @ipAdres, @portNo, @comID, @yaziciTipi)";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);
                veritabaniKomut.Parameters.AddWithValue("@yaziciAdi", _yeniYaziciAdi);
                veritabaniKomut.Parameters.AddWithValue("@ipAdres", _yeniIPAdres);
                veritabaniKomut.Parameters.AddWithValue("@portNo", _yeniPortNo);
                veritabaniKomut.Parameters.AddWithValue("@comID", _yeniCOMID);
                veritabaniKomut.Parameters.AddWithValue("@yaziciTipi", _yeniYaziciTipi);
                
                veritabaniKomut.ExecuteNonQuery();
            }
            veritabaniBaglanti.Close();
        }


        public void yaziciGuncelle(int _yaziciIndeks,
                                   string _fabrikaAdi,
                                   string _tesisAdi,
                                   string _bantAdi,
                                   string _yeniYaziciAdi,
                                   string _yeniIPAdres,
                                   string _yeniPortNo,
                                   string _yeniCOMID,
                                    int _yeniYaziciTipi)
        {
            int bantID;
            int yaziciID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Yazici WHERE bantID = (SELECT bantID FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrika) AND tesisAdi = @seciliTesis) AND bantAdi = @seciliBant)";
          
            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_yaziciIndeks]["bantID"].ToString(), out bantID);
            int.TryParse(datatable.Rows[_yaziciIndeks]["yaziciID"].ToString(), out yaziciID);

            sorgu = "UPDATE Yazici SET yaziciAdi=@yaziciAdi, ipAdres = @ipAdres, portNo = @portNo, comID = @comID, yaziciTipi = @yaziciTipi WHERE yaziciID=@yaziciID AND bantID=@bantID";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@yaziciAdi", _yeniYaziciAdi);
                veritabaniKomut.Parameters.AddWithValue("@ipAdres", _yeniIPAdres);
                veritabaniKomut.Parameters.AddWithValue("@portNo", _yeniPortNo);
                veritabaniKomut.Parameters.AddWithValue("@comID", _yeniCOMID);
                veritabaniKomut.Parameters.AddWithValue("@yaziciID", yaziciID);
                veritabaniKomut.Parameters.AddWithValue("@bantID", bantID);
                veritabaniKomut.Parameters.AddWithValue("@yaziciTipi", _yeniYaziciTipi);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }
        
        public void yaziciSil(int _yaziciIndeks,
                              string _fabrikaAdi,
                              string _tesisAdi,
                              string _bantAdi)
        {
            int bantID;
            int yaziciID;

            veritabaniBaglanti.ConnectionString = baglantiCumlesi;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT * FROM Yazici WHERE bantID = (SELECT bantID FROM Bant WHERE tesisID = (SELECT tesisID FROM Tesis WHERE fabrikaID = (SELECT fabrikaID from Fabrika WHERE fabrikaAdi = @seciliFabrika) AND tesisAdi = @seciliTesis) AND bantAdi = @seciliBant)";

            DataTable datatable = new DataTable();

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@seciliFabrika", _fabrikaAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliTesis", _tesisAdi);
                veritabaniKomut.Parameters.AddWithValue("@seciliBant", _bantAdi);

                datatable.Load(veritabaniKomut.ExecuteReader());
            }

            int.TryParse(datatable.Rows[_yaziciIndeks]["bantID"].ToString(), out bantID);
            int.TryParse(datatable.Rows[_yaziciIndeks]["yaziciID"].ToString(), out yaziciID);

            sorgu = "DELETE FROM Yazici WHERE bantID = @bantID AND yaziciID = @silinecekyaziciID";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                veritabaniKomut.Parameters.AddWithValue("@bantID", bantID);
                veritabaniKomut.Parameters.AddWithValue("@silinecekyaziciID", yaziciID);

                veritabaniKomut.ExecuteNonQuery();
            }

            veritabaniBaglanti.Close();
        }
    }
}
