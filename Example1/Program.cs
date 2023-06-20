using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin:"); //Kullanıcıdan bir sayı girmesini istedik
            int sayi = int.Parse(Console.ReadLine()); //girilen değeri string veri tipinden int tipine dönüştürüp sayi isimli değişkene atadık
            int karedeger = Karesi(sayi); //Girilen sayının karesinin kontrolünü yapabilmek için karedeger adında int veri tipinde değişken atadık, değişkenin içine kullanıcıdan gelen sayi isimli değeri verdik
            if (karedeger > 25)
            {
                Console.WriteLine("Karesi 25 den büyüktür");

            }
            else
            {
                Console.WriteLine("Karesi 25 den küçüktür");
            }
            Console.ReadLine();
        }
        static int Karesi(int a) //sayının karesini almak için int tipinde statik method yazdık
        {
            return a * a;
        }

    }
}
