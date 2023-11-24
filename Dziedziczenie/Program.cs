namespace Dziedziczenie
{
    internal class Program
    {
        class Osoba
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public DateTime Dataurodzenia { get; set; }
            public Adres Adres { get; set; }

            public Osoba(string imie, string nazwisko, DateTime dataurodzenia)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                Dataurodzenia = dataurodzenia;
            }
            public Osoba(string imie, string nazwisko, DateTime dataurodzenia, Adres adres) : this(imie, nazwisko, dataurodzenia)
            {
                Adres = adres;
            }

            public string Pełneimie()
            {
                return Imie + " " + Nazwisko;
            }

            public int Wiek
            {
                get
                {
                    TimeSpan diffrence = DateTime.Now - Dataurodzenia;
                    return (int)(diffrence.Days / 365.25);
                }
            }
        }
        class Adres
        {
            public string Miasto { get; set; }
            public string Ulica { get; set; }
            public string Numerdomu { get; set; }
            public string Kodpocztowy { get; set; }

            public Adres(string miasto, string ulica, string numerdomu, string kodpocztowy)
            {
                Miasto = miasto;
                Ulica = ulica;
                Numerdomu = numerdomu;
                Kodpocztowy = kodpocztowy;
            }
        }

        class Student : Osoba
        {
            public int Numerstudenta { get; set; }
            public Student(string imie, string nazwisko, DateTime dataurodzenia, int numerstudenta) : base(imie, nazwisko, dataurodzenia) 
            {
                Numerstudenta = numerstudenta;
            }

            public Student(string imie, string nazwisko, DateTime dataurodzenia, Adres adres, int numerstudenta) : base(imie, nazwisko, dataurodzenia,adres)
            {
                Numerstudenta = numerstudenta;
            }

        }

        class Nauczyciel : Osoba
        {
            public List<string> Przedmioty { get; set; }
            public Nauczyciel(string imie, string nazwisko, DateTime dataurodzenia, List<string> przedmioty) : base(imie,nazwisko, dataurodzenia)
            {
                Przedmioty = przedmioty;
            }
            public Nauczyciel(string imie, string nazwisko, DateTime dataurodzenia, Adres adres,List<string> przedmioty) : base(imie, nazwisko, dataurodzenia)
            {
                Adres = adres;
            }
        }
        static void Main(string[] args)
        {
            // Osoba o = new Osoba("Janusz", "Kowalski", DateTime.Parse("2000-04-22"));

            Osoba o = new Osoba("Janusz", "Kowalski", new DateTime(2002, 5, 9) , new Adres("Grodzisk Wielkopolski","Szeroka","12A","62-065"));
            Console.WriteLine(o.Pełneimie());
            Console.WriteLine(o.Wiek);
            Console.WriteLine($"Imie i nazwisko: {o.Pełneimie()}, Data urodzenia: {o.Dataurodzenia.ToShortDateString()}, Adres: Miasto: {o.Adres.Miasto}, Ulica: {o.Adres.Ulica}, Numer domu: {o.Adres.Numerdomu}, Kod pocztowy:  {o.Adres.Kodpocztowy}");

            Student s = new Student("Janusz", "Kowalski", new DateTime(2002, 5, 9), new Adres("Grodzisk Wielkopolski", "Szeroka", "12A", "62-065"), 12345);
            Console.WriteLine(s.Pełneimie());

            Nauczyciel n = new Nauczyciel("Katarzyna", "Kowalska", new DateTime(1987, 7, 12), new Adres("Grodzisk Wielkopolski", "Półwiejska", "25", "62-065"),new List<string>() { "Matematyka", "Niemiecki" });        }
    }
}