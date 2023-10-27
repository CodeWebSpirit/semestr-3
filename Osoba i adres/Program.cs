using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Osoba osoba = new Osoba();
            osoba.Imie = "Bartosz";
            osoba.Nazwisko = "Cieżuch";
            Adres CieżuchAdres = new Adres()
            {
                Ulica = "Zdrój",
                NumerDomu = "4",
                NumerMieszkania = "A",
                KodPocztowy = "62-065",
                Miasto = "Grodzisk Wielkopolski",
                Państwo = "Polska",
            };*/
            Console.WriteLine("Podaj liczbe kontaktów: ");
            int liczbakontaktów = int.Parse(Console.ReadLine());
            Osoba[] ludzie = new Osoba[liczbakontaktów];
            for(int i = 0; i < liczbakontaktów; i++)
            {
                Console.WriteLine($"Podaj imię kontaktu #{i + 1}:");
                string imie = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko kontaktu #{i + 1}:");
                string nazwisko = Console.ReadLine();

                ludzie[i] = new Osoba();

                Console.WriteLine($"Podaj ulicę kontaktu #{i + 1}:");
                string Ulica = Console.ReadLine();

                Console.WriteLine($"Podaj numer domu kontaktu #{i + 1}:");
                string NumerDomu = Console.ReadLine();
            }
        }
        
            
               
        
            
        
        
       
            
        

    }
}