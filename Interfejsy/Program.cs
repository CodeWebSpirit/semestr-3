namespace Interfejsy
{   
    class Książka : IComparable<Książka>
    {
        string tytul;
        public string autor;
        public int rok_publikacji;
        public double cena;

        public Książka(string tytul, string autor,int rok_publikacji,double cena) 
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rok_publikacji = rok_publikacji;
            this.cena = cena;
        }

        public override string ToString()
        {
            return $"{tytul}, {autor}, {rok_publikacji}, {cena}zł";
        }

        public int CompareTo(Książka? other)
        {
            if (other == null) 
            {
                return 1;
            }
            return cena.CompareTo(other.cena);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Książka> Książki = new List<Książka> ();

            Książki.Add(new Książka("Hobbit", "Nowak", 1937, 45.90));
            Książki.Add(new Książka("Hobbit2", "Pawlak", 2000, 145.90));
            Książki.Add(new Książka("Hobbit3", "Adamek", 2000, 5.90));
            Książki.Add(new Książka("Hobbit4", "Adam", 1948, 5.90));

            Książki.Sort();

            Console.WriteLine("Sortowanie według ceny");
            foreach (Książka książka in Książki)
            {
                Console.WriteLine(książka);
            }
            Console.WriteLine();

            Console.WriteLine("\nSortowanie według daty publikacji:");
            var Sortowanieprzezrok = Książki.OrderBy(b => b.rok_publikacji);
            foreach (Książka książka in Sortowanieprzezrok)
            {
                Console.WriteLine(książka);
            }

            Console.WriteLine("\nSortowanie według autora(nierosnąco):");
            var Sortowaniepoautorze = Książki.OrderByDescending(b => b.autor);
            foreach (Książka książka in Sortowaniepoautorze)
            {
                Console.WriteLine(książka);
            }

            Console.WriteLine("\nSortowanie według ceny nierosnąco a następnie daty publikacji");
            var Sortowaniepocenieidacie1 = Książki.OrderByDescending(b => b.cena).ThenBy(b => b.rok_publikacji);
            foreach (Książka książka in Sortowaniepocenieidacie1)
            {
                Console.WriteLine(książka);
            }
        }
    }
}