namespace Remote_Printer
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabrikaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesisİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımKılavuzuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFabrika = new System.Windows.Forms.ComboBox();
            this.lblFabrika = new System.Windows.Forms.Label();
            this.lblTesis = new System.Windows.Forms.Label();
            this.cmbTesis = new System.Windows.Forms.ComboBox();
            this.lblBant = new System.Windows.Forms.Label();
            this.cmbBant = new System.Windows.Forms.ComboBox();
            this.lblYazici = new System.Windows.Forms.Label();
            this.cmbYazici = new System.Windows.Forms.ComboBox();
            this.gvKanal = new System.Windows.Forms.DataGridView();
            this.pbOnizleme = new System.Windows.Forms.PictureBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnizleme)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabrikaİşlemleriToolStripMenuItem,
            this.tesisİşlemleriToolStripMenuItem,
            this.bantİşlemleriToolStripMenuItem,
            this.yazıcıİşlemleriToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // fabrikaİşlemleriToolStripMenuItem
            // 
            this.fabrikaİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fabrikaİşlemleriToolStripMenuItem.Image")));
            this.fabrikaİşlemleriToolStripMenuItem.Name = "fabrikaİşlemleriToolStripMenuItem";
            this.fabrikaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fabrikaİşlemleriToolStripMenuItem.Text = "Fabrika İşlemleri";
            this.fabrikaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.fabrikaİşlemleriToolStripMenuItem_Click);
            // 
            // tesisİşlemleriToolStripMenuItem
            // 
            this.tesisİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tesisİşlemleriToolStripMenuItem.Image")));
            this.tesisİşlemleriToolStripMenuItem.Name = "tesisİşlemleriToolStripMenuItem";
            this.tesisİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tesisİşlemleriToolStripMenuItem.Text = "Tesis İşlemleri";
            this.tesisİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.tesisİşlemleriToolStripMenuItem_Click);
            // 
            // bantİşlemleriToolStripMenuItem
            // 
            this.bantİşlemleriToolStripMenuItem.Image = global::Remote_Printer.Properties.Resources.automatic_conveyor_belt;
            this.bantİşlemleriToolStripMenuItem.Name = "bantİşlemleriToolStripMenuItem";
            this.bantİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bantİşlemleriToolStripMenuItem.Text = "Bant İşlemleri";
            this.bantİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.bantİşlemleriToolStripMenuItem_Click);
            // 
            // yazıcıİşlemleriToolStripMenuItem
            // 
            this.yazıcıİşlemleriToolStripMenuItem.Image = global::Remote_Printer.Properties.Resources._1455725048_033_PrinterText;
            this.yazıcıİşlemleriToolStripMenuItem.Name = "yazıcıİşlemleriToolStripMenuItem";
            this.yazıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.yazıcıİşlemleriToolStripMenuItem.Text = "Yazıcı İşlemleri";
            this.yazıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.yazıcıİşlemleriToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanımKılavuzuToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // kullanımKılavuzuToolStripMenuItem
            // 
            this.kullanımKılavuzuToolStripMenuItem.Image = global::Remote_Printer.Properties.Resources._1455730030_document_text_information;
            this.kullanımKılavuzuToolStripMenuItem.Name = "kullanımKılavuzuToolStripMenuItem";
            this.kullanımKılavuzuToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanımKılavuzuToolStripMenuItem.Text = "Kullanım Kılavuzu";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::Remote_Printer.Properties.Resources._1455730231_information;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // cmbFabrika
            // 
            this.cmbFabrika.FormattingEnabled = true;
            this.cmbFabrika.Location = new System.Drawing.Point(12, 56);
            this.cmbFabrika.Name = "cmbFabrika";
            this.cmbFabrika.Size = new System.Drawing.Size(121, 21);
            this.cmbFabrika.TabIndex = 1;
            this.cmbFabrika.Text = "Fabrika seçiniz...";
            this.cmbFabrika.SelectedIndexChanged += new System.EventHandler(this.cmbFabrika_SelectedIndexChanged);
            // 
            // lblFabrika
            // 
            this.lblFabrika.AutoSize = true;
            this.lblFabrika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFabrika.Location = new System.Drawing.Point(9, 37);
            this.lblFabrika.Name = "lblFabrika";
            this.lblFabrika.Size = new System.Drawing.Size(59, 13);
            this.lblFabrika.TabIndex = 2;
            this.lblFabrika.Text = "FABRİKA";
            // 
            // lblTesis
            // 
            this.lblTesis.AutoSize = true;
            this.lblTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesis.Location = new System.Drawing.Point(184, 37);
            this.lblTesis.Name = "lblTesis";
            this.lblTesis.Size = new System.Drawing.Size(43, 13);
            this.lblTesis.TabIndex = 4;
            this.lblTesis.Text = "TESİS";
            // 
            // cmbTesis
            // 
            this.cmbTesis.FormattingEnabled = true;
            this.cmbTesis.Location = new System.Drawing.Point(187, 56);
            this.cmbTesis.Name = "cmbTesis";
            this.cmbTesis.Size = new System.Drawing.Size(121, 21);
            this.cmbTesis.TabIndex = 3;
            this.cmbTesis.Text = "Tesis seçiniz...";
            this.cmbTesis.SelectedIndexChanged += new System.EventHandler(this.cmbTesis_SelectedIndexChanged);
            // 
            // lblBant
            // 
            this.lblBant.AutoSize = true;
            this.lblBant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBant.Location = new System.Drawing.Point(359, 37);
            this.lblBant.Name = "lblBant";
            this.lblBant.Size = new System.Drawing.Size(40, 13);
            this.lblBant.TabIndex = 6;
            this.lblBant.Text = "BANT";
            // 
            // cmbBant
            // 
            this.cmbBant.FormattingEnabled = true;
            this.cmbBant.Location = new System.Drawing.Point(362, 56);
            this.cmbBant.Name = "cmbBant";
            this.cmbBant.Size = new System.Drawing.Size(121, 21);
            this.cmbBant.TabIndex = 5;
            this.cmbBant.Text = "Bant seçiniz...";
            this.cmbBant.SelectedIndexChanged += new System.EventHandler(this.cmbBant_SelectedIndexChanged);
            // 
            // lblYazici
            // 
            this.lblYazici.AutoSize = true;
            this.lblYazici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazici.Location = new System.Drawing.Point(534, 37);
            this.lblYazici.Name = "lblYazici";
            this.lblYazici.Size = new System.Drawing.Size(47, 13);
            this.lblYazici.TabIndex = 8;
            this.lblYazici.Text = "YAZICI";
            // 
            // cmbYazici
            // 
            this.cmbYazici.FormattingEnabled = true;
            this.cmbYazici.Location = new System.Drawing.Point(537, 56);
            this.cmbYazici.Name = "cmbYazici";
            this.cmbYazici.Size = new System.Drawing.Size(121, 21);
            this.cmbYazici.TabIndex = 7;
            this.cmbYazici.Text = "Yazıcı seçiniz...";
            this.cmbYazici.SelectedIndexChanged += new System.EventHandler(this.cmbYazici_SelectedIndexChanged);
            // 
            // gvKanal
            // 
            this.gvKanal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKanal.Location = new System.Drawing.Point(12, 83);
            this.gvKanal.Name = "gvKanal";
            this.gvKanal.Size = new System.Drawing.Size(648, 228);
            this.gvKanal.TabIndex = 9;
            this.gvKanal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKanal_CellClick);
            // 
            // pbOnizleme
            // 
            this.pbOnizleme.Location = new System.Drawing.Point(12, 317);
            this.pbOnizleme.Name = "pbOnizleme";
            this.pbOnizleme.Size = new System.Drawing.Size(648, 72);
            this.pbOnizleme.TabIndex = 10;
            this.pbOnizleme.TabStop = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.Red;
            this.btnYazdir.Location = new System.Drawing.Point(554, 396);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(106, 37);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 445);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.pbOnizleme);
            this.Controls.Add(this.gvKanal);
            this.Controls.Add(this.lblYazici);
            this.Controls.Add(this.cmbYazici);
            this.Controls.Add(this.lblBant);
            this.Controls.Add(this.cmbBant);
            this.Controls.Add(this.lblTesis);
            this.Controls.Add(this.cmbTesis);
            this.Controls.Add(this.lblFabrika);
            this.Controls.Add(this.cmbFabrika);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Printer v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnizleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabrikaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesisİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanımKılavuzuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbFabrika;
        private System.Windows.Forms.Label lblFabrika;
        private System.Windows.Forms.Label lblTesis;
        private System.Windows.Forms.ComboBox cmbTesis;
        private System.Windows.Forms.Label lblBant;
        private System.Windows.Forms.ComboBox cmbBant;
        private System.Windows.Forms.Label lblYazici;
        private System.Windows.Forms.ComboBox cmbYazici;
        private System.Windows.Forms.DataGridView gvKanal;
        private System.Windows.Forms.PictureBox pbOnizleme;
        private System.Windows.Forms.Button btnYazdir;


    }
}

