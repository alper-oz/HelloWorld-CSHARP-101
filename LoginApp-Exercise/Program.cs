using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı giriş sayfası uygulaması yapacağız
            //Kullanıcı adı ve şifresi doğru girildiyse Tebrikler yazısı,
            //Yanlış girerse hata versin ve 3 kere giriş hakkı olsun. Giriş hakkı bittiğinde uyarsın.

            int auth = 3; // int veri türünde kullanıcı için 3 giriş hakkı tanımladık
            while (true) //while döngüsünün değeri TRUE olduğu için sonsuz bir döngüdür, koşulun sürekli sağlandığı anlamına gelir
            {
                Console.WriteLine("Kullanıcı adı:");
                string username= Console.ReadLine(); // string veri türünde kullanıcıdan aldığımız kullanıcı adı değerini username değişkenine atadık

                Console.WriteLine("Şifre:");
                string password= Console.ReadLine(); //string veri türünde kullanıcıdan aldığımız şifre değerini password değişkenine atadık
                //İPUCU: değişken isimleri sayı veya sembolle başlamaz. Sade ve amacına uygun tanımlanır. Türkçe karakter kullanılmaz. Eğer kullanıcıdan aldığım şifre değişkenini türkçe tanımlamak isteseydim
                // string sifre = console.readline(); biçiminde tanımlamam doğru olurdu

                if (username=="alper" && password=="123") //eğer kullanıcı adı VE şifre doğruysa döngünün içine gir...
                {
                    Console.WriteLine("Başarılı giriş yaptınız."); // başarılı giriş yaptınız uyarısını ekrana yazdır...
                    break; // ... ve döngüyü kır. Break'in türkçe karşılığı kırmak'tır. Yani while döngümüzü tekrar dönmeden döngünün dışına çık diyoruz. Eğer kırmazsam kullanıcı adı ve şifre doğru olmasına rağmen döngünün başına döner.
                }
                else // kullanıcı adı veya şifre doğru değilse
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz hatalı."); // hata uyarısını ekrana yazdır
                    if (auth > 0) // döngü başlamadan kullanıcıya 3 giriş hakkı tanımıştık. 
                    {
                        auth -= 1; // if koşulunda "auth > 0" değeri TRUE döndüğü için hak sayımızı 1 azalt dedik
                    }
                    if (auth==0) //tanımladığımız hak sayısı 0'a eşitlendiğinde if döngüsüne gir...
                    {
                        Console.WriteLine("Giriş hakkınız doldu. Hesabınız bloke edildi."); //uyarı yazısını ekrana yazdır
                        break; //ve döngüden çık
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
