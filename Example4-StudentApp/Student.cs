using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4_StudentApp
{
    public class Student
    {
        private int ID;
        private string FirstName;
        private string LastName;
        private int example1;
        private int example2;
        private int final;
        private string SchoolName;

        //yapıcı method CONSTRUCTOR METHOD
        public Student(int _ID, string _FirstName, string _LastName, int _example1, int _example2, int _final, string _SchoolName)
        {
            ID= _ID;
            FirstName= _FirstName;
            LastName= _LastName;
            example1 = _example1;
            example2 = _example2;
            final = _final;
            SchoolName = _SchoolName;
        }
        public void ShowCase()
        {
            Console.WriteLine("Öğrenci numarası:" + ID);
            Console.WriteLine("Öğrenci adı:" + FirstName);
            Console.WriteLine("Öğrenci soyadı:" + LastName);
            Console.WriteLine("Öğrenci vize:" + example1);
            Console.WriteLine("Öğrenci final:" + example2);
            Console.WriteLine("Öğrenci büt:" + final);
            Console.WriteLine("Öğrenci okul ismi:" + SchoolName);
        }

        public double FindNote()
        {
            double average = example1 * 0.2 + example2 * 0.2 + final * 0.6;
            return average;
        }

        public void School()
        {
            Console.WriteLine("Öğrencinin okul ismi:" + SchoolName);
        }
    }
}
