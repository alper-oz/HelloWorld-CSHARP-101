using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseMiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya yapmak istediği işlemle ilgili soracağız
            //1- Bakiye Görüntüleme 
            //2- Para Çekme
            //3- Para Yatırma
            // q ile çıkış yapabilirsiniz
            int amount = 1000;
            Console.WriteLine("QNB ATM'sine Hoş geldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi tuşlayın");
            string choose=Console.ReadLine();
            if(choose == "1")
            {
                Console.WriteLine("Şu anki bakiyeniz:" + amount);
                Console.ReadLine();
            }
            else if(choose == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı girin:");
                int withdraw=Convert.ToInt32(Console.ReadLine());
                if(withdraw<=amount)
                {
                    Console.WriteLine("Kalan tutar:" + (amount - withdraw));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyeden fazla çekim yapamazsınız.");
                    Console.ReadLine();
                }
                
            }
            else if (choose == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı girin:");
                int deposit=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni baiyeniz:"+ (amount+deposit));
                Console.ReadLine();
            }
            else if (choose == "q")
            {
                Console.WriteLine("Oturumunuz güvenli bir şekilde sonlandırıldı.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer girin:");
                Console.ReadLine();
            }
        }
    }
}
