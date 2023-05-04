namespace Hamburgerci
{
    partial class Form3
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
            this.grpEkstraEkleme = new System.Windows.Forms.GroupBox();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.nmrEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraEkleme
            // 
            this.grpEkstraEkleme.Controls.Add(this.btnEkstraEkle);
            this.grpEkstraEkleme.Controls.Add(this.nmrEkstraFiyat);
            this.grpEkstraEkleme.Controls.Add(this.txtEkstraAdi);
            this.grpEkstraEkleme.Controls.Add(this.label2);
            this.grpEkstraEkleme.Controls.Add(this.label1);
            this.grpEkstraEkleme.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraEkleme.Name = "grpEkstraEkleme";
            this.grpEkstraEkleme.Size = new System.Drawing.Size(227, 153);
            this.grpEkstraEkleme.TabIndex = 1;
            this.grpEkstraEkleme.TabStop = false;
            this.grpEkstraEkleme.Text = "EKSTRA MALZEME EKLEME PANELİ";
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(107, 97);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(87, 37);
            this.btnEkstraEkle.TabIndex = 4;
            this.btnEkstraEkle.Text = "EKSTRA EKLE";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // nmrEkstraFiyat
            // 
            this.nmrEkstraFiyat.Location = new System.Drawing.Point(74, 68);
            this.nmrEkstraFiyat.Name = "nmrEkstraFiyat";
            this.nmrEkstraFiyat.Size = new System.Drawing.Size(120, 23);
            this.nmrEkstraFiyat.TabIndex = 3;
            // 
            // txtEkstraAdi
            // 
            this.txtEkstraAdi.Location = new System.Drawing.Point(74, 36);
            this.txtEkstraAdi.Name = "txtEkstraAdi";
            this.txtEkstraAdi.Size = new System.Drawing.Size(120, 23);
            this.txtEkstraAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 180);
            this.Controls.Add(this.grpEkstraEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpEkstraEkleme.ResumeLayout(false);
            this.grpEkstraEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpEkstraEkleme;
        private Button btnEkstraEkle;
        private NumericUpDown nmrEkstraFiyat;
        private TextBox txtEkstraAdi;
        private Label label2;
        private Label label1;
    }
}