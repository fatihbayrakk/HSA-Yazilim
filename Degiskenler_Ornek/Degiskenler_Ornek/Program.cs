using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz: ");
            string ad = Console.ReadLine();
            
            Console.WriteLine("Kullanıcının Adı: " + ad);

            Console.Write("Yaşınızı Giriniz: ");
            string yasStr = Console.ReadLine();
            byte yas = Convert.ToByte(yasStr);

            Console.WriteLine("Kullanıcının Yaşı: " + yas);

            //string interpolasyon
            Console.WriteLine($"Kullanıcının Yaşı: {yas} {ad}");


            Console.WriteLine();



            // Klavyeden bir giriş olup enter'a basana kadar bekle.
            Console.Read();

        }
    }
}
