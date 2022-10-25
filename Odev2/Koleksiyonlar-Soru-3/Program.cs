using System;
using System.Collections;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cumledekiSesli = new ArrayList();

            Console.Write("Lütfen bir cümle giriniz: ");

            char[] harf = (Console.ReadLine().ToCharArray());

            foreach (char t in harf)
            {
                if(t == 'a' || t == 'e' || t == 'ı' || t == 'i' || t == 'o' || t == 'ö' || t == 'u' || t == 'ü' )
                {
                    cumledekiSesli.Add(t);
                }
            }
            foreach (var item in cumledekiSesli)
            {
                Console.WriteLine(item);
            }
        }
    }
}