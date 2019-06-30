using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //İşlem Önceliği

            //* / önceliklidir. Eşit önceliklidir. Eşit önceliklilerde işlemler soldan sağa yapılır.
            // + - operatörleri sonra gelir. İkisi eşit önceliklidir.

            int a, b, c, d, sonuc1,sonuc2,sonuc3,toplam;
            //a = 5;
            //b = 10;
            //c = 20;
            //d = 30;

            //sonuc1 = a * b / c + d;
            //sonuc2 = a * (b / c) + d;
            //sonuc3 = a * b / (c + d);
            //Console.WriteLine(sonuc1);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);



            //toplam = 5;
            //toplam += 55; // toplam = toplam + 55; değişkene ekleme
            //Console.WriteLine(toplam);
            //toplam -= 55; // toplam = toplam - 55; değişkenden eksiltme
            //Console.WriteLine(toplam);
            //toplam *= 5; // toplam = toplam * 5; kendi değeriyle çarpma
            //Console.WriteLine(toplam);

            //toplam /= 25; // toplam = toplam /25; Kendi değerini bölme
            //Console.WriteLine(toplam);

            // Mod Alma Operatörü: %

            //float kalan = 25 % 3; // 25 in 3 e bölümünden kalanı verir.
            //Console.WriteLine(kalan);



            // Artırma ve Eksiltme Operatörleri.

            //byte minikSayi = 76;
            //minikSayi++; // 1 Artırma operatörü. İşlem sırasında önce işlem yapılır. SOnra artırım.
            //minikSayi--; // 1 Eksiltme operatörü. İşlem sırasında önce işlem yapılır. SOnra eksiltme

            //byte bxx = minikSayi++;
            //Console.WriteLine(bxx); // 76
            //Console.WriteLine(minikSayi); // 77

            //byte minikSayi = 76;
            //++minikSayi; // 1 Artırma operatörü
            //--minikSayi; // 1 Eksiltme operatörü

            //byte bxx = ++minikSayi;
            //Console.WriteLine(bxx); // 77
            //Console.WriteLine(minikSayi); // 77





            ////  karşılaştırma Operatörleri.

            //int s1 = 90;
            //int s2 = 99;

            //bool buyukMu = s1 > s2; // false
            //bool kucukMu = s1 < s2; // true
            //bool esitMi = 45.33F == 66.7F; // False
            //bool esitDegilMi = 45.33F != 66.7F; // True
            //bool buyukEsitMi = 45 >= 45; // True
            //bool kucukEsitMi = 55 <= 45; // False
            ////Console.WriteLine(buyukMu + "  " + kucukMu + "  " + esitMi + "  " + esitDegilMi);

            //// as is operatörleri

            //object obj = "Aksakal";
            //string yazi = obj as string; // string e dönüştürerek ata.

            //bool stringMi = yazi is string; // True
            //bool intMi = yazi is int; // False
            //bool objeMi = yazi is object; // True


            //Console.WriteLine(stringMi);
            //Console.WriteLine(intMi);
            //Console.WriteLine(objeMi);


            // Mantıksal Operatörler.

            //int sayi = 77;

            //bool notKontrol = sayi <= 100 && sayi >= 0; // && iki koşulda  sağlanırsa True, en az 1 i sağlanmaz ise False:  Mantıksal VE

            //int yas = 11;
            //bool yasKontrol = yas <= 10 || yas >= 65; // İki koşuldan enaz 1 i sağlanırsa True, 2 side sağlnmaz ise False.: Mantıksal VEYA
            //Console.WriteLine(notKontrol + " " + yasKontrol);

            //bool kontrol1 = false;
            //bool kontrol2 = true;

            //bool kont1 = kontrol1 && kontrol2; // False
            //bool kont2 = kontrol1 || kontrol2; // True


            //bool kont6 = !(false); // True
            //int s3 = 45;
            //bool kont3 = (s3 > 50); // False
            //bool kont4 = !(s3 > 50); // True // ! işareti durumu tersine çevirir.

            //bool kont5 = !(s3 != 55 && s3 < 78); // False



            // Bitsel Operatörler

            // Bitsel Ve operatörü
            //byte bSayi = 5;
            //byte iSayi = 3;
            //int kont7 = bSayi & iSayi;
            //int kont8 = bSayi | iSayi;
            //byte kont9 = (byte)~iSayi;
            //Console.WriteLine(kont7);
            //Console.WriteLine(kont8);
            //Console.WriteLine(kont9);


            //0101   =5
            //0011   =3
            //----
            //0001 // 1
            //0111 // 7

            //00000011
            //11111100 //252
            //0110

            // ^(Bitsel Özel Veya) Öperatörü: iki değer aynıysa 0, farklıysa 1 üretir.

            //int kont10 = bSayi ^ iSayi;
            //Console.WriteLine(kont10);

            // Bitsel Sağa Kaydırma
            byte bs = 6;
            byte bs2 = (byte)(bs >> 1); // Her 1 bir sağa kaydırma sayıyı 2 ye böler.
            byte bs3 = (byte)(bs << 1);// Her 1 bir sola kaydırma sayıyı 2 ye katlar.
            //00000110 = 6
            //00000011 = 3
            //00011000 = 12
            //Console.WriteLine(bs2); 
            //Console.WriteLine(bs3);

            //Önüne 0x veya 0X gelen sayılar 16'lık sayı tabanı sayılarını ifade eder.
            byte hexa1 = 0XA5;  // 165
            Console.WriteLine(hexa1);





            Console.Read();


        }
    }
}
