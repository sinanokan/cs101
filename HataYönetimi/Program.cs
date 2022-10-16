namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // try//Hata dönmek istediğimiz kodları buraya yazıyoruz
            // {
            //    Console.WriteLine("Bir sayı giriniz.");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayı:" + sayi); 
            // }
            // catch (Exception ex)//hataya vereceği cevap
            // {
            //     Console.WriteLine("hata:" + ex.Message.ToString());
            // }
            // finally{//işlem sonu çalışmasını istediğimiz satırlar
            //     Console.WriteLine("İşlem tamamlandı.");
            // }


            try
            {
                //int a = Int32.Parse(null);
                //int b = Int32.Parse("test");
                int c = Int32.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Null değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yanlış formatta bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük ya da çok küçük bir değer girdiniz.");
                Console.WriteLine(ex);
            }

            finally{
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }
    }
}
