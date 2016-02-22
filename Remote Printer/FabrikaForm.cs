﻿using System;
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
    public partial class FabrikaForm : Form
    {
        /* Veritabanı bağlantı değişkenleri ve bağlantı cümlesi tanımlanıyor.*/
        private SQLiteConnection veritabaniBaglanti = new SQLiteConnection();
        private SQLiteCommand veritabaniKomut;

        string connString = "Data Source=D:\\RemotePrinter\\Remote Printer\\Database\\remotePrinter.db";


        public FabrikaForm()
        {
            InitializeComponent();
        }

        private void FabrikaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen; 
            
            btnFabrikaSil.Enabled = false;
            btnFabrikaGuncelle.Enabled = false;

            gvKayitliFabrikalar.MultiSelect = false;
            gvKayitliFabrikalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvKayitliFabrikalar.ReadOnly = true;



            gvKayitliFabrikalar.RowHeadersVisible = false;

            gvKayitliFabrikalar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvKayitliFabrikalar.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gvKayitliFabrikalar.AllowUserToAddRows = false;
            gvKayitliFabrikalar.AllowUserToDeleteRows = false;
            gvKayitliFabrikalar.AllowUserToResizeRows = false;

            gvKayitliFabrikalar.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            gvKayitliFabrikalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvKayitliFabrikalar.CellBorderStyle = DataGridViewCellBorderStyle.Single;


            gvKayitliFabrikalar.ColumnHeadersVisible = false;

            //gvKayitliFabrikalar.Dock = DockStyle.Fill;

            fabrikaGetir();
        }

        private void btnFabrikaEkle_Click(object sender, EventArgs e)
        {
            if (this.txtYeniFabrikaAdi.Text != "")
            {
                veritabaniBaglanti.ConnectionString = connString;

                veritabaniBaglanti.Open();

                string sorgu = "INSERT INTO Fabrika (FabrikaAdi) VALUES (@yeniFabrika)";

                using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
                {
                    veritabaniKomut.Parameters.AddWithValue("@yeniFabrika", this.txtYeniFabrikaAdi.Text);

                    veritabaniKomut.ExecuteNonQuery();
                }

                veritabaniBaglanti.Close();

                this.txtYeniFabrikaAdi.Clear();

                fabrikaGetir();
            }
            else
            {
                MessageBox.Show("Yeni fabrika ismi giriniz!");
            }
        }

        private void btnFabrikaSil_Click(object sender, EventArgs e)
        {

            int fabrikaID;

            if (gvKayitliFabrikalar.CurrentCell.RowIndex == null)
            {
                return;
            }
            else
            {
                int SeciliIndeks = gvKayitliFabrikalar.CurrentCell.RowIndex;

                if (SeciliIndeks >= 0 || SeciliIndeks != null)
                {
                    int.TryParse(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaID"].Value.ToString(), out fabrikaID);
                    //MessageBox.Show(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaAdi"].Value.ToString());
                    veritabaniBaglanti.ConnectionString = connString;

                    veritabaniBaglanti.Open();

                    string sorgu = "DELETE FROM Fabrika WHERE fabrikaID = @silinecekFabrika";

                    using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
                    {
                        veritabaniKomut.Parameters.AddWithValue("@silinecekFabrika", fabrikaID);

                        veritabaniKomut.ExecuteNonQuery();
                    }

                    veritabaniBaglanti.Close();

                    fabrikaGetir();
                }
                else
                {
                    MessageBox.Show("Listeden fabrika seçiniz!");
                }


            }
        }

        private void gvKayitliFabrikalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelFabrikaAdi.Text = gvKayitliFabrikalar.Rows[e.RowIndex].Cells["fabrikaAdi"].Value.ToString();
            btnFabrikaGuncelle.Enabled = true;
            btnFabrikaSil.Enabled = true;
        }

        private void btnFabrikaGuncelle_Click(object sender, EventArgs e)
        {
            int SeciliIndeks = gvKayitliFabrikalar.CurrentCell.RowIndex;
            int fabrikaID;
            int.TryParse(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaID"].Value.ToString(), out fabrikaID);
   
            if (txtGuncelFabrikaAdi.Text != "")
            {
                veritabaniBaglanti.ConnectionString = connString;

                veritabaniBaglanti.Open();

                string sorgu = "UPDATE Fabrika SET FabrikaAdi=@guncelFabrika WHERE fabrikaID=@fabrikaID";

                using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
                {
                    veritabaniKomut.Parameters.AddWithValue("@guncelFabrika", this.txtGuncelFabrikaAdi.Text);
                    veritabaniKomut.Parameters.AddWithValue("@fabrikaID", fabrikaID);

                    veritabaniKomut.ExecuteNonQuery();
                }

                veritabaniBaglanti.Close();

                fabrikaGetir();
            }
            else
            {
                MessageBox.Show("Güncel fabrika ismi giriniz!");
            }
        }

        /*
         * Fabrika metin kutusuna girili fabrikayı veritabanına kaydeder.
         */
        private void fabrikaGetir()
        {
            veritabaniBaglanti.ConnectionString = connString;

            veritabaniBaglanti.Open();

            string sorgu = "SELECT fabrikaAdi FROM Fabrika";

            using (veritabaniKomut = new SQLiteCommand(sorgu, veritabaniBaglanti))
            {
                DataTable datatable = new DataTable();
                datatable.Load(veritabaniKomut.ExecuteReader());

                //gvKayitliFabrikalar.Columns[0].HeaderText = "Fabrika Adı";
                gvKayitliFabrikalar.DataSource = datatable;
            }
            veritabaniBaglanti.Close();



        }
    }
}