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

        private SQLiteConnection veritabaniBaglanti;
        private SQLiteCommand veritabaniKomut;
        private SQLiteDataReader veritabaniOkuyucu;
        string connString = "Data Source=D:\\Remote-Printer\\RemotePrinter\\Remote Printer\\Database\\remotePrinter.db";

        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string dosyayolu = Application.ExecutablePath.ToString();
            //fabrikaGetir();


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

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client servis = new ServiceReference1.Service1Client();

            string returnString;

            returnString = servis.GetData(txtService.Text);

            MessageBox.Show(returnString);

        }



        




    }
}
