using Hamburgerci.Models;

namespace Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public Form1(List<Menu> gelenListe)
        //{
        //    InitializeComponent();
        //    _gelenListe = gelenListe;
        //}
       // private readonly List<Menu> _gelenListe;

        //List<Menu> musteriListesi = new List<Menu>();
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu {MenuAdi = "Big King", MenuFiyati = 50.75M },
             new Menu {MenuAdi = "Double King Chicken", MenuFiyati = 49.90M },
              new Menu {MenuAdi = "Big Royal", MenuFiyati = 55.75M },
               new Menu {MenuAdi = "Chicken King", MenuFiyati = 37.75M },
                new Menu {MenuAdi = "Köfteburger", MenuFiyati = 40.75M },
        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{ EkstraAdi = "Ketçap", EkstraFiyat= 1.00M},
            new EkstraMalzeme{ EkstraAdi = "mayonez", EkstraFiyat= 1.00M},
            new EkstraMalzeme{ EkstraAdi = "Ranch sos", EkstraFiyat= 2.00M},
            new EkstraMalzeme{ EkstraAdi = "BBQ sos", EkstraFiyat= 2.00M},
            new EkstraMalzeme{ EkstraAdi = "Hardal sos", EkstraFiyat= 2.00M},

        };
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            
                cmbMenuler.Items.Add(item);

            foreach (EkstraMalzeme item in ekstralar)

                flowLayoutPanel1.Controls.Add(new CheckBox() { AutoSize=false, Text = item.EkstraAdi, Tag = item, Width=Convert.ToInt32(flowLayoutPanel1.Width* 0.45) });

            foreach (Siparis item in mevcutSiparisler)

                lbxSiparisler.Items.Add(item);
            rdoKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;

            TutarHesapla();

             
           // lbxSiparisler.DataSource = _gelenListe;
            
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis siradakiSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += siradakiSiparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cmbMenuler.SelectedItem;
            if (rdoKucuk.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = BoyutEnum.Orta;
            else
                yeniSiparis.Boyutu = BoyutEnum.Buyuk;

            yeniSiparis.EkstraMalzemeleri = new List<EkstraMalzeme>();
            foreach (CheckBox kontrol in flowLayoutPanel1.Controls)
            {
                if(kontrol.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag);
            }

            yeniSiparis.Adedi = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla();

            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            rdoKucuk.Checked = true;

            //TODO: Metotlar.Temizle() metodunu tamamlayýnýz

            Metotlar.Temizle(this.Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dr=  MessageBox.Show("Toplam Tutar: " + (TutarHesapla()).ToString("C2") + "\nSatýn alma iþlemini onaylýyor musunuz", "sipariþ özeti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                tumSiparisler.AddRange(mevcutSiparisler);//sipariþ tamamlandýðýnda mevcut sipariþleri tum sipariþleri ekledi
                mevcutSiparisler.Clear();//mevcut sipariþler listesini temizliyor (geçici olarak sipariþleri tuttuðumuz liste)
                lbxSiparisler.Items.Clear(); //listboxý temizliyor

                TutarHesapla();//labedeki tutar deðerini yeniden hesaplayýp yazdýrýyoruz listboxda herhangi bir þey kalmadýðý için tutar TL 0,00 olacaktýr
                MessageBox.Show("sipariþiniz tamamlandý");
            }
            else
            {
                MessageBox.Show("iþleminiz iptal edildi");
            }
            
            

            
            //DialogResult result1= MessageBox.Show("Sipariþ Tamamlandý","",MessageBoxButtons.OKCancel);
            //if (result1== DialogResult.OK) 
            //{
            //    Form4 frm4 = new Form4();
            //    frm4.Show();
            //}
            
                
            
      

        }
    }
}