using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkisKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool k = false;

            //if (k == true)
            //{ // Koşul sağlanırsa bu blok çalışır.
            //    Console.WriteLine("Koşul Sağlandı.");
            //}
            //else
            //{ // Koşul sağlanmazsa else bloğu çalışır.
            //    Console.WriteLine("Koşul Sağlanmadı!!!!");
            //}


            // Klavyeden girilen sayının 100 den küçük mü büyük mü
            // olduğunu yazdıran program.

            //Console.Write("Bir sayı giriniz: ");
            //string sGirSayi = Console.ReadLine();
            //int iGirSayi = Convert.ToInt32(sGirSayi);
            // Bu kısım ileriki derslerin konusudur. Dikkate almayınız.
            int iGirSayi=0;
            bool sayiMi = false;
            do
            {
                Console.Write("Bir sayı giriniz: ");
                string sGirSayi = Console.ReadLine();
                try
                {
                    iGirSayi = Convert.ToInt32(sGirSayi);
                    sayiMi = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız. Sayı giriniz:");
                }
            } while (sayiMi==false); // şart sağlandığı sürece döngüyü başa sar.




            if (iGirSayi < 100)
            { 
                Console.WriteLine("Sayı 100'den küçüktür.");
            }
            else if(iGirSayi>100)
            { 
                Console.WriteLine("Sayı 100'den büyüktür.");
            }
            else
            {
                Console.WriteLine("Sayı 100'dür.");
            }

            Console.Read();

        }
    }
}
