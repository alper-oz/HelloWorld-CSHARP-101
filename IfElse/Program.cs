using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not = 75; // not değişkenine 75 değerini int veri tipinde tanımladık (not bilgisini kullanıcıdan alan kod bloğunu da yapacağız)
            if(not>50) //if koşulu ile notun 50'den büyük mü değil mi şartını sağladık... 
            {
                Console.WriteLine("Dersten geçti!");
            }
            else //...eğer şartı sağlamıyor olsaydı if'in altındaki süslü parantezlere hiç girmeden else(değilse) bloğuna geçecekti
            {
                Console.WriteLine("Dersten kaldı!");
                
            };
            Console.ReadLine();
            //IF ifadesinin yanındaki parantezin içinde yazdığımız şart(notun 50'den yüksek olması) karşılandığı için TRUE değer döndürüp süslü parantezin içine devam etti. Ama not 50'den küçük olsaydı FALSE değer dönüp else bloğuna gidecekti.
            // Yukarda yazan not değişkenini ya da şartını değiştirip deneme yapabilirsiniz
            // <: küçüktür
            //=>: sayı eşit ya da büyüktür
            //=<: sayı eşit ya da küçük
            
        }
    }
}
