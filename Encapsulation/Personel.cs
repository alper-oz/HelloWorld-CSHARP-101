using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Encapsulation
{
    public class Personel
    {
        private string tc;
        public string TCKIMLIKNO
        {
            get
            {
                return tc.Substring(0, 5);
            }
            set
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);
                        if (sayimi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("TC kimlik no sadece sayı olabilir.");
                        Console.ReadLine();
                    }
                    else
                    {
                        tc = value;
                    }

                }
                else
                {
                    Console.WriteLine("TC kimlik no hatalı");
                    Console.ReadLine();
                }
            }
        }
    }
}
