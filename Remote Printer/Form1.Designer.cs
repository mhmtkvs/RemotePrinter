namespace Remote_Printer
{
    partial class Form1
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
            this.gbFabrika = new System.Windows.Forms.GroupBox();
            this.tbYeniFabrika = new System.Windows.Forms.TextBox();
            this.lblYeniFabrika = new System.Windows.Forms.Label();
            this.btnYeniFabrikaEkle = new System.Windows.Forms.Button();
            this.cmbSilinecekFabrika = new System.Windows.Forms.ComboBox();
            this.lblSilinecekFabrika = new System.Windows.Forms.Label();
            this.btnFabrikaSil = new System.Windows.Forms.Button();
            this.tbGuncelFabrika = new System.Windows.Forms.TextBox();
            this.lblGuncelFabrikaAdi = new System.Windows.Forms.Label();
            this.lblGuncelFabrika = new System.Windows.Forms.Label();
            this.cmbGuncelFabrika = new System.Windows.Forms.ComboBox();
            this.btnFabrikaGuncelle = new System.Windows.Forms.Button();
            this.gbTesis = new System.Windows.Forms.GroupBox();
            this.gbFabrika.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFabrika
            // 
            this.gbFabrika.Controls.Add(this.btnFabrikaGuncelle);
            this.gbFabrika.Controls.Add(this.lblGuncelFabrikaAdi);
            this.gbFabrika.Controls.Add(this.tbGuncelFabrika);
            this.gbFabrika.Controls.Add(this.lblGuncelFabrika);
            this.gbFabrika.Controls.Add(this.cmbGuncelFabrika);
            this.gbFabrika.Controls.Add(this.btnFabrikaSil);
            this.gbFabrika.Controls.Add(this.lblSilinecekFabrika);
            this.gbFabrika.Controls.Add(this.cmbSilinecekFabrika);
            this.gbFabrika.Controls.Add(this.btnYeniFabrikaEkle);
            this.gbFabrika.Controls.Add(this.lblYeniFabrika);
            this.gbFabrika.Controls.Add(this.tbYeniFabrika);
            this.gbFabrika.Location = new System.Drawing.Point(12, 12);
            this.gbFabrika.Name = "gbFabrika";
            this.gbFabrika.Size = new System.Drawing.Size(837, 73);
            this.gbFabrika.TabIndex = 0;
            this.gbFabrika.TabStop = false;
            this.gbFabrika.Text = "Fabrika";
            // 
            // tbYeniFabrika
            // 
            this.tbYeniFabrika.Location = new System.Drawing.Point(6, 47);
            this.tbYeniFabrika.Name = "tbYeniFabrika";
            this.tbYeniFabrika.Size = new System.Drawing.Size(143, 20);
            this.tbYeniFabrika.TabIndex = 1;
            // 
            // lblYeniFabrika
            // 
            this.lblYeniFabrika.AutoSize = true;
            this.lblYeniFabrika.Location = new System.Drawing.Point(7, 28);
            this.lblYeniFabrika.Name = "lblYeniFabrika";
            this.lblYeniFabrika.Size = new System.Drawing.Size(118, 13);
            this.lblYeniFabrika.TabIndex = 2;
            this.lblYeniFabrika.Text = "Yeni fabrika adı giriniz...";
            // 
            // btnYeniFabrikaEkle
            // 
            this.btnYeniFabrikaEkle.Location = new System.Drawing.Point(155, 45);
            this.btnYeniFabrikaEkle.Name = "btnYeniFabrikaEkle";
            this.btnYeniFabrikaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniFabrikaEkle.TabIndex = 3;
            this.btnYeniFabrikaEkle.Text = "Kayıt Ekle";
            this.btnYeniFabrikaEkle.UseVisualStyleBackColor = true;
            // 
            // cmbSilinecekFabrika
            // 
            this.cmbSilinecekFabrika.FormattingEnabled = true;
            this.cmbSilinecekFabrika.Location = new System.Drawing.Point(237, 45);
            this.cmbSilinecekFabrika.Name = "cmbSilinecekFabrika";
            this.cmbSilinecekFabrika.Size = new System.Drawing.Size(121, 21);
            this.cmbSilinecekFabrika.TabIndex = 4;
            // 
            // lblSilinecekFabrika
            // 
            this.lblSilinecekFabrika.AutoSize = true;
            this.lblSilinecekFabrika.Location = new System.Drawing.Point(237, 28);
            this.lblSilinecekFabrika.Name = "lblSilinecekFabrika";
            this.lblSilinecekFabrika.Size = new System.Drawing.Size(103, 13);
            this.lblSilinecekFabrika.TabIndex = 5;
            this.lblSilinecekFabrika.Text = "Fabrika adı seçiniz...";
            // 
            // btnFabrikaSil
            // 
            this.btnFabrikaSil.Location = new System.Drawing.Point(375, 47);
            this.btnFabrikaSil.Name = "btnFabrikaSil";
            this.btnFabrikaSil.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaSil.TabIndex = 6;
            this.btnFabrikaSil.Text = "Kayıt Sil";
            this.btnFabrikaSil.UseVisualStyleBackColor = true;
            // 
            // tbGuncelFabrika
            // 
            this.tbGuncelFabrika.Location = new System.Drawing.Point(585, 47);
            this.tbGuncelFabrika.Name = "tbGuncelFabrika";
            this.tbGuncelFabrika.Size = new System.Drawing.Size(139, 20);
            this.tbGuncelFabrika.TabIndex = 9;
            // 
            // lblGuncelFabrikaAdi
            // 
            this.lblGuncelFabrikaAdi.AutoSize = true;
            this.lblGuncelFabrikaAdi.Location = new System.Drawing.Point(585, 28);
            this.lblGuncelFabrikaAdi.Name = "lblGuncelFabrikaAdi";
            this.lblGuncelFabrikaAdi.Size = new System.Drawing.Size(139, 13);
            this.lblGuncelFabrikaAdi.TabIndex = 10;
            this.lblGuncelFabrikaAdi.Text = "Güncel fabrika adını giriniz...";
            // 
            // lblGuncelFabrika
            // 
            this.lblGuncelFabrika.AutoSize = true;
            this.lblGuncelFabrika.Location = new System.Drawing.Point(457, 27);
            this.lblGuncelFabrika.Name = "lblGuncelFabrika";
            this.lblGuncelFabrika.Size = new System.Drawing.Size(111, 13);
            this.lblGuncelFabrika.TabIndex = 8;
            this.lblGuncelFabrika.Text = "Fabrika adını seçiniz...";
            // 
            // cmbGuncelFabrika
            // 
            this.cmbGuncelFabrika.FormattingEnabled = true;
            this.cmbGuncelFabrika.Location = new System.Drawing.Point(457, 45);
            this.cmbGuncelFabrika.Name = "cmbGuncelFabrika";
            this.cmbGuncelFabrika.Size = new System.Drawing.Size(121, 21);
            this.cmbGuncelFabrika.TabIndex = 7;
            // 
            // btnFabrikaGuncelle
            // 
            this.btnFabrikaGuncelle.Location = new System.Drawing.Point(731, 42);
            this.btnFabrikaGuncelle.Name = "btnFabrikaGuncelle";
            this.btnFabrikaGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaGuncelle.TabIndex = 11;
            this.btnFabrikaGuncelle.Text = "Güncelle";
            this.btnFabrikaGuncelle.UseVisualStyleBackColor = true;
            // 
            // gbTesis
            // 
            this.gbTesis.Location = new System.Drawing.Point(12, 92);
            this.gbTesis.Name = "gbTesis";
            this.gbTesis.Size = new System.Drawing.Size(837, 100);
            this.gbTesis.TabIndex = 1;
            this.gbTesis.TabStop = false;
            this.gbTesis.Text = "Tesis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 554);
            this.Controls.Add(this.gbTesis);
            this.Controls.Add(this.gbFabrika);
            this.Name = "Form1";
            this.Text = "Remote Printer v1.0";
            this.gbFabrika.ResumeLayout(false);
            this.gbFabrika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFabrika;
        private System.Windows.Forms.Button btnFabrikaGuncelle;
        private System.Windows.Forms.Label lblGuncelFabrikaAdi;
        private System.Windows.Forms.TextBox tbGuncelFabrika;
        private System.Windows.Forms.Label lblGuncelFabrika;
        private System.Windows.Forms.ComboBox cmbGuncelFabrika;
        private System.Windows.Forms.Button btnFabrikaSil;
        private System.Windows.Forms.Label lblSilinecekFabrika;
        private System.Windows.Forms.ComboBox cmbSilinecekFabrika;
        private System.Windows.Forms.Button btnYeniFabrikaEkle;
        private System.Windows.Forms.Label lblYeniFabrika;
        private System.Windows.Forms.TextBox tbYeniFabrika;
        private System.Windows.Forms.GroupBox gbTesis;

    }
}

