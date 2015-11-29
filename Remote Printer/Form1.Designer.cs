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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıcıKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTesisAdi = new System.Windows.Forms.ComboBox();
            this.lblTesisAdi = new System.Windows.Forms.Label();
            this.lblBantAdi = new System.Windows.Forms.Label();
            this.cmbBantAdi = new System.Windows.Forms.ComboBox();
            this.lblYaziciAdi = new System.Windows.Forms.Label();
            this.cmbYaziciAdi = new System.Windows.Forms.ComboBox();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.cmbBaglanti = new System.Windows.Forms.ComboBox();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıcıEkleToolStripMenuItem,
            this.yazıcıKaldırToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            this.menüToolStripMenuItem.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // yazıcıEkleToolStripMenuItem
            // 
            this.yazıcıEkleToolStripMenuItem.Name = "yazıcıEkleToolStripMenuItem";
            this.yazıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yazıcıEkleToolStripMenuItem.Text = "Yazıcı Ekle";
            // 
            // yazıcıKaldırToolStripMenuItem
            // 
            this.yazıcıKaldırToolStripMenuItem.Name = "yazıcıKaldırToolStripMenuItem";
            this.yazıcıKaldırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yazıcıKaldırToolStripMenuItem.Text = "Yazıcı Kaldır";
            // 
            // cmbTesisAdi
            // 
            this.cmbTesisAdi.FormattingEnabled = true;
            this.cmbTesisAdi.Location = new System.Drawing.Point(12, 49);
            this.cmbTesisAdi.Name = "cmbTesisAdi";
            this.cmbTesisAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbTesisAdi.TabIndex = 1;
            this.cmbTesisAdi.Text = "Tesis adı seçiniz...";
            // 
            // lblTesisAdi
            // 
            this.lblTesisAdi.AutoSize = true;
            this.lblTesisAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesisAdi.Location = new System.Drawing.Point(12, 33);
            this.lblTesisAdi.Name = "lblTesisAdi";
            this.lblTesisAdi.Size = new System.Drawing.Size(68, 13);
            this.lblTesisAdi.TabIndex = 2;
            this.lblTesisAdi.Text = "TESİS ADI";
            // 
            // lblBantAdi
            // 
            this.lblBantAdi.AutoSize = true;
            this.lblBantAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBantAdi.Location = new System.Drawing.Point(139, 33);
            this.lblBantAdi.Name = "lblBantAdi";
            this.lblBantAdi.Size = new System.Drawing.Size(65, 13);
            this.lblBantAdi.TabIndex = 4;
            this.lblBantAdi.Text = "BANT ADI";
            this.lblBantAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBantAdi
            // 
            this.cmbBantAdi.FormattingEnabled = true;
            this.cmbBantAdi.Location = new System.Drawing.Point(139, 49);
            this.cmbBantAdi.Name = "cmbBantAdi";
            this.cmbBantAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbBantAdi.TabIndex = 3;
            this.cmbBantAdi.Text = "Bant adı seçiniz...";
            this.cmbBantAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblYaziciAdi
            // 
            this.lblYaziciAdi.AutoSize = true;
            this.lblYaziciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaziciAdi.Location = new System.Drawing.Point(266, 33);
            this.lblYaziciAdi.Name = "lblYaziciAdi";
            this.lblYaziciAdi.Size = new System.Drawing.Size(72, 13);
            this.lblYaziciAdi.TabIndex = 6;
            this.lblYaziciAdi.Text = "YAZICI ADI";
            // 
            // cmbYaziciAdi
            // 
            this.cmbYaziciAdi.FormattingEnabled = true;
            this.cmbYaziciAdi.Location = new System.Drawing.Point(266, 49);
            this.cmbYaziciAdi.Name = "cmbYaziciAdi";
            this.cmbYaziciAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbYaziciAdi.TabIndex = 5;
            this.cmbYaziciAdi.Text = "Yazıcı adı seçiniz...";
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaglanti.Location = new System.Drawing.Point(393, 33);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(68, 13);
            this.lblBaglanti.TabIndex = 8;
            this.lblBaglanti.Text = "BAĞLANTI";
            // 
            // cmbBaglanti
            // 
            this.cmbBaglanti.FormattingEnabled = true;
            this.cmbBaglanti.Location = new System.Drawing.Point(393, 49);
            this.cmbBaglanti.Name = "cmbBaglanti";
            this.cmbBaglanti.Size = new System.Drawing.Size(121, 21);
            this.cmbBaglanti.TabIndex = 7;
            this.cmbBaglanti.Text = "Bağlantı seçiniz...";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 554);
            this.Controls.Add(this.lblBaglanti);
            this.Controls.Add(this.cmbBaglanti);
            this.Controls.Add(this.lblYaziciAdi);
            this.Controls.Add(this.cmbYaziciAdi);
            this.Controls.Add(this.lblBantAdi);
            this.Controls.Add(this.cmbBantAdi);
            this.Controls.Add(this.lblTesisAdi);
            this.Controls.Add(this.cmbTesisAdi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Remote Printer v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıcıKaldırToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTesisAdi;
        private System.Windows.Forms.Label lblTesisAdi;
        private System.Windows.Forms.Label lblBantAdi;
        private System.Windows.Forms.ComboBox cmbBantAdi;
        private System.Windows.Forms.Label lblYaziciAdi;
        private System.Windows.Forms.ComboBox cmbYaziciAdi;
        private System.Windows.Forms.Label lblBaglanti;
        private System.Windows.Forms.ComboBox cmbBaglanti;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

