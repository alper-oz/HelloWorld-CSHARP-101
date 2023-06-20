using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız sayının tek mi çift mi olduğunu bulan program
            Console.WriteLine("Bir sayı girin..."); //kullanıcıdan bir sayı girmesini istedik, alt satıra geçmesin diye Write kullandım
            int girilenSayi=int.Parse(Console.ReadLine()); //kullanıcıdan string veri türünde aldığım değeri Parse ile int tipine çevirdik
            tekmiciftmi(girilenSayi); //sayının tek mi çift mi olduğunu söyleyecek methodumuzu çağırdık ve kullanıcıdan aldığımı sayı değerini methodun içine parametre olarak gönderdik
            Console.ReadLine();
        }
        static void tekmiciftmi(int sayi) //tekmiciftmi isimli methodumuzun int tipinde sayi değişkeni alacağını söyledik(yukarda methodu çağırırken kullanıcıdan aldığımız sayıyı da method'a göndermiştik)
        {
            if (sayi%2==0) //eğer girilen sayının 2'ye bölümünden kalan 0'a eşitse...
            {
                Console.WriteLine("Sayı çifttir..."); //ekrana sayı çift yaz
            }
            else
            {
                Console.WriteLine("Sayı tektir..."); //değilse sayı tek yaz
            }
        }
    }
}
