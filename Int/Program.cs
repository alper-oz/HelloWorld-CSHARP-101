using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int veri türü -2.147.483.648 ile 2.147.483.648 arasında veri tutabilir
            // 4 byte yer kaplar bellekte(RAM)

            //8 bit = 1 byte
            //1024 byte = 1 KB (kilobyte)
            //1024 KB = 1 MB (megabyte)
            //1024 MB = 1 GB(gigabyte-gigabayt dile telaffuz edilir-)
            //1024 GB = 1 TB (terabyte)
            //1024 TB = 1 PB (petabyte)

            int max = int.MaxValue; //MaxValue properties'i ile int veri türünün alabileceği maksimum değeri istedik
            int min = int.MinValue; //MinValue properties'i ile int veri türünün alabileceği minimum değeri istedik
            Console.WriteLine(max); //max değişkenini ekrana yazdırmak üzere gönderdik
            Console.WriteLine(min); //min değişkenini ekrana yazdırmak üzere gönderdik
            Console.ReadLine(); //Debug bittiğinde siyah ekranın X ile kapatana kadar kapanmamasını sağlar, başka bir şekilde daha var ondan ilerde bahsedicem
        }
    }
}
