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
            //int iGirSayi=0;
            //bool sayiMi = false;
            //do
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    string sGirSayi = Console.ReadLine();
            //    try
            //    {
            //        iGirSayi = Convert.ToInt32(sGirSayi);
            //        sayiMi = true;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatalı Giriş Yaptınız. Sayı giriniz:");
            //    }
            //} while (sayiMi==false); // şart sağlandığı sürece döngüyü başa sar.

            //if (iGirSayi < 100)
            //{ 
            //    Console.WriteLine("Sayı 100'den küçüktür.");
            //}
            //else if(iGirSayi>100)
            //{ 
            //    Console.WriteLine("Sayı 100'den büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 100'dür.");
            //}

            // Klavyeden girilen 2 sayıdan büyük olanı bul
            //Console.Write("Birinci sayıyı Giriniz.");
            //string strSayi1 = Console.ReadLine();
            //int sayi1 = Convert.ToInt32(strSayi1);

            //Console.Write("İkinci sayıyı Giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //if (sayi1>sayi2)
            //{
            //    Console.WriteLine("1. Sayı 2. Sayıdan Büyüktür.");

            //}else if(sayi2>sayi1)
            //{
            //    Console.WriteLine("2. Sayı 1. Sayıdan Büyütür.");
            //}
            //else
            //{
            //    Console.WriteLine("İki sayı birbirine eşittir.");
            //}

            // Klavyeden Girilen 2 adet notun ortalamasını ekrana yazdıran program.

            // 3 ÇÖZÜMÜ DE AŞAĞIDADIR.





            //NOT1Gir:
            //Console.Write("1. Notu Giriniz:");
            //float not1 = Convert.ToSingle(Console.ReadLine());
            //NOT2Gir:
            //Console.Write("2. Notu Giriniz:");
            //float not2 = Convert.ToSingle(Console.ReadLine());

            //if (not1>=0 && not1<=100 && not2>=0 && not2<=100)
            //{
            //    Console.WriteLine($"Not Ortalaması: {(not1 + not2) / 2}");
            //}
            //else
            //{
            //    Console.WriteLine("Not aralığını hatalı girdiniz.");
            //}


            //if (not1>100 || not1<0 || not2>100 || not2<0)
            //{
            //    Console.WriteLine("Not aralığını hatalı girdiniz.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not Ortalaması: {(not1 + not2) / 2}");
            //}



            //if (not1 > 100)
            //{
            //    Console.WriteLine("1. Notu 100'den büyük girdiniz: HATA!!!");
            //    goto NOT1Gir;
            //}
            //else if (not1 < 0)
            //{
            //    Console.WriteLine("1. Notu 0'dan küçük girdiniz. HATA!!!");
            //    goto NOT1Gir;
            //}
            //else if (not2 > 100)
            //{
            //    Console.WriteLine("2. Notu 100'den büyük girdiniz. HATA!!!");
            //    goto NOT2Gir;
            //}
            //else if(not2<0)
            //{
            //    Console.WriteLine("2. Notu 0'dan küçük girdiniz. HATA!!!");
            //    goto NOT2Gir;
            //}
            //else
            //{
            //    Console.WriteLine($"Not Ortalaması: {(not1 + not2) / 2}");
            //}


            // Klavyeden girilen NOTA göre harf notu üreten yazılım.

            /* 85-100: Pekiyi, 70-84: İyi, 55-69: Orta, 45-54: Geçer: 0-44: Başarısız */

            NOTGir:
            Console.Write("Not Giriniz: ");
            float not = Convert.ToSingle(Console.ReadLine());

            if (not>100)
            {
                Console.WriteLine("100'den büyük girmeyiniz!!!");
                goto NOTGir;
            }
            else if(not<0)
            {
                Console.WriteLine("0'dan küçük girmeyiniz!!!");
                goto NOTGir;
            }
            else
            {
                if (not<45)
                {
                    if (not<30)
                    {
                        Console.WriteLine("Başarısız");
                    }
                    else
                    {
                        Console.WriteLine("Başarısız ancak telafi sınavına girebilir.");
                    }
                    
                }else if(not<55)
                {
                    Console.WriteLine("Geçer");
                }
                else if(not<70)
                {
                    Console.WriteLine("Orta");
                }
                else if (not < 85)
                {
                    Console.WriteLine("İyi");
                }
                else
                {
                    Console.WriteLine("Pekiyi");
                }
            }



            // SORU1: Klavyeden girilen 2 sayının toplamı 100'den büyükse toplayıp;
            // 100'den küçükse çarpıp sonucu ekrana yazdıran programı yazınız.


            Console.Read();

        }
    }
}
