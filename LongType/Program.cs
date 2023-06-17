using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // long veri tipi -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.808 arasında veri depolayabilir
            long max=long.MaxValue; //MaxValue properties'i ile long veri türünün alabileceği maksimum değeri istedik
            long min=long.MinValue; //MinValue properties'i ile long veri türünün alabileceği minimum değeri istedik
            Console.WriteLine(max); //max değişkenini ekrana yazdırmak üzere gönderdik
            Console.WriteLine(min); //min değişkenini ekrana yazdırmak üzere gönderdik
            Console.ReadLine();
        }
    }
}
