using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Personel
    {
        public static void NameSurname() // Method veya değişken, STATIC olarak tanımlandıysa diğer Class'lar üzerinden erişmek için herhangi bir class'tan obje oluşturmamıza gerek yok.
        {
            Console.WriteLine("kod buddy");
            Console.ReadLine();
        }
    }
}
