using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4_StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Student student1 = new Student(458, "Alper", "Öz", 70, 50, 45, "Bandırma 17 Eylül Üniversitesi");
            Console.WriteLine("Öğrenci Uygulaması'na Hoş geldiniz... Lütfen bir seçim yapın.");
            while (check)
            {
                ShowProcess();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        student1.ShowCase();
                        break;
                    case "2":
                        double student_average = student1.FindNote();
                        Console.WriteLine("Öğrencinin Ortalaması:" + student_average);
                        break;
                    case "3":
                        student1.School();
                        break;
                    case "4":
                        check = false;
                        break;
                }
            }
        }
        static void ShowProcess()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Göster");
            Console.WriteLine("4- Çıkış yap");
        }
    }
}
