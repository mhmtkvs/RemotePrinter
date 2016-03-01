namespace Remote_Printer
{
    partial class TesisForm
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
            this.lblFabrikaKayıtlıTesisler = new System.Windows.Forms.Label();
            this.gvTesisler = new System.Windows.Forms.DataGridView();
            this.cmbKayitliFabrikalar = new System.Windows.Forms.ComboBox();
            this.lblKayitliFabrikalar = new System.Windows.Forms.Label();
            this.btnTesisSil = new System.Windows.Forms.Button();
            this.lblYeniTesisAdi = new System.Windows.Forms.Label();
            this.lblGuncelTesisAdi = new System.Windows.Forms.Label();
            this.txtYeniTesisAdi = new System.Windows.Forms.TextBox();
            this.txtGuncelTesisAdi = new System.Windows.Forms.TextBox();
            this.btnTesisGuncelle = new System.Windows.Forms.Button();
            this.btnTesisEkle = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.gvTesisler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFabrikaKayıtlıTesisler
            // 
            this.lblFabrikaKayıtlıTesisler.AutoSize = true;
            this.lblFabrikaKayıtlıTesisler.Location = new System.Drawing.Point(10, 53);
            this.lblFabrikaKayıtlıTesisler.Name = "lblFabrikaKayıtlıTesisler";
            this.lblFabrikaKayıtlıTesisler.Size = new System.Drawing.Size(113, 13);
            this.lblFabrikaKayıtlıTesisler.TabIndex = 3;
            this.lblFabrikaKayıtlıTesisler.Text = "Sisteme Kayıtlı Tesisler";
            // 
            // gvTesisler
            // 
            this.gvTesisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTesisler.Location = new System.Drawing.Point(13, 69);
            this.gvTesisler.Name = "gvTesisler";
            this.gvTesisler.Size = new System.Drawing.Size(201, 150);
            this.gvTesisler.TabIndex = 2;
            this.gvTesisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTesisler_CellClick);
            // 
            // cmbKayitliFabrikalar
            // 
            this.cmbKayitliFabrikalar.FormattingEnabled = true;
            this.cmbKayitliFabrikalar.Location = new System.Drawing.Point(12, 29);
            this.cmbKayitliFabrikalar.Name = "cmbKayitliFabrikalar";
            this.cmbKayitliFabrikalar.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliFabrikalar.TabIndex = 4;
            this.cmbKayitliFabrikalar.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliFabrikalar_SelectedIndexChanged);
            // 
            // lblKayitliFabrikalar
            // 
            this.lblKayitliFabrikalar.AutoSize = true;
            this.lblKayitliFabrikalar.Location = new System.Drawing.Point(13, 13);
            this.lblKayitliFabrikalar.Name = "lblKayitliFabrikalar";
            this.lblKayitliFabrikalar.Size = new System.Drawing.Size(88, 13);
            this.lblKayitliFabrikalar.TabIndex = 5;
            this.lblKayitliFabrikalar.Text = "Fabrika Seçiniz...";
            // 
            // btnTesisSil
            // 
            this.btnTesisSil.Location = new System.Drawing.Point(139, 225);
            this.btnTesisSil.Name = "btnTesisSil";
            this.btnTesisSil.Size = new System.Drawing.Size(75, 23);
            this.btnTesisSil.TabIndex = 6;
            this.btnTesisSil.Text = "Kayıt Sil";
            this.btnTesisSil.UseVisualStyleBackColor = true;
            this.btnTesisSil.Click += new System.EventHandler(this.btnTesisSil_Click);
            // 
            // lblYeniTesisAdi
            // 
            this.lblYeniTesisAdi.AutoSize = true;
            this.lblYeniTesisAdi.Location = new System.Drawing.Point(14, 321);
            this.lblYeniTesisAdi.Name = "lblYeniTesisAdi";
            this.lblYeniTesisAdi.Size = new System.Drawing.Size(107, 13);
            this.lblYeniTesisAdi.TabIndex = 16;
            this.lblYeniTesisAdi.Text = "Yeni tesis adı giriniz...";
            this.lblYeniTesisAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuncelTesisAdi
            // 
            this.lblGuncelTesisAdi.AutoSize = true;
            this.lblGuncelTesisAdi.Location = new System.Drawing.Point(13, 264);
            this.lblGuncelTesisAdi.Name = "lblGuncelTesisAdi";
            this.lblGuncelTesisAdi.Size = new System.Drawing.Size(120, 13);
            this.lblGuncelTesisAdi.TabIndex = 15;
            this.lblGuncelTesisAdi.Text = "Güncel tesis adı giriniz...";
            // 
            // txtYeniTesisAdi
            // 
            this.txtYeniTesisAdi.Location = new System.Drawing.Point(11, 340);
            this.txtYeniTesisAdi.Name = "txtYeniTesisAdi";
            this.txtYeniTesisAdi.Size = new System.Drawing.Size(120, 20);
            this.txtYeniTesisAdi.TabIndex = 14;
            // 
            // txtGuncelTesisAdi
            // 
            this.txtGuncelTesisAdi.Location = new System.Drawing.Point(13, 283);
            this.txtGuncelTesisAdi.Name = "txtGuncelTesisAdi";
            this.txtGuncelTesisAdi.Size = new System.Drawing.Size(120, 20);
            this.txtGuncelTesisAdi.TabIndex = 13;
            // 
            // btnTesisGuncelle
            // 
            this.btnTesisGuncelle.Location = new System.Drawing.Point(139, 281);
            this.btnTesisGuncelle.Name = "btnTesisGuncelle";
            this.btnTesisGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnTesisGuncelle.TabIndex = 12;
            this.btnTesisGuncelle.Text = "Güncelle";
            this.btnTesisGuncelle.UseVisualStyleBackColor = true;
            this.btnTesisGuncelle.Click += new System.EventHandler(this.btnTesisGuncelle_Click);
            // 
            // btnTesisEkle
            // 
            this.btnTesisEkle.Location = new System.Drawing.Point(137, 338);
            this.btnTesisEkle.Name = "btnTesisEkle";
            this.btnTesisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTesisEkle.TabIndex = 11;
            this.btnTesisEkle.Text = "Ekle";
            this.btnTesisEkle.UseVisualStyleBackColor = true;
            this.btnTesisEkle.Click += new System.EventHandler(this.btnTesisEkle_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(225, 372);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 11;
            this.lineShape2.X2 = 211;
            this.lineShape2.Y1 = 312;
            this.lineShape2.Y2 = 312;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 212;
            this.lineShape1.Y1 = 256;
            this.lineShape1.Y2 = 256;
            // 
            // TesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 372);
            this.Controls.Add(this.lblYeniTesisAdi);
            this.Controls.Add(this.lblGuncelTesisAdi);
            this.Controls.Add(this.txtYeniTesisAdi);
            this.Controls.Add(this.txtGuncelTesisAdi);
            this.Controls.Add(this.btnTesisGuncelle);
            this.Controls.Add(this.btnTesisEkle);
            this.Controls.Add(this.btnTesisSil);
            this.Controls.Add(this.lblKayitliFabrikalar);
            this.Controls.Add(this.cmbKayitliFabrikalar);
            this.Controls.Add(this.lblFabrikaKayıtlıTesisler);
            this.Controls.Add(this.gvTesisler);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TesisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesis İşlemleri";
            this.Load += new System.EventHandler(this.TesisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTesisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFabrikaKayıtlıTesisler;
        private System.Windows.Forms.DataGridView gvTesisler;
        private System.Windows.Forms.ComboBox cmbKayitliFabrikalar;
        private System.Windows.Forms.Label lblKayitliFabrikalar;
        private System.Windows.Forms.Button btnTesisSil;
        private System.Windows.Forms.Label lblYeniTesisAdi;
        private System.Windows.Forms.Label lblGuncelTesisAdi;
        private System.Windows.Forms.TextBox txtYeniTesisAdi;
        private System.Windows.Forms.TextBox txtGuncelTesisAdi;
        private System.Windows.Forms.Button btnTesisGuncelle;
        private System.Windows.Forms.Button btnTesisEkle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}