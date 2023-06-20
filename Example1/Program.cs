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
            Console.Write("Bir sayı girin:");
            int sayi = int.Parse(Console.ReadLine());
            int karedeger = Karesi(sayi);
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
        static int Karesi(int a)
        {
            return a * a;
        }

    }
}
