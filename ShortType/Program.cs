using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Short değişkeni -32768 ile 32768 arasında değer tutabilir
            short max = short.MaxValue; // MaxValue properties'i ile short veri türünün alabileceği maksimum değeri istedik
            short min=short.MinValue; // MinValue properties'i ile short veri türünün alabileceği minimum değeri istedik
            Console.WriteLine(max); // max değişkenini CW içerisinde çıktı olarak gönderdik
            Console.WriteLine(min); //min değişkenini CW içerisinde çıktı olarak gönderdik
            Console.ReadLine(); // Debug bittiğinde siyah ekranın X ile kapatana kadar kapanmamasını sağlar, başka bir şekilde daha var ondan ilerde bahsedicem
        }
    }
}
