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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Menu yeniMenu = new Menu(); 
            //yeniMenu.MenuAdi = txtMenuAdi.Text;
            //yeniMenu.MenuFiyati = nmrFiyat.Value;

            //Form1.menuler.Add(yeniMenu);

            Form1.menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, MenuFiyati = nmrFiyat.Value }); //2. yol
            Metotlar.Temizle(this.Controls);
            MessageBox.Show("menü başarıyla eklendi");

           


        }
    }
}
