using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            //class Sinif Adi
            //{
            //      [Erişim Belirteci] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirteci] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //      {
            //      Metot Komutlari
            //      }
            //}

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected  

            Calisan calisan1 = new Calisan(); 
            calisan1.Ad = "Okan";
            calisan1.Soyad = "Yurtsever";
            calisan1.No = 54158161;
            calisan1.Departman = "Bilişim";

            calisan1.CalisanBilgileri();

            Console.WriteLine("********************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Bektaş";
            calisan2.Soyad = "Yıldırım";
            calisan2.No = 54540199;
            calisan2.Departman = "Satış";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }

    }
}