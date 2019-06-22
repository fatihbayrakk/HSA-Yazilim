using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tek satır açıklama/yorum/comment
            
            /*
             * Çoklu
             * Açıklama satırı
             * 
             */

            // Değer Tipi Değişkenler*******************************
            
            sbyte sayi = -56;
            byte sayi1 = 45;
            short sayi2 = 32000;
            int sayi3 = 45000;
            long sayi4 = 123123123123;

            float pi = 3.14f;
            float pi2 = 3.14F;

            double ondalikli1 = 4.5544444;
            double ondalikli2 = 5.33D;
            double ondalikli3 = 6.55d;

            decimal buyukOndalikli = 33333.5555M;
            decimal buyukOndalikli2 = 33333.5555m;

            bool kontrol = true;
            bool kontrol2 = false;

            char harf = 'F';
            char harf2 = '4';
            char harf3 = 'V';

            string isim = "532 Metinsel İfade 532";

            // Otomatik tip belirleme(değer tipi)

            // var değer tipinde bir veri.
            var s1 = 55;
            // Program çalıştığında int s1 = 55;


            var s2 = "Merhaba";
            //Program çalıştığında string s2 = "Merhaba";
            var s3 = true;
            var s4 = 'F';



            //harf = 5;  Burada char tipi değer tipinde olduğu için farklı türden bir veriyi kabul emteyecek.



            Console.WriteLine("Smartpro Bilgisayar Akademisi");
            Console.WriteLine(sayi3);


            Console.WriteLine("Sayi3 değişkeninin değeri: " + sayi3);
            Console.WriteLine("Sayi2 değişkeninin değeri: " + sayi2 + " Sayi1 değişkenin değer: " + sayi1);

            Console.WriteLine(sayi1 + sayi2);    // 32045
            Console.WriteLine(sayi1 +""+ sayi2); // 4532000



            // Referans Tipi Veriler.

            /*
                Ram'deki adresleri tutar.
             */
            
            object degisken = 55;
            degisken = "Metinsel İfade";

            String degisken2 = "Merhaba";


            Console.Read();




        }
    }
}
