using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Bir sayı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac =1;
            // int toplam = 0;
            // while (sayac<= sayi)
            // {
            //     toplam+=sayac;
            //     sayac++;
            // }
            // Console.WriteLine("Ortalama: "+toplam/sayi);

            // char karakter ='a';
            // while (karakter<'z')
            // {
            //     Console.Write(karakter);
            //     karakter++;
            // }

            Console.WriteLine("******** Foreach ********");

            string[] arabalar = {"BMw","Ford","Toyata","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
