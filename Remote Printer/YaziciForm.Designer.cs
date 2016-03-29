namespace Remote_Printer
{
    partial class YaziciForm
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
            this.lblTesisler = new System.Windows.Forms.Label();
            this.cmbKayitliTesis = new System.Windows.Forms.ComboBox();
            this.lblGuncelYaziciAdi = new System.Windows.Forms.Label();
            this.txtGuncelYaziciAdi = new System.Windows.Forms.TextBox();
            this.btnYaziciGuncelle = new System.Windows.Forms.Button();
            this.btnYaziciSil = new System.Windows.Forms.Button();
            this.lblBantlar = new System.Windows.Forms.Label();
            this.cmbKayitliBant = new System.Windows.Forms.ComboBox();
            this.lblKayitliYazicilar = new System.Windows.Forms.Label();
            this.gvYazicilar = new System.Windows.Forms.DataGridView();
            this.lblFabrikalar = new System.Windows.Forms.Label();
            this.cmbKayitliFabrika = new System.Windows.Forms.ComboBox();
            this.txtGuncelIPAdres1 = new System.Windows.Forms.TextBox();
            this.lblGuncelIPAdres = new System.Windows.Forms.Label();
            this.txtGuncelIPAdres2 = new System.Windows.Forms.TextBox();
            this.txtGuncelIPAdres3 = new System.Windows.Forms.TextBox();
            this.txtGuncelIPAdres4 = new System.Windows.Forms.TextBox();
            this.lblGuncelPortNo = new System.Windows.Forms.Label();
            this.txtGuncelPortNo = new System.Windows.Forms.TextBox();
            this.lblComID = new System.Windows.Forms.Label();
            this.txtGuncelComID = new System.Windows.Forms.TextBox();
            this.btnYaziciEkle = new System.Windows.Forms.Button();
            this.txtYeniComID = new System.Windows.Forms.TextBox();
            this.lblYeniComID = new System.Windows.Forms.Label();
            this.txtYeniPortNo = new System.Windows.Forms.TextBox();
            this.lblYeniPortNo = new System.Windows.Forms.Label();
            this.txtYeniIPAdres4 = new System.Windows.Forms.TextBox();
            this.txtYeniIPAdres3 = new System.Windows.Forms.TextBox();
            this.txtYeniIPAdres2 = new System.Windows.Forms.TextBox();
            this.lblYeniIPAdres = new System.Windows.Forms.Label();
            this.lblYeniYaziciAdi = new System.Windows.Forms.Label();
            this.txtYeniYaziciAdi = new System.Windows.Forms.TextBox();
            this.txtYeniIPAdres1 = new System.Windows.Forms.TextBox();
            this.cmbGuncelYaziciTipi = new System.Windows.Forms.ComboBox();
            this.lblYaziciTipi = new System.Windows.Forms.Label();
            this.lblYeniYaziciTipi = new System.Windows.Forms.Label();
            this.cmbYeniYaziciTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvYazicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTesisler
            // 
            this.lblTesisler.AutoSize = true;
            this.lblTesisler.Location = new System.Drawing.Point(15, 55);
            this.lblTesisler.Name = "lblTesisler";
            this.lblTesisler.Size = new System.Drawing.Size(78, 13);
            this.lblTesisler.TabIndex = 42;
            this.lblTesisler.Text = "Tesis Seçiniz...";
            // 
            // cmbKayitliTesis
            // 
            this.cmbKayitliTesis.FormattingEnabled = true;
            this.cmbKayitliTesis.Location = new System.Drawing.Point(14, 71);
            this.cmbKayitliTesis.Name = "cmbKayitliTesis";
            this.cmbKayitliTesis.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliTesis.TabIndex = 41;
            this.cmbKayitliTesis.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliTesis_SelectedIndexChanged);
            // 
            // lblGuncelYaziciAdi
            // 
            this.lblGuncelYaziciAdi.AutoSize = true;
            this.lblGuncelYaziciAdi.Location = new System.Drawing.Point(14, 346);
            this.lblGuncelYaziciAdi.Name = "lblGuncelYaziciAdi";
            this.lblGuncelYaziciAdi.Size = new System.Drawing.Size(125, 13);
            this.lblGuncelYaziciAdi.TabIndex = 39;
            this.lblGuncelYaziciAdi.Text = "Güncel yazici adı giriniz...";
            // 
            // txtGuncelYaziciAdi
            // 
            this.txtGuncelYaziciAdi.Location = new System.Drawing.Point(14, 365);
            this.txtGuncelYaziciAdi.Name = "txtGuncelYaziciAdi";
            this.txtGuncelYaziciAdi.Size = new System.Drawing.Size(118, 20);
            this.txtGuncelYaziciAdi.TabIndex = 37;
            // 
            // btnYaziciGuncelle
            // 
            this.btnYaziciGuncelle.Location = new System.Drawing.Point(200, 444);
            this.btnYaziciGuncelle.Name = "btnYaziciGuncelle";
            this.btnYaziciGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnYaziciGuncelle.TabIndex = 36;
            this.btnYaziciGuncelle.Text = "Güncelle";
            this.btnYaziciGuncelle.UseVisualStyleBackColor = true;
            this.btnYaziciGuncelle.Click += new System.EventHandler(this.btnYaziciGuncelle_Click);
            // 
            // btnYaziciSil
            // 
            this.btnYaziciSil.Location = new System.Drawing.Point(200, 307);
            this.btnYaziciSil.Name = "btnYaziciSil";
            this.btnYaziciSil.Size = new System.Drawing.Size(75, 23);
            this.btnYaziciSil.TabIndex = 34;
            this.btnYaziciSil.Text = "Kayıt Sil";
            this.btnYaziciSil.UseVisualStyleBackColor = true;
            this.btnYaziciSil.Click += new System.EventHandler(this.btnYaziciSil_Click);
            // 
            // lblBantlar
            // 
            this.lblBantlar.AutoSize = true;
            this.lblBantlar.Location = new System.Drawing.Point(14, 95);
            this.lblBantlar.Name = "lblBantlar";
            this.lblBantlar.Size = new System.Drawing.Size(75, 13);
            this.lblBantlar.TabIndex = 33;
            this.lblBantlar.Text = "Bant Seçiniz...";
            // 
            // cmbKayitliBant
            // 
            this.cmbKayitliBant.FormattingEnabled = true;
            this.cmbKayitliBant.Location = new System.Drawing.Point(13, 111);
            this.cmbKayitliBant.Name = "cmbKayitliBant";
            this.cmbKayitliBant.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliBant.TabIndex = 32;
            this.cmbKayitliBant.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliBant_SelectedIndexChanged);
            // 
            // lblKayitliYazicilar
            // 
            this.lblKayitliYazicilar.AutoSize = true;
            this.lblKayitliYazicilar.Location = new System.Drawing.Point(11, 135);
            this.lblKayitliYazicilar.Name = "lblKayitliYazicilar";
            this.lblKayitliYazicilar.Size = new System.Drawing.Size(116, 13);
            this.lblKayitliYazicilar.TabIndex = 31;
            this.lblKayitliYazicilar.Text = "Sisteme Kayıtlı Yazıcılar";
            // 
            // gvYazicilar
            // 
            this.gvYazicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvYazicilar.Location = new System.Drawing.Point(14, 151);
            this.gvYazicilar.Name = "gvYazicilar";
            this.gvYazicilar.Size = new System.Drawing.Size(261, 150);
            this.gvYazicilar.TabIndex = 30;
            this.gvYazicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvYazicilar_CellContentClick);
            // 
            // lblFabrikalar
            // 
            this.lblFabrikalar.AutoSize = true;
            this.lblFabrikalar.Location = new System.Drawing.Point(15, 15);
            this.lblFabrikalar.Name = "lblFabrikalar";
            this.lblFabrikalar.Size = new System.Drawing.Size(88, 13);
            this.lblFabrikalar.TabIndex = 44;
            this.lblFabrikalar.Text = "Fabrika Seçiniz...";
            // 
            // cmbKayitliFabrika
            // 
            this.cmbKayitliFabrika.FormattingEnabled = true;
            this.cmbKayitliFabrika.Location = new System.Drawing.Point(14, 31);
            this.cmbKayitliFabrika.Name = "cmbKayitliFabrika";
            this.cmbKayitliFabrika.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliFabrika.TabIndex = 43;
            this.cmbKayitliFabrika.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliFabrika_SelectedIndexChanged);
            // 
            // txtGuncelIPAdres1
            // 
            this.txtGuncelIPAdres1.Location = new System.Drawing.Point(17, 404);
            this.txtGuncelIPAdres1.Name = "txtGuncelIPAdres1";
            this.txtGuncelIPAdres1.Size = new System.Drawing.Size(24, 20);
            this.txtGuncelIPAdres1.TabIndex = 45;
            // 
            // lblGuncelIPAdres
            // 
            this.lblGuncelIPAdres.AutoSize = true;
            this.lblGuncelIPAdres.Location = new System.Drawing.Point(14, 388);
            this.lblGuncelIPAdres.Name = "lblGuncelIPAdres";
            this.lblGuncelIPAdres.Size = new System.Drawing.Size(123, 13);
            this.lblGuncelIPAdres.TabIndex = 46;
            this.lblGuncelIPAdres.Text = "Güncel IP adresi giriniz...";
            // 
            // txtGuncelIPAdres2
            // 
            this.txtGuncelIPAdres2.Location = new System.Drawing.Point(47, 404);
            this.txtGuncelIPAdres2.Name = "txtGuncelIPAdres2";
            this.txtGuncelIPAdres2.Size = new System.Drawing.Size(24, 20);
            this.txtGuncelIPAdres2.TabIndex = 47;
            // 
            // txtGuncelIPAdres3
            // 
            this.txtGuncelIPAdres3.Location = new System.Drawing.Point(77, 404);
            this.txtGuncelIPAdres3.Name = "txtGuncelIPAdres3";
            this.txtGuncelIPAdres3.Size = new System.Drawing.Size(24, 20);
            this.txtGuncelIPAdres3.TabIndex = 48;
            // 
            // txtGuncelIPAdres4
            // 
            this.txtGuncelIPAdres4.Location = new System.Drawing.Point(106, 404);
            this.txtGuncelIPAdres4.Name = "txtGuncelIPAdres4";
            this.txtGuncelIPAdres4.Size = new System.Drawing.Size(24, 20);
            this.txtGuncelIPAdres4.TabIndex = 49;
            // 
            // lblGuncelPortNo
            // 
            this.lblGuncelPortNo.AutoSize = true;
            this.lblGuncelPortNo.Location = new System.Drawing.Point(160, 346);
            this.lblGuncelPortNo.Name = "lblGuncelPortNo";
            this.lblGuncelPortNo.Size = new System.Drawing.Size(115, 13);
            this.lblGuncelPortNo.TabIndex = 50;
            this.lblGuncelPortNo.Text = "Güncel port no giriniz...";
            // 
            // txtGuncelPortNo
            // 
            this.txtGuncelPortNo.Location = new System.Drawing.Point(163, 365);
            this.txtGuncelPortNo.Name = "txtGuncelPortNo";
            this.txtGuncelPortNo.Size = new System.Drawing.Size(112, 20);
            this.txtGuncelPortNo.TabIndex = 51;
            // 
            // lblComID
            // 
            this.lblComID.AutoSize = true;
            this.lblComID.Location = new System.Drawing.Point(160, 388);
            this.lblComID.Name = "lblComID";
            this.lblComID.Size = new System.Drawing.Size(120, 13);
            this.lblComID.TabIndex = 52;
            this.lblComID.Text = "Güncel COM ID giriniz...";
            // 
            // txtGuncelComID
            // 
            this.txtGuncelComID.Location = new System.Drawing.Point(163, 404);
            this.txtGuncelComID.Name = "txtGuncelComID";
            this.txtGuncelComID.Size = new System.Drawing.Size(112, 20);
            this.txtGuncelComID.TabIndex = 53;
            // 
            // btnYaziciEkle
            // 
            this.btnYaziciEkle.Location = new System.Drawing.Point(200, 584);
            this.btnYaziciEkle.Name = "btnYaziciEkle";
            this.btnYaziciEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYaziciEkle.TabIndex = 35;
            this.btnYaziciEkle.Text = "Ekle";
            this.btnYaziciEkle.UseVisualStyleBackColor = true;
            this.btnYaziciEkle.Click += new System.EventHandler(this.btnYaziciEkle_Click);
            // 
            // txtYeniComID
            // 
            this.txtYeniComID.Location = new System.Drawing.Point(163, 544);
            this.txtYeniComID.Name = "txtYeniComID";
            this.txtYeniComID.Size = new System.Drawing.Size(112, 20);
            this.txtYeniComID.TabIndex = 63;
            // 
            // lblYeniComID
            // 
            this.lblYeniComID.AutoSize = true;
            this.lblYeniComID.Location = new System.Drawing.Point(160, 528);
            this.lblYeniComID.Name = "lblYeniComID";
            this.lblYeniComID.Size = new System.Drawing.Size(107, 13);
            this.lblYeniComID.TabIndex = 62;
            this.lblYeniComID.Text = "Yeni COM ID giriniz...";
            // 
            // txtYeniPortNo
            // 
            this.txtYeniPortNo.Location = new System.Drawing.Point(163, 505);
            this.txtYeniPortNo.Name = "txtYeniPortNo";
            this.txtYeniPortNo.Size = new System.Drawing.Size(112, 20);
            this.txtYeniPortNo.TabIndex = 61;
            // 
            // lblYeniPortNo
            // 
            this.lblYeniPortNo.AutoSize = true;
            this.lblYeniPortNo.Location = new System.Drawing.Point(160, 486);
            this.lblYeniPortNo.Name = "lblYeniPortNo";
            this.lblYeniPortNo.Size = new System.Drawing.Size(102, 13);
            this.lblYeniPortNo.TabIndex = 60;
            this.lblYeniPortNo.Text = "Yeni port no giriniz...";
            // 
            // txtYeniIPAdres4
            // 
            this.txtYeniIPAdres4.Location = new System.Drawing.Point(106, 544);
            this.txtYeniIPAdres4.Name = "txtYeniIPAdres4";
            this.txtYeniIPAdres4.Size = new System.Drawing.Size(24, 20);
            this.txtYeniIPAdres4.TabIndex = 59;
            // 
            // txtYeniIPAdres3
            // 
            this.txtYeniIPAdres3.Location = new System.Drawing.Point(77, 544);
            this.txtYeniIPAdres3.Name = "txtYeniIPAdres3";
            this.txtYeniIPAdres3.Size = new System.Drawing.Size(24, 20);
            this.txtYeniIPAdres3.TabIndex = 58;
            // 
            // txtYeniIPAdres2
            // 
            this.txtYeniIPAdres2.Location = new System.Drawing.Point(47, 544);
            this.txtYeniIPAdres2.Name = "txtYeniIPAdres2";
            this.txtYeniIPAdres2.Size = new System.Drawing.Size(24, 20);
            this.txtYeniIPAdres2.TabIndex = 57;
            // 
            // lblYeniIPAdres
            // 
            this.lblYeniIPAdres.AutoSize = true;
            this.lblYeniIPAdres.Location = new System.Drawing.Point(14, 528);
            this.lblYeniIPAdres.Name = "lblYeniIPAdres";
            this.lblYeniIPAdres.Size = new System.Drawing.Size(110, 13);
            this.lblYeniIPAdres.TabIndex = 56;
            this.lblYeniIPAdres.Text = "Yeni IP adresi giriniz...";
            // 
            // lblYeniYaziciAdi
            // 
            this.lblYeniYaziciAdi.AutoSize = true;
            this.lblYeniYaziciAdi.Location = new System.Drawing.Point(14, 486);
            this.lblYeniYaziciAdi.Name = "lblYeniYaziciAdi";
            this.lblYeniYaziciAdi.Size = new System.Drawing.Size(112, 13);
            this.lblYeniYaziciAdi.TabIndex = 55;
            this.lblYeniYaziciAdi.Text = "Yeni yazıcı adı giriniz...";
            // 
            // txtYeniYaziciAdi
            // 
            this.txtYeniYaziciAdi.Location = new System.Drawing.Point(14, 505);
            this.txtYeniYaziciAdi.Name = "txtYeniYaziciAdi";
            this.txtYeniYaziciAdi.Size = new System.Drawing.Size(118, 20);
            this.txtYeniYaziciAdi.TabIndex = 54;
            // 
            // txtYeniIPAdres1
            // 
            this.txtYeniIPAdres1.Location = new System.Drawing.Point(17, 544);
            this.txtYeniIPAdres1.Name = "txtYeniIPAdres1";
            this.txtYeniIPAdres1.Size = new System.Drawing.Size(24, 20);
            this.txtYeniIPAdres1.TabIndex = 64;
            // 
            // cmbGuncelYaziciTipi
            // 
            this.cmbGuncelYaziciTipi.FormattingEnabled = true;
            this.cmbGuncelYaziciTipi.Location = new System.Drawing.Point(17, 446);
            this.cmbGuncelYaziciTipi.Name = "cmbGuncelYaziciTipi";
            this.cmbGuncelYaziciTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbGuncelYaziciTipi.TabIndex = 65;
            // 
            // lblYaziciTipi
            // 
            this.lblYaziciTipi.AutoSize = true;
            this.lblYaziciTipi.Location = new System.Drawing.Point(15, 427);
            this.lblYaziciTipi.Name = "lblYaziciTipi";
            this.lblYaziciTipi.Size = new System.Drawing.Size(130, 13);
            this.lblYaziciTipi.TabIndex = 66;
            this.lblYaziciTipi.Text = "Güncel yazici tipi seçiniz...";
            // 
            // lblYeniYaziciTipi
            // 
            this.lblYeniYaziciTipi.AutoSize = true;
            this.lblYeniYaziciTipi.Location = new System.Drawing.Point(15, 567);
            this.lblYeniYaziciTipi.Name = "lblYeniYaziciTipi";
            this.lblYeniYaziciTipi.Size = new System.Drawing.Size(117, 13);
            this.lblYeniYaziciTipi.TabIndex = 68;
            this.lblYeniYaziciTipi.Text = "Yeni yazici tipi seçiniz...";
            // 
            // cmbYeniYaziciTipi
            // 
            this.cmbYeniYaziciTipi.FormattingEnabled = true;
            this.cmbYeniYaziciTipi.Location = new System.Drawing.Point(17, 586);
            this.cmbYeniYaziciTipi.Name = "cmbYeniYaziciTipi";
            this.cmbYeniYaziciTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbYeniYaziciTipi.TabIndex = 67;
            // 
            // YaziciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 651);
            this.Controls.Add(this.lblYeniYaziciTipi);
            this.Controls.Add(this.cmbYeniYaziciTipi);
            this.Controls.Add(this.lblYaziciTipi);
            this.Controls.Add(this.cmbGuncelYaziciTipi);
            this.Controls.Add(this.txtYeniIPAdres1);
            this.Controls.Add(this.txtYeniComID);
            this.Controls.Add(this.lblYeniComID);
            this.Controls.Add(this.txtYeniPortNo);
            this.Controls.Add(this.lblYeniPortNo);
            this.Controls.Add(this.txtYeniIPAdres4);
            this.Controls.Add(this.txtYeniIPAdres3);
            this.Controls.Add(this.txtYeniIPAdres2);
            this.Controls.Add(this.lblYeniIPAdres);
            this.Controls.Add(this.lblYeniYaziciAdi);
            this.Controls.Add(this.txtYeniYaziciAdi);
            this.Controls.Add(this.txtGuncelComID);
            this.Controls.Add(this.lblComID);
            this.Controls.Add(this.txtGuncelPortNo);
            this.Controls.Add(this.lblGuncelPortNo);
            this.Controls.Add(this.txtGuncelIPAdres4);
            this.Controls.Add(this.txtGuncelIPAdres3);
            this.Controls.Add(this.txtGuncelIPAdres2);
            this.Controls.Add(this.lblGuncelIPAdres);
            this.Controls.Add(this.txtGuncelIPAdres1);
            this.Controls.Add(this.lblFabrikalar);
            this.Controls.Add(this.cmbKayitliFabrika);
            this.Controls.Add(this.lblTesisler);
            this.Controls.Add(this.cmbKayitliTesis);
            this.Controls.Add(this.lblGuncelYaziciAdi);
            this.Controls.Add(this.txtGuncelYaziciAdi);
            this.Controls.Add(this.btnYaziciGuncelle);
            this.Controls.Add(this.btnYaziciEkle);
            this.Controls.Add(this.btnYaziciSil);
            this.Controls.Add(this.lblBantlar);
            this.Controls.Add(this.cmbKayitliBant);
            this.Controls.Add(this.lblKayitliYazicilar);
            this.Controls.Add(this.gvYazicilar);
            this.Name = "YaziciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazıcı İşlemleri";
            this.Load += new System.EventHandler(this.YaziciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvYazicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTesisler;
        private System.Windows.Forms.ComboBox cmbKayitliTesis;
        private System.Windows.Forms.Label lblGuncelYaziciAdi;
        private System.Windows.Forms.TextBox txtGuncelYaziciAdi;
        private System.Windows.Forms.Button btnYaziciGuncelle;
        private System.Windows.Forms.Button btnYaziciSil;
        private System.Windows.Forms.Label lblBantlar;
        private System.Windows.Forms.ComboBox cmbKayitliBant;
        private System.Windows.Forms.Label lblKayitliYazicilar;
        private System.Windows.Forms.DataGridView gvYazicilar;
        private System.Windows.Forms.Label lblFabrikalar;
        private System.Windows.Forms.ComboBox cmbKayitliFabrika;
        private System.Windows.Forms.TextBox txtGuncelIPAdres1;
        private System.Windows.Forms.Label lblGuncelIPAdres;
        private System.Windows.Forms.TextBox txtGuncelIPAdres2;
        private System.Windows.Forms.TextBox txtGuncelIPAdres3;
        private System.Windows.Forms.TextBox txtGuncelIPAdres4;
        private System.Windows.Forms.Label lblGuncelPortNo;
        private System.Windows.Forms.TextBox txtGuncelPortNo;
        private System.Windows.Forms.Label lblComID;
        private System.Windows.Forms.TextBox txtGuncelComID;
        private System.Windows.Forms.Button btnYaziciEkle;
        private System.Windows.Forms.TextBox txtYeniComID;
        private System.Windows.Forms.Label lblYeniComID;
        private System.Windows.Forms.TextBox txtYeniPortNo;
        private System.Windows.Forms.Label lblYeniPortNo;
        private System.Windows.Forms.TextBox txtYeniIPAdres4;
        private System.Windows.Forms.TextBox txtYeniIPAdres3;
        private System.Windows.Forms.TextBox txtYeniIPAdres2;
        private System.Windows.Forms.Label lblYeniIPAdres;
        private System.Windows.Forms.Label lblYeniYaziciAdi;
        private System.Windows.Forms.TextBox txtYeniYaziciAdi;
        private System.Windows.Forms.TextBox txtYeniIPAdres1;
        private System.Windows.Forms.ComboBox cmbGuncelYaziciTipi;
        private System.Windows.Forms.Label lblYaziciTipi;
        private System.Windows.Forms.Label lblYeniYaziciTipi;
        private System.Windows.Forms.ComboBox cmbYeniYaziciTipi;
    }
}