using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{
    internal class Pole
    {
        public double boka;
        public double bokb;

        public double pole(double boka, double bokb)
        {
            return boka * bokb;
        }

        public string getData()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            return "Pierwszy bok ma długość:  " + boka + "cm\nDrugi bok ma długość:" + bokb + "cm\nPole prostokąta wynosi: " + pole(boka, bokb) + "cm\u00B2";
        }
    }
}
