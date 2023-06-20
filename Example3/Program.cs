using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KULLANICIDAN ALDIĞIMIZ 2 SAYIDAN BÜYÜK OLANI VEYA KÜÇÜK OLANI EKRANA YAZDIRAN PROGRAM

            Console.Write("Birinci sayıyı giriniz:");
            int sayi1=int.Parse(Console.ReadLine()); //Kullanıcıdan aldığımız string veriyi int veri tipine Parse ile çevirerek sayi1 adlı değişkene atadık
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2=int.Parse(Console.ReadLine()); //Kullanıcıdan aldığımız string veriyi int veri tipine Parse ile çevirerek sayi2 adlı değişkene atadık

            kontrolEt(sayi1, sayi2); //kullanıcıdan aldığımız değerleri kontrolEt methodun'a parametre olarak gönderdik
            Console.ReadLine();
        }
        static void kontrolEt(int a, int b) //kontrolEt adında geriye değer döndürmeyen int veri tipinde 2 değişkenli method tanımladık
        {
            if (a>b) //eğer a > b ise
            {
                Console.WriteLine("Birinci sayı daha büyüktür");
            }
            else if (b==a)
            {
                Console.WriteLine("Sayılar eşittir.");
            }
            else
            {
                Console.WriteLine("İkinci sayı daha büyüktür.");
            }
        }
    }
}
