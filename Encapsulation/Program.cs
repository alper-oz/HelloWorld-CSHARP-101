using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        //Personelimizden TC Kimlik Numarasını alıp bu kontrolleri sağlayacağız
        // SET ŞARTLARI
        // 1- TC Kimlik No 11 karakter olmalı
        // 2- Tüm karakterler sayısal karakter olmalı

        // GET ŞARTI
        // 1- TC Kimlik Numarasının ilk 5 hanesini substring methodu ile ekrana yazdıracağız
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            p1.TCKIMLIKNO = "123456789910";
            Console.WriteLine("TC: " + p1.TCKIMLIKNO);
            Console.ReadLine();
        }
    }
}
