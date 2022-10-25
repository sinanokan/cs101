using System;
using System.Collections;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int enBuyuk = 0, enKucuk = 0;

            Console.WriteLine("Lütfen 20 adet sayı giriniz.");

            for (int i = 0; i < sayilar.Length; i++)
            {
                int deger = 0;
                Console.Write("{0}. sayıyı giriniz:",i+1);
                
                if(int.TryParse(Console.ReadLine(),out deger))
                    sayilar[i] = deger;
                else
                {
                    Console.WriteLine("Lütfen sayısal bir deger giriniz!");
                    i--;
                }
            }

            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
                enKucuk += sayilar[i];
            Console.WriteLine("En küçük 3 tane sayını ortalaması: "+enKucuk/3);

            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
                enBuyuk += sayilar[i];
            Console.WriteLine("En büyük 3 tane sayının ortalamsı: "+enBuyuk/3);

            Console.WriteLine("Ortalamalar toplamı:"+(enBuyuk+enKucuk)/3);
            
            
        }
    }
}
