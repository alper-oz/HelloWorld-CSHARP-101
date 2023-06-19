using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Normalde bu projeyi döngüler kullanarak hiç aç kapa yapmaya gerek kalmadan yapabilirdik. Döngüleri öğrendikten sonra burayı güncellerim :)
            //Switch Case ile Mini ATM uygulaması yapalım
            //1- Bakiye görüntüle
            //2- Para çek
            //3- Para yatır
            //4- Çıkş yap
            // 1-2-3-4 dışında değer girerse hata versin

            int balance = 700; // int veri tipinde balance adıyla 700 değeri ile değişken tanımladık
            Console.WriteLine("Akbank ATM'sine hoş geldiniz...");
            Console.WriteLine("Lütfen bir işlem seçin");
            Console.WriteLine("1- Bakiye görüntüle");
            Console.WriteLine("2- Para çek");
            Console.WriteLine("3- Para yatır");
            Console.WriteLine("4- Çıkış yap");

            string choice = Console.ReadLine(); //Kullanıcıdan 1-2-3-4 değerlerinden birini girmesini istedik choice değişkenine atadık 
            switch (choice) //eğer burda choice değişkeninde tuttuğumuz değer yukarda belirtilen değerlerden biri ile uyuşuyorsa case'in içlerine giriş yapacak
            {
                case "1": //kullanıcı 1'i seçtiyse bu case bloğu çalışır
                    Console.WriteLine("Bakiyeniz:" + balance); //Console'da kalan bakiyeyi gösteriyoruz
                    Console.ReadLine();
                    break; //burda break ile işlemi kırarak diğer case'lerin çalışmamasını sağlıyoruz eğer kullanıcı 1 seçeneğini seçmediyse. case'lerin sonuna break yazılmazsa bir altındaki case'i de çalıştırır

                case "2": //kullanıcı 2 seçeneğini tuşlarsa bu case bloğu çalışır
                    Console.WriteLine("Çekmek istediğiniz tutarı girin:");
                    int withdraw = Convert.ToInt32(Console.ReadLine()); //kullanıcıdan string olarak aldığımız para çekme tutarını convert edip int veri tipiyle withdraw değişkenine yazdık
                    if (withdraw > balance) // eğer çekilen tutar bakiye'den fazlaysa...
                    {
                        Console.WriteLine("Bakiyenizden fazla tutar çekemezsiniz."); //bunu yazdır
                        Console.ReadLine();
                    }
                    else //değilse çekilen tutarı bakiye'den düş ekrana yazdır
                    {
                        Console.WriteLine("Kalan bakiye:" + (balance - withdraw));
                        Console.ReadLine();
                    }
                    break;

                case "3": //kullanıcı 3 seçeneğini seçtiyse bu case bloğu çalışır
                    Console.WriteLine("Yatırmak istediğiniz tutarı girin ve enter'a basın:"); 
                    int deposit = Convert.ToInt32(Console.ReadLine()); //kullanıcıdan string veri tipinde aldığımız int değerini int veri tipine convert edip deposit isimli değişkene atadık
                    Console.WriteLine("Yeni Bakiye:" + (balance + deposit)); // para yatırma değişkenini bakiye'ye ekledik console da yazdırdık
                    Console.ReadLine();
                    break;
                case "4": //kullanıcı 4 seçeneğini seçtiyse bu case bloğu çalışır
                    Console.WriteLine("Oturumunuz güvenli bir şekilde sonlandırıldı. İyi günler.");
                    Console.ReadLine();
                    break;
                default: //eğer yukardaki 4 değer farklı bir değer yazıldıysa case bloklarına uğramadan default'u çalıştıracak.
                    Console.WriteLine("Lütfen geçerli bir değer girin.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
