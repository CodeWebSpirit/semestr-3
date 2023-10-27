using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Adres
    {
        public string Ulica {  get; set; }
        public string NumerDomu { get; set;}
        public string NumerMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto {  get; set; }
        public string Państwo {  get; set; }

        public string AdresPocztowy
        {
            get
            {
                return $"ul. {Ulica} {NumerDomu}/{NumerMieszkania}\n{KodPocztowy} {Miasto}\n{Państwo}";
            }
        }
    }
}
