using Hamburgerci.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            //EkstraMalzeme yeniMalzeme= new EkstraMalzeme();
            //yeniMalzeme.EkstraAdi = txtEkstraAdi.Text;
            //yeniMalzeme.EkstraFiyat = nmrEkstraFiyat.Value;
            //Form1.ekstralar.Add(yeniMalzeme);

            Form1.ekstralar.Add(new EkstraMalzeme { EkstraAdi = txtEkstraAdi.Text, EkstraFiyat = nmrEkstraFiyat.Value }); //2. yol
            Metotlar.Temizle(this.Controls);
            MessageBox.Show("Ekstra Malzeme eklendi");
        }
    }
}
