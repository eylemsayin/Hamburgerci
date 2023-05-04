using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Models
{
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeleri { get; set; }

        public BoyutEnum Boyutu { get; set; }

        public int Adedi { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.MenuFiyati;

            switch (Boyutu)
            {
                case BoyutEnum.Orta:
                    ToplamTutar +=  ToplamTutar * 0.10M;
                    break;
                case BoyutEnum.Buyuk:
                    ToplamTutar += ToplamTutar * 0.20M;
                    break;
            }

            ToplamTutar *= Adedi;
            foreach (EkstraMalzeme item in EkstraMalzemeleri)
                ToplamTutar += item.EkstraFiyat;

        }

        public override string ToString()
        {
            if (EkstraMalzemeleri.Count <1)
            {
                return string.Format($"{SeciliMenusu.MenuFiyati} menü x {Adedi} Adet, {Boyutu} Boy, Toplam: {ToplamTutar.ToString("C2")}");
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (EkstraMalzeme item in EkstraMalzemeleri)
                    ekstraMalzemeler += item.EkstraAdi + ",";
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');

                return string.Format($"{SeciliMenusu.MenuFiyati} menü x {Adedi} Adet, {Boyutu} Boy, ({ekstraMalzemeler}), Toplam: {ToplamTutar.ToString("C2")}");
            }
        }
    }
}
