using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string imie;
        public string nazwisko;
        public float wzrost;
        public float waga;


        public string getData()
        {
            return "imie i nazwisko: " + imie + " " + nazwisko + "\nwzrost: " + wzrost + "cm, waga: " + waga + "kg";
        }
    }
}
