namespace Remote_Printer
{
    partial class FabrikaForm
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
            this.gvKayitliFabrikalar = new System.Windows.Forms.DataGridView();
            this.lblSistemKayitliFabrikalar = new System.Windows.Forms.Label();
            this.btnFabrikaEkle = new System.Windows.Forms.Button();
            this.btnFabrikaSil = new System.Windows.Forms.Button();
            this.btnFabrikaGuncelle = new System.Windows.Forms.Button();
            this.txtGuncelFabrikaAdi = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtYeniFabrikaAdi = new System.Windows.Forms.TextBox();
            this.lblGuncelFabrikaAdi = new System.Windows.Forms.Label();
            this.lblYeniFabrikaAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvKayitliFabrikalar)).BeginInit();
            this.SuspendLayout();
            // 
            // gvKayitliFabrikalar
            // 
            this.gvKayitliFabrikalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKayitliFabrikalar.Location = new System.Drawing.Point(12, 22);
            this.gvKayitliFabrikalar.Name = "gvKayitliFabrikalar";
            this.gvKayitliFabrikalar.Size = new System.Drawing.Size(201, 150);
            this.gvKayitliFabrikalar.TabIndex = 0;
            this.gvKayitliFabrikalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKayitliFabrikalar_CellClick);
            // 
            // lblSistemKayitliFabrikalar
            // 
            this.lblSistemKayitliFabrikalar.AutoSize = true;
            this.lblSistemKayitliFabrikalar.Location = new System.Drawing.Point(9, 6);
            this.lblSistemKayitliFabrikalar.Name = "lblSistemKayitliFabrikalar";
            this.lblSistemKayitliFabrikalar.Size = new System.Drawing.Size(123, 13);
            this.lblSistemKayitliFabrikalar.TabIndex = 1;
            this.lblSistemKayitliFabrikalar.Text = "Sisteme Kayıtlı Fabrikalar";
            // 
            // btnFabrikaEkle
            // 
            this.btnFabrikaEkle.Location = new System.Drawing.Point(138, 292);
            this.btnFabrikaEkle.Name = "btnFabrikaEkle";
            this.btnFabrikaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaEkle.TabIndex = 2;
            this.btnFabrikaEkle.Text = "Ekle";
            this.btnFabrikaEkle.UseVisualStyleBackColor = true;
            this.btnFabrikaEkle.Click += new System.EventHandler(this.btnFabrikaEkle_Click);
            // 
            // btnFabrikaSil
            // 
            this.btnFabrikaSil.Location = new System.Drawing.Point(138, 178);
            this.btnFabrikaSil.Name = "btnFabrikaSil";
            this.btnFabrikaSil.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaSil.TabIndex = 3;
            this.btnFabrikaSil.Text = "Kayıt Sil";
            this.btnFabrikaSil.UseVisualStyleBackColor = true;
            this.btnFabrikaSil.Click += new System.EventHandler(this.btnFabrikaSil_Click);
            // 
            // btnFabrikaGuncelle
            // 
            this.btnFabrikaGuncelle.Location = new System.Drawing.Point(138, 235);
            this.btnFabrikaGuncelle.Name = "btnFabrikaGuncelle";
            this.btnFabrikaGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnFabrikaGuncelle.TabIndex = 4;
            this.btnFabrikaGuncelle.Text = "Güncelle";
            this.btnFabrikaGuncelle.UseVisualStyleBackColor = true;
            this.btnFabrikaGuncelle.Click += new System.EventHandler(this.btnFabrikaGuncelle_Click);
            // 
            // txtGuncelFabrikaAdi
            // 
            this.txtGuncelFabrikaAdi.Location = new System.Drawing.Point(12, 237);
            this.txtGuncelFabrikaAdi.Name = "txtGuncelFabrikaAdi";
            this.txtGuncelFabrikaAdi.Size = new System.Drawing.Size(120, 20);
            this.txtGuncelFabrikaAdi.TabIndex = 6;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(226, 325);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 12;
            this.lineShape2.X2 = 212;
            this.lineShape2.Y1 = 266;
            this.lineShape2.Y2 = 266;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 212;
            this.lineShape1.Y1 = 210;
            this.lineShape1.Y2 = 210;
            // 
            // txtYeniFabrikaAdi
            // 
            this.txtYeniFabrikaAdi.Location = new System.Drawing.Point(12, 294);
            this.txtYeniFabrikaAdi.Name = "txtYeniFabrikaAdi";
            this.txtYeniFabrikaAdi.Size = new System.Drawing.Size(120, 20);
            this.txtYeniFabrikaAdi.TabIndex = 8;
            // 
            // lblGuncelFabrikaAdi
            // 
            this.lblGuncelFabrikaAdi.AutoSize = true;
            this.lblGuncelFabrikaAdi.Location = new System.Drawing.Point(12, 218);
            this.lblGuncelFabrikaAdi.Name = "lblGuncelFabrikaAdi";
            this.lblGuncelFabrikaAdi.Size = new System.Drawing.Size(131, 13);
            this.lblGuncelFabrikaAdi.TabIndex = 9;
            this.lblGuncelFabrikaAdi.Text = "Güncel fabrika adı giriniz...";
            // 
            // lblYeniFabrikaAdi
            // 
            this.lblYeniFabrikaAdi.AutoSize = true;
            this.lblYeniFabrikaAdi.Location = new System.Drawing.Point(15, 275);
            this.lblYeniFabrikaAdi.Name = "lblYeniFabrikaAdi";
            this.lblYeniFabrikaAdi.Size = new System.Drawing.Size(118, 13);
            this.lblYeniFabrikaAdi.TabIndex = 10;
            this.lblYeniFabrikaAdi.Text = "Yeni fabrika adı giriniz...";
            this.lblYeniFabrikaAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FabrikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 325);
            this.Controls.Add(this.lblYeniFabrikaAdi);
            this.Controls.Add(this.lblGuncelFabrikaAdi);
            this.Controls.Add(this.txtYeniFabrikaAdi);
            this.Controls.Add(this.txtGuncelFabrikaAdi);
            this.Controls.Add(this.btnFabrikaGuncelle);
            this.Controls.Add(this.btnFabrikaSil);
            this.Controls.Add(this.btnFabrikaEkle);
            this.Controls.Add(this.lblSistemKayitliFabrikalar);
            this.Controls.Add(this.gvKayitliFabrikalar);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FabrikaForm";
            this.Text = "Fabrika İşlemleri";
            this.Load += new System.EventHandler(this.FabrikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKayitliFabrikalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvKayitliFabrikalar;
        private System.Windows.Forms.Label lblSistemKayitliFabrikalar;
        private System.Windows.Forms.Button btnFabrikaEkle;
        private System.Windows.Forms.Button btnFabrikaSil;
        private System.Windows.Forms.Button btnFabrikaGuncelle;
        private System.Windows.Forms.TextBox txtGuncelFabrikaAdi;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtYeniFabrikaAdi;
        private System.Windows.Forms.Label lblGuncelFabrikaAdi;
        private System.Windows.Forms.Label lblYeniFabrikaAdi;
    }
}