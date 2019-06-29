﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bilinçsiz Tür DÖnüşümü
            // Küçük TÜr Büyük TÜre Sorunsuz Otomatik olarak dönüşür.

            byte sayi1 = 234;
            int sayi2;

            // sayi1'in değerini sayi2'ye ata.
            sayi2 = sayi1;

            // float değeri double'a otomatik dönüştü.
            float sayi3 = 45.5F;
            double sayi4 = sayi3;

            // short değeri int'e otomatik dönüştü.
            short sayi5 = 345;
            int sayi6 = sayi5;


            // Kasıtlı Tür DÖnüşümü.

            // parantez içerisinde hedef tip belirtilir.

            // Casting
            int sayi7 = 257;
            byte sayi8 = (byte) sayi7;
            // Console.WriteLine(sayi8);

            double sayi9 = double.MaxValue;
            //string s = sayi9.ToString();
            float sayi10 = (float)sayi9;
            //Console.WriteLine(sayi9);



            // Ondalıklı kısım kayboldu.
            float sayi11 = 4.5F;
            int sayi12 = (int)sayi11;
            //Console.WriteLine(sayi12);







            //Convert Sınıfı ile Tür DÖnüşümü.

            double sayi13 = 456.5;
            string yazi1 = Convert.ToString(sayi13);





            // .GetType() değişkenin tipini getirir. CTS
            // Console.WriteLine(yazi1.GetType());

            string yazi2 = "5.5";
            double sayi14=0.0;

            //try
            //{
            //    sayi14 = Convert.ToDouble(yazi2);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Çevirmede hata var.");
            //}
            //finally
            //{
            //    Console.WriteLine("Try-Catch Bloğu Tamamlandı.");
            //}

            //Console.WriteLine(sayi14);
            //Console.WriteLine(sayi14.GetType());





            // Karakterin ASCII tablosundaki sayı değerini yazdırır.
            char karakter1 = 'A';
            int sayi15 = Convert.ToInt32(karakter1);
            //Console.WriteLine(sayi15);



            Console.Write("Adınızı Giriniz: ");
            string alınanMetin = Console.ReadLine();

            //int yas = Convert.ToInt32(alınanMetin);


            Console.WriteLine("Kullanıcının Adı: " + alınanMetin);
            


            Console.Read();

            

        }
    }
}
