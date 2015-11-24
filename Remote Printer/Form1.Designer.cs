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
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabYazdir = new System.Windows.Forms.TabPage();
            this.lblVardiyaKodu = new System.Windows.Forms.Label();
            this.lblRobotKodu = new System.Windows.Forms.Label();
            this.lblKaliteKodu = new System.Windows.Forms.Label();
            this.lblRenkTonu = new System.Windows.Forms.Label();
            this.lblKalibre = new System.Windows.Forms.Label();
            this.lblKalite = new System.Windows.Forms.Label();
            this.lblUrunIsim = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.cmbYazici = new System.Windows.Forms.ComboBox();
            this.tabEtiketOlusturma = new System.Windows.Forms.TabPage();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtKalite = new System.Windows.Forms.TextBox();
            this.txtKalibre = new System.Windows.Forms.TextBox();
            this.txtRenkTonu = new System.Windows.Forms.TextBox();
            this.txtKaliteKodu = new System.Windows.Forms.TextBox();
            this.txtRobotKodu = new System.Windows.Forms.TextBox();
            this.txtVardiyaKodu = new System.Windows.Forms.TextBox();
            this.txtUrunIsim = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabYazdir.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıcıEkleToolStripMenuItem,
            this.yazıcıKaldırToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // yazıcıEkleToolStripMenuItem
            // 
            this.yazıcıEkleToolStripMenuItem.Name = "yazıcıEkleToolStripMenuItem";
            this.yazıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.yazıcıEkleToolStripMenuItem.Text = "Yazıcı Ekle";
            // 
            // yazıcıKaldırToolStripMenuItem
            // 
            this.yazıcıKaldırToolStripMenuItem.Name = "yazıcıKaldırToolStripMenuItem";
            this.yazıcıKaldırToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.yazıcıKaldırToolStripMenuItem.Text = "Yazıcı Kaldır";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabYazdir);
            this.tabControl1.Controls.Add(this.tabEtiketOlusturma);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 526);
            this.tabControl1.TabIndex = 1;
            // 
            // tabYazdir
            // 
            this.tabYazdir.Controls.Add(this.txtUrunIsim);
            this.tabYazdir.Controls.Add(this.txtVardiyaKodu);
            this.tabYazdir.Controls.Add(this.txtRobotKodu);
            this.tabYazdir.Controls.Add(this.txtKaliteKodu);
            this.tabYazdir.Controls.Add(this.txtRenkTonu);
            this.tabYazdir.Controls.Add(this.txtKalibre);
            this.tabYazdir.Controls.Add(this.txtKalite);
            this.tabYazdir.Controls.Add(this.txtBarkodNo);
            this.tabYazdir.Controls.Add(this.lblVardiyaKodu);
            this.tabYazdir.Controls.Add(this.lblRobotKodu);
            this.tabYazdir.Controls.Add(this.lblKaliteKodu);
            this.tabYazdir.Controls.Add(this.lblRenkTonu);
            this.tabYazdir.Controls.Add(this.lblKalibre);
            this.tabYazdir.Controls.Add(this.lblKalite);
            this.tabYazdir.Controls.Add(this.lblUrunIsim);
            this.tabYazdir.Controls.Add(this.lblBarkodNo);
            this.tabYazdir.Controls.Add(this.cmbYazici);
            this.tabYazdir.Location = new System.Drawing.Point(4, 22);
            this.tabYazdir.Name = "tabYazdir";
            this.tabYazdir.Padding = new System.Windows.Forms.Padding(3);
            this.tabYazdir.Size = new System.Drawing.Size(536, 500);
            this.tabYazdir.TabIndex = 0;
            this.tabYazdir.Text = "Yazdır";
            this.tabYazdir.UseVisualStyleBackColor = true;
            // 
            // lblVardiyaKodu
            // 
            this.lblVardiyaKodu.AutoSize = true;
            this.lblVardiyaKodu.Location = new System.Drawing.Point(277, 207);
            this.lblVardiyaKodu.Name = "lblVardiyaKodu";
            this.lblVardiyaKodu.Size = new System.Drawing.Size(73, 13);
            this.lblVardiyaKodu.TabIndex = 8;
            this.lblVardiyaKodu.Text = "Vardiya Kodu:";
            // 
            // lblRobotKodu
            // 
            this.lblRobotKodu.AutoSize = true;
            this.lblRobotKodu.Location = new System.Drawing.Point(283, 172);
            this.lblRobotKodu.Name = "lblRobotKodu";
            this.lblRobotKodu.Size = new System.Drawing.Size(67, 13);
            this.lblRobotKodu.TabIndex = 7;
            this.lblRobotKodu.Text = "Robot Kodu:";
            // 
            // lblKaliteKodu
            // 
            this.lblKaliteKodu.AutoSize = true;
            this.lblKaliteKodu.Location = new System.Drawing.Point(286, 136);
            this.lblKaliteKodu.Name = "lblKaliteKodu";
            this.lblKaliteKodu.Size = new System.Drawing.Size(64, 13);
            this.lblKaliteKodu.TabIndex = 6;
            this.lblKaliteKodu.Text = "Kalite Kodu:";
            // 
            // lblRenkTonu
            // 
            this.lblRenkTonu.AutoSize = true;
            this.lblRenkTonu.Location = new System.Drawing.Point(286, 101);
            this.lblRenkTonu.Name = "lblRenkTonu";
            this.lblRenkTonu.Size = new System.Drawing.Size(64, 13);
            this.lblRenkTonu.TabIndex = 5;
            this.lblRenkTonu.Text = "Renk Tonu:";
            // 
            // lblKalibre
            // 
            this.lblKalibre.AutoSize = true;
            this.lblKalibre.Location = new System.Drawing.Point(46, 207);
            this.lblKalibre.Name = "lblKalibre";
            this.lblKalibre.Size = new System.Drawing.Size(42, 13);
            this.lblKalibre.TabIndex = 4;
            this.lblKalibre.Text = "Kalibre:";
            // 
            // lblKalite
            // 
            this.lblKalite.AutoSize = true;
            this.lblKalite.Location = new System.Drawing.Point(52, 172);
            this.lblKalite.Name = "lblKalite";
            this.lblKalite.Size = new System.Drawing.Size(36, 13);
            this.lblKalite.TabIndex = 3;
            this.lblKalite.Text = "Kalite:";
            // 
            // lblUrunIsim
            // 
            this.lblUrunIsim.AutoSize = true;
            this.lblUrunIsim.Location = new System.Drawing.Point(34, 136);
            this.lblUrunIsim.Name = "lblUrunIsim";
            this.lblUrunIsim.Size = new System.Drawing.Size(54, 13);
            this.lblUrunIsim.TabIndex = 2;
            this.lblUrunIsim.Text = "Ürün İsim:";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(27, 101);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(61, 13);
            this.lblBarkodNo.TabIndex = 1;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // cmbYazici
            // 
            this.cmbYazici.FormattingEnabled = true;
            this.cmbYazici.Location = new System.Drawing.Point(123, 36);
            this.cmbYazici.Name = "cmbYazici";
            this.cmbYazici.Size = new System.Drawing.Size(121, 21);
            this.cmbYazici.TabIndex = 0;
            this.cmbYazici.Text = "Yazıcı seçiniz...";
            // 
            // tabEtiketOlusturma
            // 
            this.tabEtiketOlusturma.Location = new System.Drawing.Point(4, 22);
            this.tabEtiketOlusturma.Name = "tabEtiketOlusturma";
            this.tabEtiketOlusturma.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtiketOlusturma.Size = new System.Drawing.Size(602, 500);
            this.tabEtiketOlusturma.TabIndex = 1;
            this.tabEtiketOlusturma.Text = "Etiket Oluşturma";
            this.tabEtiketOlusturma.UseVisualStyleBackColor = true;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(94, 98);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(150, 20);
            this.txtBarkodNo.TabIndex = 9;
            // 
            // txtKalite
            // 
            this.txtKalite.Location = new System.Drawing.Point(94, 169);
            this.txtKalite.Name = "txtKalite";
            this.txtKalite.Size = new System.Drawing.Size(150, 20);
            this.txtKalite.TabIndex = 10;
            // 
            // txtKalibre
            // 
            this.txtKalibre.Location = new System.Drawing.Point(94, 204);
            this.txtKalibre.Name = "txtKalibre";
            this.txtKalibre.Size = new System.Drawing.Size(150, 20);
            this.txtKalibre.TabIndex = 11;
            // 
            // txtRenkTonu
            // 
            this.txtRenkTonu.Location = new System.Drawing.Point(356, 98);
            this.txtRenkTonu.Name = "txtRenkTonu";
            this.txtRenkTonu.Size = new System.Drawing.Size(150, 20);
            this.txtRenkTonu.TabIndex = 12;
            // 
            // txtKaliteKodu
            // 
            this.txtKaliteKodu.Location = new System.Drawing.Point(356, 133);
            this.txtKaliteKodu.Name = "txtKaliteKodu";
            this.txtKaliteKodu.Size = new System.Drawing.Size(150, 20);
            this.txtKaliteKodu.TabIndex = 13;
            // 
            // txtRobotKodu
            // 
            this.txtRobotKodu.Location = new System.Drawing.Point(356, 169);
            this.txtRobotKodu.Name = "txtRobotKodu";
            this.txtRobotKodu.Size = new System.Drawing.Size(150, 20);
            this.txtRobotKodu.TabIndex = 14;
            // 
            // txtVardiyaKodu
            // 
            this.txtVardiyaKodu.Location = new System.Drawing.Point(356, 204);
            this.txtVardiyaKodu.Name = "txtVardiyaKodu";
            this.txtVardiyaKodu.Size = new System.Drawing.Size(150, 20);
            this.txtVardiyaKodu.TabIndex = 15;
            // 
            // txtUrunIsim
            // 
            this.txtUrunIsim.Location = new System.Drawing.Point(94, 133);
            this.txtUrunIsim.Name = "txtUrunIsim";
            this.txtUrunIsim.Size = new System.Drawing.Size(150, 20);
            this.txtUrunIsim.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Remote Printer v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabYazdir.ResumeLayout(false);
            this.tabYazdir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıcıKaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabYazdir;
        private System.Windows.Forms.TabPage tabEtiketOlusturma;
        private System.Windows.Forms.Label lblRenkTonu;
        private System.Windows.Forms.Label lblKalibre;
        private System.Windows.Forms.Label lblKalite;
        private System.Windows.Forms.Label lblUrunIsim;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.ComboBox cmbYazici;
        private System.Windows.Forms.Label lblVardiyaKodu;
        private System.Windows.Forms.Label lblRobotKodu;
        private System.Windows.Forms.Label lblKaliteKodu;
        private System.Windows.Forms.TextBox txtUrunIsim;
        private System.Windows.Forms.TextBox txtVardiyaKodu;
        private System.Windows.Forms.TextBox txtRobotKodu;
        private System.Windows.Forms.TextBox txtKaliteKodu;
        private System.Windows.Forms.TextBox txtRenkTonu;
        private System.Windows.Forms.TextBox txtKalibre;
        private System.Windows.Forms.TextBox txtKalite;
        private System.Windows.Forms.TextBox txtBarkodNo;
    }
}

