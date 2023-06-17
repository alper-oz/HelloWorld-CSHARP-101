using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float veri tipi ondalıklı sayılar tutmamıza olanak tanır
            float ondalikli_sayi = 35.56f; // Burada veri tipi ondalıklı olmasına rağmen sonuna f anahtar kelimesi de ekledik. Bunun sebebi; girdiğiniz değer, ilk double olarak derlenir siz float olduğunu belirtene kadar. 
            Console.WriteLine(ondalikli_sayi);
            Console.ReadLine();
        }
    }
}
