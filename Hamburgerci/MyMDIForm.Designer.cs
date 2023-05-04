namespace Hamburgerci
{
    partial class MyMDIForm
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
            this.msHAmburgerMenu = new System.Windows.Forms.MenuStrip();
            this.tsmSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTumSiparisleriGor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkleme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msHAmburgerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHAmburgerMenu
            // 
            this.msHAmburgerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisYonetimi,
            this.tsmUrunYonetimi});
            this.msHAmburgerMenu.Location = new System.Drawing.Point(0, 0);
            this.msHAmburgerMenu.Name = "msHAmburgerMenu";
            this.msHAmburgerMenu.Size = new System.Drawing.Size(800, 24);
            this.msHAmburgerMenu.TabIndex = 0;
            this.msHAmburgerMenu.Text = "menuStrip1";
            // 
            // tsmSiparisYonetimi
            // 
            this.tsmSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmTumSiparisleriGor});
            this.tsmSiparisYonetimi.Name = "tsmSiparisYonetimi";
            this.tsmSiparisYonetimi.Size = new System.Drawing.Size(103, 20);
            this.tsmSiparisYonetimi.Text = "Siparis Yönetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(180, 22);
            this.tsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmTumSiparisleriGor
            // 
            this.tsmTumSiparisleriGor.Name = "tsmTumSiparisleriGor";
            this.tsmTumSiparisleriGor.Size = new System.Drawing.Size(180, 22);
            this.tsmTumSiparisleriGor.Text = "Tüm Siparişleri Gör";
            this.tsmTumSiparisleriGor.Click += new System.EventHandler(this.tsmTumSiparisleriGor_Click);
            // 
            // tsmUrunYonetimi
            // 
            this.tsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkleme,
            this.tsmEkstraMalzemeEkle});
            this.tsmUrunYonetimi.Name = "tsmUrunYonetimi";
            this.tsmUrunYonetimi.Size = new System.Drawing.Size(95, 20);
            this.tsmUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tsmMenuEkleme
            // 
            this.tsmMenuEkleme.Name = "tsmMenuEkleme";
            this.tsmMenuEkleme.Size = new System.Drawing.Size(180, 22);
            this.tsmMenuEkleme.Text = "Menu Ekle";
            this.tsmMenuEkleme.Click += new System.EventHandler(this.tsmMenuEkleme_Click);
            // 
            // tsmEkstraMalzemeEkle
            // 
            this.tsmEkstraMalzemeEkle.Name = "tsmEkstraMalzemeEkle";
            this.tsmEkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmEkstraMalzemeEkle_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msHAmburgerMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msHAmburgerMenu;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.msHAmburgerMenu.ResumeLayout(false);
            this.msHAmburgerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msHAmburgerMenu;
        private ToolStripMenuItem tsmSiparisYonetimi;
        private ToolStripMenuItem tsmSiparisOlustur;
        private ToolStripMenuItem tsmTumSiparisleriGor;
        private ToolStripMenuItem tsmUrunYonetimi;
        private ToolStripMenuItem tsmMenuEkleme;
        private ToolStripMenuItem tsmEkstraMalzemeEkle;
    }
}