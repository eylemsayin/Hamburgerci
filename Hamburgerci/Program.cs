using Hamburgerci.Models;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System;

namespace Hamburgerci
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MyMDIForm());
            //Arkadaþlar merhaba,
//Projede tamamlamadýðýmýz kýsýmlarda neler yapýlmasý gerektiði aþaðýdaki gibidir.Aþaðýda yazýlanlara göre projeyi tamamlamanýz gerekmektedir.

//Kolaylýklarý dilerim.

//Sipariþ Tamamla Butonu:

//            1.Bir MessageBox ile ilgili sipariþin toplam tutarýný ekrana bastýrmalýsýnýz. Eðer Tamam butonuna basýlýrsa, mevcutSiparisler listesindeki geçici sipariþlerin tumSiparisler listesine eklenmesi gerekir.
//2.ListBox temizlenmeli.
//3.Geçici sipariþlerin tutulduðu mevcutSiparisler listesi temizlenmeli.
//4.Toplam Tutar bilgisinin yanýnda görünen Label 0,00 ? olarak güncellenmeli.
//5.Sipariþ Tamamlandý gibi bir mesaj ekrana bastýrýlmalý.
//6.Sipariþi tamamlama iþleminde MessageBox'ta Ýptal butonuna basýlýrsa, iþlem iptal edilmeli. ListBox'ta sipariþler silinmemeli.


//Metotlar sýnýfýnda,

//1.Temizle isimli metot tamamlanmalý.
//2.Metot gerekli yerlerde çaðýrýlarak ilgili form kontrolleri temizlenmeli.
//3.Sipariþ Ekle butonuna basýldýðýnda, rdoKucuk isimli RadioButton seçili hale gelmeli.
//4.ComboBox'ta herhangi bir menü seçilmemeli.
//5.Flow Layout Panel'de bulunan CheckBox'lardaki tikler kaldýrýlmalý.

//Menü Ekle Formu

//1.Form1'de bulunan menuler listesine yeni bir menü eklenebilmeli.
//2.Eklenme iþlemi tamamlandýðýnda MessageBox ile bilgi verilmeli.
//3.Temizle metodu ile ilgili kontroller temizlenmeli.

//Ekstra Malzeme Ekle Formu

//1.Form1'de bulunan ekstralar listesine yeni bir ekstra malzeme eklenebilmeli.
//2.Eklenme iþlemi tamamlandýðýnda MessageBox ile bilgi verilmeli.
//3.Temizle metodu ile ilgili kontroller temizlenmeli.

//Form4'te Yapýlmasý Gereken Ýþlemler

//1.Form4 açýldýðýnda,
//2.Form1'deki tumSiparisler listesinde bulunan sipariþler listBox'ta bastýrýlmalý.
//2.Tüm sipariþlerin toplam tutarlarý toplanarak ciro Label'ýnda bastýrýlmalý.
//3.Sipariþlerdeki ekstra malzemelerin fiyatlarý toplanarak ekstra malzeme geliri Label'ýnda bastýrýlmalý.
//4.Toplam sipariþ sayýsý Label'ýnda listBox'ta bulunan sipariþlerinin sayýsý bastýrýlmalý.
//5.Satýþ adedi Label'ýnda tumSiparisler listesinde bulunan adetler toplanmalý ve bastýrýlmalý.
        }
    }
}