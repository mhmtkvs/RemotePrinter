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
            this.btnFabrikaSil = new System.Windows.Forms.Button();
            this.lblYeniTesisAdi = new System.Windows.Forms.Label();
            this.lblGuncelTesisAdi = new System.Windows.Forms.Label();
            this.txtYeniTesisAdi = new System.Windows.Forms.TextBox();
            this.txtGüncelTesisAdi = new System.Windows.Forms.TextBox();
            this.btnTesisGüncelle = new System.Windows.Forms.Button();
            this.btnTesisEkle = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.gvTesisler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFabrikaKayıtlıTesisler
            // 
            this.lblFabrikaKayıtlıTesisler.AutoSize = true;
            this.lblFabrikaKayıtlıTesisler.Location = new System.Drawing.Point(10, 53);
            this.lblFabrikaKayıtlıTesisler.Name = "lblFabrikaKayıtlıTesisler";
            this.lblFabrikaKayıtlıTesisler.Size = new System.Drawing.Size(122, 13);
            this.lblFabrikaKayıtlıTesisler.TabIndex = 3;
            this.lblFabrikaKayıtlıTesisler.Text = "Fabrikaya Kayıtlı Tesisler";
            // 
            // gvTesisler
            // 
            this.gvTesisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTesisler.Location = new System.Drawing.Point(13, 69);
            this.gvTesisler.Name = "gvTesisler";
            this.gvTesisler.Size = new System.Drawing.Size(201, 150);
            this.gvTesisler.TabIndex = 2;
            // 
            // cmbKayitliFabrikalar
            // 
            this.cmbKayitliFabrikalar.FormattingEnabled = true;
            this.cmbKayitliFabrikalar.Location = new System.Drawing.Point(12, 29);
            this.cmbKayitliFabrikalar.Name = "cmbKayitliFabrikalar";
            this.cmbKayitliFabrikalar.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliFabrikalar.TabIndex = 4;
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
            // btnFabrikaSil
            // 
            this.btnFabrikaSil.Location = new System.Drawing.Point(139, 225);
            this.btnFabrikaSil.Name = "btnFabrikaSil";
            this.btnFabrikaSil.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaSil.TabIndex = 6;
            this.btnFabrikaSil.Text = "Kayıt Sil";
            this.btnFabrikaSil.UseVisualStyleBackColor = true;
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
            // txtGüncelTesisAdi
            // 
            this.txtGüncelTesisAdi.Location = new System.Drawing.Point(13, 283);
            this.txtGüncelTesisAdi.Name = "txtGüncelTesisAdi";
            this.txtGüncelTesisAdi.Size = new System.Drawing.Size(120, 20);
            this.txtGüncelTesisAdi.TabIndex = 13;
            // 
            // btnTesisGüncelle
            // 
            this.btnTesisGüncelle.Location = new System.Drawing.Point(139, 281);
            this.btnTesisGüncelle.Name = "btnTesisGüncelle";
            this.btnTesisGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnTesisGüncelle.TabIndex = 12;
            this.btnTesisGüncelle.Text = "Güncelle";
            this.btnTesisGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnTesisEkle
            // 
            this.btnTesisEkle.Location = new System.Drawing.Point(137, 338);
            this.btnTesisEkle.Name = "btnTesisEkle";
            this.btnTesisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTesisEkle.TabIndex = 11;
            this.btnTesisEkle.Text = "Ekle";
            this.btnTesisEkle.UseVisualStyleBackColor = true;
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
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 212;
            this.lineShape1.Y1 = 256;
            this.lineShape1.Y2 = 256;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 11;
            this.lineShape2.X2 = 211;
            this.lineShape2.Y1 = 312;
            this.lineShape2.Y2 = 312;
            // 
            // TesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 372);
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
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TesisForm";
            this.Text = "TesisForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvTesisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFabrikaKayıtlıTesisler;
        private System.Windows.Forms.DataGridView gvTesisler;
        private System.Windows.Forms.ComboBox cmbKayitliFabrikalar;
        private System.Windows.Forms.Label lblKayitliFabrikalar;
        private System.Windows.Forms.Button btnFabrikaSil;
        private System.Windows.Forms.Label lblYeniTesisAdi;
        private System.Windows.Forms.Label lblGuncelTesisAdi;
        private System.Windows.Forms.TextBox txtYeniTesisAdi;
        private System.Windows.Forms.TextBox txtGüncelTesisAdi;
        private System.Windows.Forms.Button btnTesisGüncelle;
        private System.Windows.Forms.Button btnTesisEkle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}