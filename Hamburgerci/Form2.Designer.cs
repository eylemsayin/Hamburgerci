namespace Hamburgerci
{
    partial class Form2
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
            this.grpMenuEkleme = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nmrFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuEkleme
            // 
            this.grpMenuEkleme.Controls.Add(this.btnEkle);
            this.grpMenuEkleme.Controls.Add(this.nmrFiyat);
            this.grpMenuEkleme.Controls.Add(this.txtMenuAdi);
            this.grpMenuEkleme.Controls.Add(this.label2);
            this.grpMenuEkleme.Controls.Add(this.label1);
            this.grpMenuEkleme.Location = new System.Drawing.Point(0, 0);
            this.grpMenuEkleme.Name = "grpMenuEkleme";
            this.grpMenuEkleme.Size = new System.Drawing.Size(227, 153);
            this.grpMenuEkleme.TabIndex = 0;
            this.grpMenuEkleme.TabStop = false;
            this.grpMenuEkleme.Text = "MENÜ EKLEME PANELİ";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(112, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 37);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "MENÜ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nmrFiyat
            // 
            this.nmrFiyat.Location = new System.Drawing.Point(74, 68);
            this.nmrFiyat.Name = "nmrFiyat";
            this.nmrFiyat.Size = new System.Drawing.Size(120, 23);
            this.nmrFiyat.TabIndex = 3;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(74, 36);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(120, 23);
            this.txtMenuAdi.TabIndex = 2;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 166);
            this.Controls.Add(this.grpMenuEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMenuEkleme.ResumeLayout(false);
            this.grpMenuEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMenuEkleme;
        private Button btnEkle;
        private NumericUpDown nmrFiyat;
        private TextBox txtMenuAdi;
        private Label label2;
        private Label label1;
    }
}