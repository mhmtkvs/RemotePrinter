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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblYeniTesisAdi = new System.Windows.Forms.Label();
            this.lblGuncelTesisAdi = new System.Windows.Forms.Label();
            this.txtYeniTesisAdi = new System.Windows.Forms.TextBox();
            this.txtGüncelTesisAdi = new System.Windows.Forms.TextBox();
            this.btnTesisGüncelle = new System.Windows.Forms.Button();
            this.btnTesisEkle = new System.Windows.Forms.Button();
            this.btnFabrikaSil = new System.Windows.Forms.Button();
            this.lblKayitliFabrikalar = new System.Windows.Forms.Label();
            this.cmbKayitliFabrikalar = new System.Windows.Forms.ComboBox();
            this.lblFabrikaKayıtlıTesisler = new System.Windows.Forms.Label();
            this.gvTesisler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTesisler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Fabrika Seçiniz...";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // lblYeniTesisAdi
            // 
            this.lblYeniTesisAdi.AutoSize = true;
            this.lblYeniTesisAdi.Location = new System.Drawing.Point(15, 403);
            this.lblYeniTesisAdi.Name = "lblYeniTesisAdi";
            this.lblYeniTesisAdi.Size = new System.Drawing.Size(107, 13);
            this.lblYeniTesisAdi.TabIndex = 40;
            this.lblYeniTesisAdi.Text = "Yeni tesis adı giriniz...";
            this.lblYeniTesisAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuncelTesisAdi
            // 
            this.lblGuncelTesisAdi.AutoSize = true;
            this.lblGuncelTesisAdi.Location = new System.Drawing.Point(14, 346);
            this.lblGuncelTesisAdi.Name = "lblGuncelTesisAdi";
            this.lblGuncelTesisAdi.Size = new System.Drawing.Size(120, 13);
            this.lblGuncelTesisAdi.TabIndex = 39;
            this.lblGuncelTesisAdi.Text = "Güncel tesis adı giriniz...";
            // 
            // txtYeniTesisAdi
            // 
            this.txtYeniTesisAdi.Location = new System.Drawing.Point(12, 422);
            this.txtYeniTesisAdi.Name = "txtYeniTesisAdi";
            this.txtYeniTesisAdi.Size = new System.Drawing.Size(120, 20);
            this.txtYeniTesisAdi.TabIndex = 38;
            // 
            // txtGüncelTesisAdi
            // 
            this.txtGüncelTesisAdi.Location = new System.Drawing.Point(14, 365);
            this.txtGüncelTesisAdi.Name = "txtGüncelTesisAdi";
            this.txtGüncelTesisAdi.Size = new System.Drawing.Size(120, 20);
            this.txtGüncelTesisAdi.TabIndex = 37;
            // 
            // btnTesisGüncelle
            // 
            this.btnTesisGüncelle.Location = new System.Drawing.Point(140, 363);
            this.btnTesisGüncelle.Name = "btnTesisGüncelle";
            this.btnTesisGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnTesisGüncelle.TabIndex = 36;
            this.btnTesisGüncelle.Text = "Güncelle";
            this.btnTesisGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnTesisEkle
            // 
            this.btnTesisEkle.Location = new System.Drawing.Point(138, 420);
            this.btnTesisEkle.Name = "btnTesisEkle";
            this.btnTesisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTesisEkle.TabIndex = 35;
            this.btnTesisEkle.Text = "Ekle";
            this.btnTesisEkle.UseVisualStyleBackColor = true;
            // 
            // btnFabrikaSil
            // 
            this.btnFabrikaSil.Location = new System.Drawing.Point(140, 307);
            this.btnFabrikaSil.Name = "btnFabrikaSil";
            this.btnFabrikaSil.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaSil.TabIndex = 34;
            this.btnFabrikaSil.Text = "Kayıt Sil";
            this.btnFabrikaSil.UseVisualStyleBackColor = true;
            // 
            // lblKayitliFabrikalar
            // 
            this.lblKayitliFabrikalar.AutoSize = true;
            this.lblKayitliFabrikalar.Location = new System.Drawing.Point(14, 95);
            this.lblKayitliFabrikalar.Name = "lblKayitliFabrikalar";
            this.lblKayitliFabrikalar.Size = new System.Drawing.Size(88, 13);
            this.lblKayitliFabrikalar.TabIndex = 33;
            this.lblKayitliFabrikalar.Text = "Fabrika Seçiniz...";
            // 
            // cmbKayitliFabrikalar
            // 
            this.cmbKayitliFabrikalar.FormattingEnabled = true;
            this.cmbKayitliFabrikalar.Location = new System.Drawing.Point(13, 111);
            this.cmbKayitliFabrikalar.Name = "cmbKayitliFabrikalar";
            this.cmbKayitliFabrikalar.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliFabrikalar.TabIndex = 32;
            // 
            // lblFabrikaKayıtlıTesisler
            // 
            this.lblFabrikaKayıtlıTesisler.AutoSize = true;
            this.lblFabrikaKayıtlıTesisler.Location = new System.Drawing.Point(11, 135);
            this.lblFabrikaKayıtlıTesisler.Name = "lblFabrikaKayıtlıTesisler";
            this.lblFabrikaKayıtlıTesisler.Size = new System.Drawing.Size(122, 13);
            this.lblFabrikaKayıtlıTesisler.TabIndex = 31;
            this.lblFabrikaKayıtlıTesisler.Text = "Fabrikaya Kayıtlı Tesisler";
            // 
            // gvTesisler
            // 
            this.gvTesisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTesisler.Location = new System.Drawing.Point(14, 151);
            this.gvTesisler.Name = "gvTesisler";
            this.gvTesisler.Size = new System.Drawing.Size(201, 150);
            this.gvTesisler.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Fabrika Seçiniz...";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // YaziciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblYeniTesisAdi);
            this.Controls.Add(this.lblGuncelTesisAdi);
            this.Controls.Add(this.txtYeniTesisAdi);
            this.Controls.Add(this.txtGüncelTesisAdi);
            this.Controls.Add(this.btnTesisGüncelle);
            this.Controls.Add(this.btnTesisEkle);
            this.Controls.Add(this.btnFabrikaSil);
            this.Controls.Add(this.lblKayitliFabrikalar);
            this.Controls.Add(this.cmbKayitliFabrikalar);
            this.Controls.Add(this.lblFabrikaKayıtlıTesisler);
            this.Controls.Add(this.gvTesisler);
            this.Name = "YaziciForm";
            this.Text = "Yazıcı İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.gvTesisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblYeniTesisAdi;
        private System.Windows.Forms.Label lblGuncelTesisAdi;
        private System.Windows.Forms.TextBox txtYeniTesisAdi;
        private System.Windows.Forms.TextBox txtGüncelTesisAdi;
        private System.Windows.Forms.Button btnTesisGüncelle;
        private System.Windows.Forms.Button btnTesisEkle;
        private System.Windows.Forms.Button btnFabrikaSil;
        private System.Windows.Forms.Label lblKayitliFabrikalar;
        private System.Windows.Forms.ComboBox cmbKayitliFabrikalar;
        private System.Windows.Forms.Label lblFabrikaKayıtlıTesisler;
        private System.Windows.Forms.DataGridView gvTesisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}