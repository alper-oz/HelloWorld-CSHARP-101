using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IfElseBodyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden kitle indeksi = Kilo / boy*boy
            // Beden kitle endeksi 18'e eşit veya düşükse ZAYIF
            // 18 ile 25 arasındaysa normal
            // 25'ten büyükse şüşko yazdıran program

            Console.WriteLine("Lütfen kilonuzu girin:");
            int kg = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan -console readline- aldığımız kilo bilgisini int türüne convert ettik

            Console.WriteLine("Lütfen boyunuzu girin:");
            double length = Convert.ToDouble(Console.ReadLine()); // kullanıcıdan double türünde aldığımız kilo bilgisini double'ye convert ettik. Console.Readline ile kullanıcıdan aldığımı veriler default olarak string türünde gelir. int ve double'de bu verileri Convert.ToInt32 ve ToDouble ile convert ettik.

            double endeks = kg / (length * length);

            if (endeks < 18)
            {
                Console.WriteLine("-----Zayıf.-----");
                Console.ReadLine(); //console ekranı hemen kapanmasın diye console.readline kullandık (2 özelliği vardı biri veri almak diğer console'u ekranda tutmak
            }
            else if (endeks > 18 && endeks < 25)
            {
                Console.WriteLine("-----Normalsiniz.-----");
                Console.ReadLine();
            }
            else if (endeks > 25)
            {
                Console.WriteLine("-----Şüşko.-----");
                Console.ReadLine();
            }

        }
    }
}
