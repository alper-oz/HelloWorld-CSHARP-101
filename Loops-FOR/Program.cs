using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------
            //---------------------------------------------------------------------------
            // 1'den 10'a kadar sayıları alt alta ekrana yazdıran program

            //1. kısım DEĞİŞKE_ATAMA ve BAŞLANGIÇ_DEĞERİ
            //2. kısım KOŞUL
            //3. kısım ARTIRMA_AZALTMA

            /*for (int i = 1; i <= 10; i++)
             //for döngüsü 3 kısımdan oluşur; ilk noktalı virgüle kadar olan kısım "int i = 1" int veri tipinde 1 değerini i harfine atadık, ikinci noktalı virgülde; i değişkeni 10'a eşit olsun ya da küçük olsun dedik mantıksal operatör ile, üçüncü kısımda da i değerini her seferinde bir artır dedik. ++ operatörü değeri bir bir artırır.
            {
                Console.WriteLine(i);
            }*/
            // for döngüsünde püf nokta CW içerisine sayıyı bir kere yazdıktan sonra başa döner ama bu kez işlemi bir artıran kısımdan yani noktalı virgüllerin sonundan başlar. ikinci adım olarak 10'a eşit ya da küçük olma koşulunu sağlıyor mu diye kontrol eder ve oradan değer TRUE olarak dönerse CW içine tekrar girer ve döngüyü çalıştırır koşul sağlanana kadar.
            //---------------------------------------------------------------------------
            //---------------------------------------------------------------------------

            // 1'den 10'a kadar sayılardan çift olanları ekrana yazdıran program

            for (int a = 0; a <= 10; a = a + 2) // koşulda = sembolü olmazsa 10 sayısını dahil etmez 9'da durur
                //çift olarak artır dediği için 2-2 artırmam gerekiyor bunun için de a=a+2'de a harfini 0'a eşitlemiştik zaten 0=0+2 ile a'nın yeni değer 2 oldu. FOR döngüsü içinde olduğumuz için KOŞUL bitene kadar döngünün içinde dönmeye devam etti
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
            //---------------------------------------------------------------------------
            //---------------------------------------------------------------------------
        }
    }
}
