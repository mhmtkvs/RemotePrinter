using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Remote_Printer;


namespace Remote_Printer
{
    public partial class FabrikaForm : Form
    {
        veritabaniOperasyon veriOperasyon = new veritabaniOperasyon();

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

            // Datagridview özelliklerini ayarla.
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
            gvKayitliFabrikalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvKayitliFabrikalar.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            gvKayitliFabrikalar.ColumnHeadersVisible = false;

            //fabrikaGetir();

            veriOperasyon.fabrikaGetir(gvKayitliFabrikalar);
        }

        private void btnFabrikaEkle_Click(object sender, EventArgs e)
        {
            // fabrika isminin boş kontrolü yapılıyor.
            if (this.txtYeniFabrikaAdi.Text != "")
            {
                // fabrika isminin kayıt kontrolü yapılıyor.
                if (veriOperasyon.fabrikaMevcut(this.txtYeniFabrikaAdi.Text) == false)
                {

                    veriOperasyon.fabrikaEkle(this.txtYeniFabrikaAdi.Text);

                    this.txtYeniFabrikaAdi.Clear();

                    veriOperasyon.fabrikaGetir(gvKayitliFabrikalar);
                }
                else
                {
                    MessageBox.Show("Fabrika zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Yeni fabrika ismi giriniz!");
            }

        }

        private void btnFabrikaSil_Click(object sender, EventArgs e)
        {
            int seciliIndeks = gvKayitliFabrikalar.CurrentCell.RowIndex;

            if (seciliIndeks >= 0)
            {

                DialogResult uyariPenceresi = MessageBox.Show("Silmek istediğiniz fabrikaya ait tesis, bant ve yazıcı bilgileri de silinecektir. Onaylıyor musunuz?","UYARI!",MessageBoxButtons.YesNo);

                if (uyariPenceresi == DialogResult.Yes)
                {
                    //MessageBox.Show(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaAdi"].Value.ToString());
                    veriOperasyon.fabrikaSil(seciliIndeks);

                    veriOperasyon.fabrikaGetir(gvKayitliFabrikalar);

                    // Veritabanında kayıtlı fabrika kalmadı ise Sil ve Güncelle butonlarını pasif yap.
                    if (gvKayitliFabrikalar.RowCount == 0)
                    {
                        btnFabrikaSil.Enabled = false;
                        btnFabrikaGuncelle.Enabled = false;
                    }
                }
                else if (uyariPenceresi == DialogResult.No)
                {
 
                }
            }
            else
            {
                MessageBox.Show("Listeden fabrika seçiniz!");
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

            //int.TryParse(gvKayitliFabrikalar.Rows[SeciliIndeks].Cells["fabrikaID"].Value.ToString(), out fabrikaID);
   
            if (this.txtGuncelFabrikaAdi.Text != "")
            {
                if (veriOperasyon.fabrikaMevcut(this.txtGuncelFabrikaAdi.Text) == false)
                {

                    veriOperasyon.fabrikaGuncelle(SeciliIndeks, this.txtGuncelFabrikaAdi.Text);
                    veriOperasyon.fabrikaGetir(gvKayitliFabrikalar);
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemiyor. Fabrika ismi zaten kayıtlı!");
                }
            }
            else
            {
                MessageBox.Show("Güncel fabrika ismi giriniz!");
            }
        }
    }
}
