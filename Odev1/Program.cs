using System;

namespace Odev1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Soru4();
        }

        static void Soru1()
        {
            
            Console.Write("Lütfen kaç adet sayı girmek istiyorsunuz belirtiniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
                dizi[i] =Convert.ToInt32(Console.ReadLine());

            }

            Array.Sort(dizi);

            Console.WriteLine("**Dizi içindeki çift sayılar**");

            foreach (var sayi in dizi)
            {
                if(sayi%2 == 0)
                    Console.WriteLine(sayi);
            }
        }

        static void Soru2()
        {
            Console.Write("Lütfen pozitif bir sayi giriniz(n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen bir pozitif sayı daha giriniz(m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen "+n+" sayı uzunluğundaki dizinin {0}. sayısını giriniz:",i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(m+" sayısına tam bölünenler ya da eşit olanlar");

            foreach (var sayi in dizi)
            {
                if(sayi%m==0)
                    Console.WriteLine(sayi);
            }
        }

        static void Soru3()
        {
            Console.Write("Lütfen girmek istediğiniz kelime sayısını yazınız: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] dizi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Kelime giriniz: ");
                dizi[i] = Console.ReadLine();
            }
            Array.Reverse(dizi);

            foreach (var kelime in dizi)
            {
                Console.WriteLine(kelime);
            }
        }

        static void Soru4()
        {
            int kelimeSayisi = 0,harfSayisi = 0;
            Console.Write("Lütfen bir cümle yazınız: ");
            string cumle = Console.ReadLine();

            string[] kelime_dizisi = cumle.Split(" ");
            foreach (var kelime in kelime_dizisi)
            {
                kelimeSayisi++;
            }
            
            char[] harf_dizisi = cumle.ToCharArray();
            foreach (var harf in harf_dizisi)
            {
                harfSayisi++;
            }
            harfSayisi=harfSayisi-kelimeSayisi+1;
            Console.WriteLine("Cümledeki kelime sayısı: "+kelimeSayisi);
            Console.WriteLine("Cümledeki harf sayısı: "+harfSayisi);

            


        }
    }
    
}
