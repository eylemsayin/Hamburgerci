namespace Hamburgerci
{
    partial class Form4
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
            this.lbxTumSiparişler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.grpToplamSiparisSayisi = new System.Windows.Forms.GroupBox();
            this.lblToplamSiparisSayisi = new System.Windows.Forms.Label();
            this.grpEkstraGeliri = new System.Windows.Forms.GroupBox();
            this.lblEkstraMalzemeGeliri = new System.Windows.Forms.Label();
            this.grpSatilanUrunSayisi = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrunSayisi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpToplamSiparisSayisi.SuspendLayout();
            this.grpEkstraGeliri.SuspendLayout();
            this.grpSatilanUrunSayisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // lbxTumSiparişler
            // 
            this.lbxTumSiparişler.FormattingEnabled = true;
            this.lbxTumSiparişler.HorizontalScrollbar = true;
            this.lbxTumSiparişler.ItemHeight = 15;
            this.lbxTumSiparişler.Location = new System.Drawing.Point(12, 37);
            this.lbxTumSiparişler.Name = "lbxTumSiparişler";
            this.lbxTumSiparişler.Size = new System.Drawing.Size(205, 274);
            this.lbxTumSiparişler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(325, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(11, 33);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(37, 15);
            this.lblCiro.TabIndex = 0;
            this.lblCiro.Text = "0,00 ₺";
            // 
            // grpToplamSiparisSayisi
            // 
            this.grpToplamSiparisSayisi.Controls.Add(this.lblToplamSiparisSayisi);
            this.grpToplamSiparisSayisi.Location = new System.Drawing.Point(325, 101);
            this.grpToplamSiparisSayisi.Name = "grpToplamSiparisSayisi";
            this.grpToplamSiparisSayisi.Size = new System.Drawing.Size(200, 51);
            this.grpToplamSiparisSayisi.TabIndex = 0;
            this.grpToplamSiparisSayisi.TabStop = false;
            this.grpToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            this.lblToplamSiparisSayisi.AutoSize = true;
            this.lblToplamSiparisSayisi.Location = new System.Drawing.Point(11, 19);
            this.lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            this.lblToplamSiparisSayisi.Size = new System.Drawing.Size(13, 15);
            this.lblToplamSiparisSayisi.TabIndex = 1;
            this.lblToplamSiparisSayisi.Text = "0";
            // 
            // grpEkstraGeliri
            // 
            this.grpEkstraGeliri.Controls.Add(this.lblEkstraMalzemeGeliri);
            this.grpEkstraGeliri.Location = new System.Drawing.Point(325, 173);
            this.grpEkstraGeliri.Name = "grpEkstraGeliri";
            this.grpEkstraGeliri.Size = new System.Drawing.Size(200, 61);
            this.grpEkstraGeliri.TabIndex = 3;
            this.grpEkstraGeliri.TabStop = false;
            this.grpEkstraGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            this.lblEkstraMalzemeGeliri.AutoSize = true;
            this.lblEkstraMalzemeGeliri.Location = new System.Drawing.Point(11, 19);
            this.lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            this.lblEkstraMalzemeGeliri.Size = new System.Drawing.Size(37, 15);
            this.lblEkstraMalzemeGeliri.TabIndex = 2;
            this.lblEkstraMalzemeGeliri.Text = "0,00 ₺";
            // 
            // grpSatilanUrunSayisi
            // 
            this.grpSatilanUrunSayisi.Controls.Add(this.lblSatilanUrunSayisi);
            this.grpSatilanUrunSayisi.Location = new System.Drawing.Point(325, 240);
            this.grpSatilanUrunSayisi.Name = "grpSatilanUrunSayisi";
            this.grpSatilanUrunSayisi.Size = new System.Drawing.Size(211, 58);
            this.grpSatilanUrunSayisi.TabIndex = 3;
            this.grpSatilanUrunSayisi.TabStop = false;
            this.grpSatilanUrunSayisi.Text = "Satılan Ürün Sayısı";
            // 
            // lblSatilanUrunSayisi
            // 
            this.lblSatilanUrunSayisi.AutoSize = true;
            this.lblSatilanUrunSayisi.Location = new System.Drawing.Point(11, 19);
            this.lblSatilanUrunSayisi.Name = "lblSatilanUrunSayisi";
            this.lblSatilanUrunSayisi.Size = new System.Drawing.Size(13, 15);
            this.lblSatilanUrunSayisi.TabIndex = 3;
            this.lblSatilanUrunSayisi.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 345);
            this.Controls.Add(this.grpSatilanUrunSayisi);
            this.Controls.Add(this.grpEkstraGeliri);
            this.Controls.Add(this.grpToplamSiparisSayisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxTumSiparişler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpToplamSiparisSayisi.ResumeLayout(false);
            this.grpToplamSiparisSayisi.PerformLayout();
            this.grpEkstraGeliri.ResumeLayout(false);
            this.grpEkstraGeliri.PerformLayout();
            this.grpSatilanUrunSayisi.ResumeLayout(false);
            this.grpSatilanUrunSayisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lbxTumSiparişler;
        private GroupBox groupBox1;
        private Label lblCiro;
        private GroupBox grpToplamSiparisSayisi;
        private Label lblToplamSiparisSayisi;
        private GroupBox grpEkstraGeliri;
        private Label lblEkstraMalzemeGeliri;
        private GroupBox grpSatilanUrunSayisi;
        private Label lblSatilanUrunSayisi;
    }
}