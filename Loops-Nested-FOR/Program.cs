using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Nested_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iç içe FOR döngüsü kullanarak yılbaşı ağacı yapan program
            for (int i = 1; i <= 10; i++) // bu döngü 1'den başlasın 10'a kadar gitsin bir bir artsın yazdık
            {
                for(int j = 1; j <= i; j++) // j değişkeni 1'den başlasın, "j <= i" KOŞULUndan i'ye kadar gitsin ve bir bir artın dedik
                {
                    Console.Write(j); // Console Write methodu ile yan yana yazdırdık (console.writeline methodu bir satır aşağıya atlar)
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
