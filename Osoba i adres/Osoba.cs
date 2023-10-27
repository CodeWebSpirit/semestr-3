using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osoba
    {
        public string Imie { get; private set; }
       public string Nazwisko { get; private set; }
        public Adres Adres { get;  set; }
        
        public string Przedstawsię()
        {
            return ($"Nazywam się  {this.Imie} {this.Nazwisko}.\nAdres: {Adres.AdresPocztowy}");
        }

        public void SetData(string imie, string nazwisko, string adres)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Adres = adres;
        }

    }

}
