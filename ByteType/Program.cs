using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0-255 arasında değer alır.
            byte first = 5; // first ismiyle byte türünde değişken tanımladık, first çıktısı girmek istediğimiz alanlarda 5 değeri yazacak
            byte second = 6;
            byte max = byte.MaxValue;
            byte min = byte.MinValue;
            Console.WriteLine(second); //CW fonksiyonu ile second isimli değişkeni çıktı aldık
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine(); // Debug bittiğinde siyah ekranın X ile kapatana kadar kapanmamasını sağlar, başka bir şekilde daha var ondan ilerde bahsedicem
        }
    }
}
