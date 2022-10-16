using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Sayi Giriniz:");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i <sayac; i++)
            // {
            //     if(i%2 ==1)
            //         Console.WriteLine(i);
            // }

            // int ciftToplam=0;
            // int tekToplam=0;
            // for (int i = 1; i <= 1000; i++)
            // {
            //     if(i%2==1)
            //         tekToplam+=i;
            //     else
            //         ciftToplam+=i;
            // }
            // Console.WriteLine("Tek Toplam: "+tekToplam);
            // Console.WriteLine("Çift Toplam:"+ciftToplam);

            // break ,continue

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }

            // for (; ; )
            // {
            //     if(i==4)
            //         continue;
            //     Console.WriteLine(i);
            // }

            
        }
    }
}
