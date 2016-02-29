namespace Remote_Printer
{
    partial class BantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYeniBantAdi = new System.Windows.Forms.Label();
            this.lblGuncelBantAdi = new System.Windows.Forms.Label();
            this.txtYeniBantAdi = new System.Windows.Forms.TextBox();
            this.txtGuncelBantAdi = new System.Windows.Forms.TextBox();
            this.btnBantGuncelle = new System.Windows.Forms.Button();
            this.btnBantEkle = new System.Windows.Forms.Button();
            this.btnBantSil = new System.Windows.Forms.Button();
            this.lblKayitliTesisler = new System.Windows.Forms.Label();
            this.cmbKayitliTesisler = new System.Windows.Forms.ComboBox();
            this.lblKayitliBantlar = new System.Windows.Forms.Label();
            this.gvBantlar = new System.Windows.Forms.DataGridView();
            this.lblKayitliFabrikalar = new System.Windows.Forms.Label();
            this.cmbKayitliFabrikalar = new System.Windows.Forms.ComboBox();
            this.txtGuncelKanalSayisi = new System.Windows.Forms.TextBox();
            this.txtYeniBantSayisi = new System.Windows.Forms.TextBox();
            this.lblGuncelKanalSayisi = new System.Windows.Forms.Label();
            this.lblYeniBantSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBantlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYeniBantAdi
            // 
            this.lblYeniBantAdi.AutoSize = true;
            this.lblYeniBantAdi.Location = new System.Drawing.Point(12, 389);
            this.lblYeniBantAdi.Name = "lblYeniBantAdi";
            this.lblYeniBantAdi.Size = new System.Drawing.Size(107, 13);
            this.lblYeniBantAdi.TabIndex = 27;
            this.lblYeniBantAdi.Text = "Yeni bant adı giriniz...";
            this.lblYeniBantAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuncelBantAdi
            // 
            this.lblGuncelBantAdi.AutoSize = true;
            this.lblGuncelBantAdi.Location = new System.Drawing.Point(12, 292);
            this.lblGuncelBantAdi.Name = "lblGuncelBantAdi";
            this.lblGuncelBantAdi.Size = new System.Drawing.Size(120, 13);
            this.lblGuncelBantAdi.TabIndex = 26;
            this.lblGuncelBantAdi.Text = "Güncel bant adı giriniz...";
            // 
            // txtYeniBantAdi
            // 
            this.txtYeniBantAdi.Location = new System.Drawing.Point(12, 405);
            this.txtYeniBantAdi.Name = "txtYeniBantAdi";
            this.txtYeniBantAdi.Size = new System.Drawing.Size(120, 20);
            this.txtYeniBantAdi.TabIndex = 25;
            // 
            // txtGuncelBantAdi
            // 
            this.txtGuncelBantAdi.Location = new System.Drawing.Point(15, 308);
            this.txtGuncelBantAdi.Name = "txtGuncelBantAdi";
            this.txtGuncelBantAdi.Size = new System.Drawing.Size(120, 20);
            this.txtGuncelBantAdi.TabIndex = 24;
            // 
            // btnBantGuncelle
            // 
            this.btnBantGuncelle.Location = new System.Drawing.Point(141, 345);
            this.btnBantGuncelle.Name = "btnBantGuncelle";
            this.btnBantGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnBantGuncelle.TabIndex = 23;
            this.btnBantGuncelle.Text = "Güncelle";
            this.btnBantGuncelle.UseVisualStyleBackColor = true;
            this.btnBantGuncelle.Click += new System.EventHandler(this.btnBantGuncelle_Click);
            // 
            // btnBantEkle
            // 
            this.btnBantEkle.Location = new System.Drawing.Point(141, 442);
            this.btnBantEkle.Name = "btnBantEkle";
            this.btnBantEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBantEkle.TabIndex = 22;
            this.btnBantEkle.Text = "Ekle";
            this.btnBantEkle.UseVisualStyleBackColor = true;
            this.btnBantEkle.Click += new System.EventHandler(this.btnBantEkle_Click);
            // 
            // btnBantSil
            // 
            this.btnBantSil.Location = new System.Drawing.Point(141, 261);
            this.btnBantSil.Name = "btnBantSil";
            this.btnBantSil.Size = new System.Drawing.Size(75, 23);
            this.btnBantSil.TabIndex = 21;
            this.btnBantSil.Text = "Kayıt Sil";
            this.btnBantSil.UseVisualStyleBackColor = true;
            this.btnBantSil.Click += new System.EventHandler(this.btnBantSil_Click);
            // 
            // lblKayitliTesisler
            // 
            this.lblKayitliTesisler.AutoSize = true;
            this.lblKayitliTesisler.Location = new System.Drawing.Point(12, 49);
            this.lblKayitliTesisler.Name = "lblKayitliTesisler";
            this.lblKayitliTesisler.Size = new System.Drawing.Size(78, 13);
            this.lblKayitliTesisler.TabIndex = 20;
            this.lblKayitliTesisler.Text = "Tesis Seçiniz...";
            // 
            // cmbKayitliTesisler
            // 
            this.cmbKayitliTesisler.FormattingEnabled = true;
            this.cmbKayitliTesisler.Location = new System.Drawing.Point(15, 65);
            this.cmbKayitliTesisler.Name = "cmbKayitliTesisler";
            this.cmbKayitliTesisler.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliTesisler.TabIndex = 19;
            this.cmbKayitliTesisler.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliTesisler_SelectedIndexChanged);
            // 
            // lblKayitliBantlar
            // 
            this.lblKayitliBantlar.AutoSize = true;
            this.lblKayitliBantlar.Location = new System.Drawing.Point(12, 89);
            this.lblKayitliBantlar.Name = "lblKayitliBantlar";
            this.lblKayitliBantlar.Size = new System.Drawing.Size(104, 13);
            this.lblKayitliBantlar.TabIndex = 18;
            this.lblKayitliBantlar.Text = "Tesise Kayıtlı Bantlar";
            // 
            // gvBantlar
            // 
            this.gvBantlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBantlar.Location = new System.Drawing.Point(15, 105);
            this.gvBantlar.Name = "gvBantlar";
            this.gvBantlar.Size = new System.Drawing.Size(201, 150);
            this.gvBantlar.TabIndex = 17;
            this.gvBantlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBantlar_CellContentClick);
            // 
            // lblKayitliFabrikalar
            // 
            this.lblKayitliFabrikalar.AutoSize = true;
            this.lblKayitliFabrikalar.Location = new System.Drawing.Point(12, 9);
            this.lblKayitliFabrikalar.Name = "lblKayitliFabrikalar";
            this.lblKayitliFabrikalar.Size = new System.Drawing.Size(88, 13);
            this.lblKayitliFabrikalar.TabIndex = 29;
            this.lblKayitliFabrikalar.Text = "Fabrika Seçiniz...";
            // 
            // cmbKayitliFabrikalar
            // 
            this.cmbKayitliFabrikalar.FormattingEnabled = true;
            this.cmbKayitliFabrikalar.Location = new System.Drawing.Point(15, 25);
            this.cmbKayitliFabrikalar.Name = "cmbKayitliFabrikalar";
            this.cmbKayitliFabrikalar.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliFabrikalar.TabIndex = 28;
            this.cmbKayitliFabrikalar.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliFabrikalar_SelectedIndexChanged);
            // 
            // txtGuncelKanalSayisi
            // 
            this.txtGuncelKanalSayisi.Location = new System.Drawing.Point(15, 347);
            this.txtGuncelKanalSayisi.Name = "txtGuncelKanalSayisi";
            this.txtGuncelKanalSayisi.Size = new System.Drawing.Size(120, 20);
            this.txtGuncelKanalSayisi.TabIndex = 30;
            // 
            // txtYeniBantSayisi
            // 
            this.txtYeniBantSayisi.Location = new System.Drawing.Point(12, 444);
            this.txtYeniBantSayisi.Name = "txtYeniBantSayisi";
            this.txtYeniBantSayisi.Size = new System.Drawing.Size(120, 20);
            this.txtYeniBantSayisi.TabIndex = 31;
            // 
            // lblGuncelKanalSayisi
            // 
            this.lblGuncelKanalSayisi.AutoSize = true;
            this.lblGuncelKanalSayisi.Location = new System.Drawing.Point(12, 331);
            this.lblGuncelKanalSayisi.Name = "lblGuncelKanalSayisi";
            this.lblGuncelKanalSayisi.Size = new System.Drawing.Size(136, 13);
            this.lblGuncelKanalSayisi.TabIndex = 32;
            this.lblGuncelKanalSayisi.Text = "Güncel kanal sayısı giriniz...";
            // 
            // lblYeniBantSayisi
            // 
            this.lblYeniBantSayisi.AutoSize = true;
            this.lblYeniBantSayisi.Location = new System.Drawing.Point(12, 428);
            this.lblYeniBantSayisi.Name = "lblYeniBantSayisi";
            this.lblYeniBantSayisi.Size = new System.Drawing.Size(123, 13);
            this.lblYeniBantSayisi.TabIndex = 33;
            this.lblYeniBantSayisi.Text = "Yeni kanal sayısı giriniz...";
            this.lblYeniBantSayisi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 476);
            this.Controls.Add(this.lblYeniBantSayisi);
            this.Controls.Add(this.lblGuncelKanalSayisi);
            this.Controls.Add(this.txtYeniBantSayisi);
            this.Controls.Add(this.txtGuncelKanalSayisi);
            this.Controls.Add(this.lblKayitliFabrikalar);
            this.Controls.Add(this.cmbKayitliFabrikalar);
            this.Controls.Add(this.lblYeniBantAdi);
            this.Controls.Add(this.lblGuncelBantAdi);
            this.Controls.Add(this.txtYeniBantAdi);
            this.Controls.Add(this.txtGuncelBantAdi);
            this.Controls.Add(this.btnBantGuncelle);
            this.Controls.Add(this.btnBantEkle);
            this.Controls.Add(this.btnBantSil);
            this.Controls.Add(this.lblKayitliTesisler);
            this.Controls.Add(this.cmbKayitliTesisler);
            this.Controls.Add(this.lblKayitliBantlar);
            this.Controls.Add(this.gvBantlar);
            this.Name = "BantForm";
            this.Text = "Bant İşlemleri";
            this.Load += new System.EventHandler(this.BantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBantlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYeniBantAdi;
        private System.Windows.Forms.Label lblGuncelBantAdi;
        private System.Windows.Forms.TextBox txtYeniBantAdi;
        private System.Windows.Forms.TextBox txtGuncelBantAdi;
        private System.Windows.Forms.Button btnBantGuncelle;
        private System.Windows.Forms.Button btnBantEkle;
        private System.Windows.Forms.Button btnBantSil;
        private System.Windows.Forms.Label lblKayitliTesisler;
        private System.Windows.Forms.ComboBox cmbKayitliTesisler;
        private System.Windows.Forms.Label lblKayitliBantlar;
        private System.Windows.Forms.DataGridView gvBantlar;
        private System.Windows.Forms.Label lblKayitliFabrikalar;
        private System.Windows.Forms.ComboBox cmbKayitliFabrikalar;
        private System.Windows.Forms.TextBox txtGuncelKanalSayisi;
        private System.Windows.Forms.TextBox txtYeniBantSayisi;
        private System.Windows.Forms.Label lblGuncelKanalSayisi;
        private System.Windows.Forms.Label lblYeniBantSayisi;
    }
}