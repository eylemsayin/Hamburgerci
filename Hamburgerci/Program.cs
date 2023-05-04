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
            //Arkada�lar merhaba,
//Projede tamamlamad���m�z k�s�mlarda neler yap�lmas� gerekti�i a�a��daki gibidir.A�a��da yaz�lanlara g�re projeyi tamamlaman�z gerekmektedir.

//Kolayl�klar� dilerim.

//Sipari� Tamamla Butonu:

//            1.Bir MessageBox ile ilgili sipari�in toplam tutar�n� ekrana bast�rmal�s�n�z. E�er Tamam butonuna bas�l�rsa, mevcutSiparisler listesindeki ge�ici sipari�lerin tumSiparisler listesine eklenmesi gerekir.
//2.ListBox temizlenmeli.
//3.Ge�ici sipari�lerin tutuldu�u mevcutSiparisler listesi temizlenmeli.
//4.Toplam Tutar bilgisinin yan�nda g�r�nen Label 0,00 ? olarak g�ncellenmeli.
//5.Sipari� Tamamland� gibi bir mesaj ekrana bast�r�lmal�.
//6.Sipari�i tamamlama i�leminde MessageBox'ta �ptal butonuna bas�l�rsa, i�lem iptal edilmeli. ListBox'ta sipari�ler silinmemeli.


//Metotlar s�n�f�nda,

//1.Temizle isimli metot tamamlanmal�.
//2.Metot gerekli yerlerde �a��r�larak ilgili form kontrolleri temizlenmeli.
//3.Sipari� Ekle butonuna bas�ld���nda, rdoKucuk isimli RadioButton se�ili hale gelmeli.
//4.ComboBox'ta herhangi bir men� se�ilmemeli.
//5.Flow Layout Panel'de bulunan CheckBox'lardaki tikler kald�r�lmal�.

//Men� Ekle Formu

//1.Form1'de bulunan menuler listesine yeni bir men� eklenebilmeli.
//2.Eklenme i�lemi tamamland���nda MessageBox ile bilgi verilmeli.
//3.Temizle metodu ile ilgili kontroller temizlenmeli.

//Ekstra Malzeme Ekle Formu

//1.Form1'de bulunan ekstralar listesine yeni bir ekstra malzeme eklenebilmeli.
//2.Eklenme i�lemi tamamland���nda MessageBox ile bilgi verilmeli.
//3.Temizle metodu ile ilgili kontroller temizlenmeli.

//Form4'te Yap�lmas� Gereken ��lemler

//1.Form4 a��ld���nda,
//2.Form1'deki tumSiparisler listesinde bulunan sipari�ler listBox'ta bast�r�lmal�.
//2.T�m sipari�lerin toplam tutarlar� toplanarak ciro Label'�nda bast�r�lmal�.
//3.Sipari�lerdeki ekstra malzemelerin fiyatlar� toplanarak ekstra malzeme geliri Label'�nda bast�r�lmal�.
//4.Toplam sipari� say�s� Label'�nda listBox'ta bulunan sipari�lerinin say�s� bast�r�lmal�.
//5.Sat�� adedi Label'�nda tumSiparisler listesinde bulunan adetler toplanmal� ve bast�r�lmal�.
        }
    }
}