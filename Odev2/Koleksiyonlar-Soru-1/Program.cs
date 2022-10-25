using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            Console.WriteLine("Lütfen 20 adet sayı giriniz.");

            for (int i = 0; i < sayilar.Length; i++)
            {
                int deger = 0;
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                if (int.TryParse(Console.ReadLine(),out deger) && deger>0 )
                {
                    sayilar[i] = deger;
                }
                else
                {
                    i--;
                    Console.WriteLine("Lütfen numeric ve pozitif sayı giriniz.");
                }
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayac = 0;
                for (int j = 2; j < sayilar[i]; j++)
                {
                    if(sayilar[i]%j==0)
                    {
                        sayac++;
                    }                  
                }
                if (sayac == 0 && (asal.Contains(sayilar[i]))==false)
                {
                    asal.Add(sayilar[i]);
                }
                else if(sayac>0 && (asalOlmayan.Contains(sayilar[i])==false))
                {
                    asalOlmayan.Add(sayilar[i]);
                }
            }
            asal.Sort();
            asal.Reverse();

            asalOlmayan.Sort();
            asalOlmayan.Reverse();

            int asalAdet = 0 ,asalOlmayanAdet = 0;
            int asalTop = 0 ,asalOlmayanTop = 0;

            Console.WriteLine("**** Asal Sayılar ******");

            foreach (int item in asal)
            {
               Console.WriteLine(item);
               asalAdet++;
               asalTop+=item;   
            }

            Console.WriteLine("Asal sayi adeti:"+asalAdet);
            Console.WriteLine("Asal sayıların ortalaması:"+asalTop/asalAdet);

            Console.WriteLine("******* Asal Olamayan Sayılar ******");
            foreach (int item in asalOlmayan)
            {
                Console.WriteLine(item);
                asalOlmayanAdet++;
                asalOlmayanTop += item;
            }

            Console.WriteLine("Asal olmayan sayı adeti:"+asalOlmayanAdet);
            Console.WriteLine("Asal olamayn sayı ortalaması:"+asalOlmayanTop/asalOlmayanAdet);

        }
        
    }
}
