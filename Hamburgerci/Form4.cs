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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }
      
        

        private void Form4_Load(object sender, EventArgs e)
        {
            lbxTumSiparişler.Items.Clear(); 
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                satisAdedi += siparis.Adedi;

                foreach (EkstraMalzeme ekstra in siparis.EkstraMalzemeleri)
                {
                    ekstraMalzemeGeliri += ekstra.EkstraFiyat;
                }

                lbxTumSiparişler.Items.Add(siparis);
            }
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text=ekstraMalzemeGeliri.ToString("C2");
            lblToplamSiparisSayisi.Text = lbxTumSiparişler.Items.Count.ToString();
            lblSatilanUrunSayisi.Text = satisAdedi.ToString();
        }

    }
}
