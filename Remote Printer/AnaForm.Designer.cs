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
            this.txtService = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
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
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(160, 179);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(100, 20);
            this.txtService.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Printer v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button button1;


    }
}

