using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseApply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KULLANICIDAN 3 NOT GİRDİSİ ALAN VE NOTLARIN ORTALAMASI BULAN VE ORTALAMAYA GÖRE NOTLAMA SİSTEMİ YAPAN UYGULAMA
            // Console.ReadLine() kullanımına değineceğiz demiştim, burada kullandık
            
            Console.WriteLine("Lütfen notunuzu girin ve enter'a basın:"); 
            int first = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan string formatta aldığımız değeri Convert sınıfının ToInt methodu ile int formata dönüştürüyoruz. Aynı zamanda kullanıcıdan değer almak için Console.ReadLine() kullanıyoruz ve first isimli değişkene atıyoruz. Aynı işlemi second ve third değişkenlerine de yaptık.
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            // kullanıcıdan aldığımız 3 notu toplayıp 3'e bölen matematik işlemini de yapıp int türünde result isimle değişkene atıyoruzi
            int result=(first + second + third)/3;

            //2 farklı değer şartı koymak istersek burdaki 80 ile 100 arasında gibi.. bunun için VE anlamına gelen && sembolünü kullanıyoruz.
            // bu operatörün amacı 2 DEĞERİ DE TRUE olan şartlar için geçerli. Eğer sonuç 80 den büyük 100'den küçükse bu şartı doğru kabul eder diğer if else bloklarına ilerlemez
            if (result > 80 && result < 100)
            {
                Console.WriteLine("Not değeriniz: A+");
            }
            else if (result > 60 && result < 80)
            {
                Console.WriteLine("Not değeriniz: A");
            }
            else if (result > 40 & result < 60)
            {
                Console.WriteLine("Not değeriniz: B+");
            }
            else
            {
                Console.WriteLine("Not değeriniz: F");
            }
            Console.ReadLine();
        }
    }
}
