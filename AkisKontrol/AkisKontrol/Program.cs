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

            //NOTGir:
            //Console.Write("Not Giriniz: ");
            //float not = Convert.ToSingle(Console.ReadLine());

            //if (not>100)
            //{
            //    Console.WriteLine("100'den büyük girmeyiniz!!!");
            //    goto NOTGir;
            //}
            //else if(not<0)
            //{
            //    Console.WriteLine("0'dan küçük girmeyiniz!!!");
            //    goto NOTGir;
            //}
            //else
            //{
            //    if (not<45)
            //    {
            //        if (not<30)
            //        {
            //            Console.WriteLine("Başarısız");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Başarısız ancak telafi sınavına girebilir.");
            //        }

            //    }else if(not<55)
            //    {
            //        Console.WriteLine("Geçer");
            //    }
            //    else if(not<70)
            //    {
            //        Console.WriteLine("Orta");
            //    }
            //    else if (not < 85)
            //    {
            //        Console.WriteLine("İyi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pekiyi");
            //    }
            //}



            // SORU1: Klavyeden girilen 2 sayının toplamı 100'den büyükse toplayıp;
            // 100'den küçükse çarpıp sonucu ekrana yazdıran programı yazınız.

            //Console.Write("1. Sayıyı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi1 + sayi2;

            //if (toplam>100)
            //{
            //    Console.WriteLine(toplam);
            //}
            //else
            //{
            //    Console.WriteLine(sayi1*sayi2);
            //}




            //int not = 60;

            //switch (not)
            //{
            //    case 50:
            //        Console.WriteLine("Sayı 50");
            //        break; // Switch'den çık
            //    case 60:
            //        Console.WriteLine("Sayı 60");
            //        break; // Switch'den çık
            //    case 70:
            //        Console.WriteLine("Sayı 70");
            //        break; // Switch'den çık
            //    case 80:
            //        Console.WriteLine("Sayı 80");
            //        break; // Switch'den çık
            //    default:
            //        Console.WriteLine("Sayı 50, 60, 70, 80'den farklı !");
            //        break; // Switch'den çık
            //}

            //YanlisCevap:
            //Console.Write("Evet mi Hayır mı?");
            //string eh = Console.ReadLine();
            //eh = eh.ToUpper(); // Harfleribüyük harfe çevir.

            //switch (eh)
            //{
            //    case "EVET":
            //        Console.WriteLine("Tam bir Yes mensin.");
            //        break;
            //    case "HAYIR":
            //        Console.WriteLine("Çok olumsuz Cevap verdin.");
            //        break;
            //    default:
            //        Console.WriteLine("Ben bunu Evet olarak kabul ediyeyim mi?.");
            //        goto YanlisCevap;
            //}

            // Klavyeden 2 sayı isteyiniz float tipinde.
            // 1 de işlem istiyoruz. İşlem şunlardan birisi olabilir.:
            // "TOPLA", "ÇARP", "BÖL", "ÇIKAR"
            // Girilen işleme göre Switch Case altında işlem yapılacak ve kerana sonuç yazdırılacak.


            SayiGir:
            Console.Write("1. Sayıyı Giriniz: ");
            float s1 = Convert.ToSingle(Console.ReadLine());

            
            Console.Write("2 Sayıyı Giriniz: ");
            float s2 = Convert.ToSingle(Console.ReadLine());

            BastanYap:
            Console.Write("İşlem Gİriniz: \"TOPLA\", \"ÇARP\", \"BÖL\", \"ÇIKAR\"");
            string islem = Console.ReadLine();

            islem = islem.ToLower();
            float buyuk = Math.Max(s1, s2);
            float kucuk = Math.Min(s1, s2);

            

            switch (islem)
            {
                case "topla":
                    Console.WriteLine($"Toplam: {s1 + s2}");
                    break;
                case "çarp":
                    Console.WriteLine($"Çarpım: {s1 * s2}");
                    break;
                case "çıkar":
                    Console.WriteLine($"Çıkar: {buyuk-kucuk}");
                    break;
                case "böl":
                    if (kucuk==0)
                    {
                        Console.WriteLine("Sıfırdan büyük sayıları giriniz !!!");
                        goto SayiGir;
                    }
                    Console.WriteLine($"Bölme: {(float)(buyuk/kucuk)}");
                    break;
                default:
                    goto BastanYap;
            }







            Console.Read();

        }
    }
}
