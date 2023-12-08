namespace _6_3_dziedziczenie_muzyka_zadanie_wyklad
{
    abstract class UtworMuzyczny
    {
        protected string tytul;
        protected string artysta;
        protected string dzwiek;

        public UtworMuzyczny(string tytul, string artysta, string dzwiek)
        {
            this.tytul = tytul;
            this.artysta = artysta;
            this.dzwiek = dzwiek;
        }

        public abstract void Odtwarzaj();
    }

    class Rock : UtworMuzyczny
    {
        protected string gitara;
        public Rock(string tytul, string artysta, string gitara) : base(tytul, artysta, "bębny")
        {
            this.gitara = gitara;
        }

        public override void Odtwarzaj()
        {
            Console.WriteLine($"Odtwarzanie {tytul} przez {artysta}");
            Console.WriteLine($"Dźwięk: {dzwiek}, {gitara}");
        }
    }

    class Pop : UtworMuzyczny
    {
        private string syntezator;
        public Pop(string tytul, string artysta, string syntezator) : base(tytul, artysta, "śpiew")
        {
            this.syntezator = syntezator;
        }

        public override void Odtwarzaj()
        {
            Console.WriteLine($"Odtwarzanie {tytul} przez {artysta}");
            Console.WriteLine($"Dźwięk: {dzwiek}, {syntezator}");
        }
    }

    class Jazz : UtworMuzyczny
    {
        private string saksofon;
        public Jazz(string tytul, string artysta, string saksofon) : base(tytul, artysta, "fortepian")
        {
            this.saksofon = saksofon;
        }

        public override void Odtwarzaj()
        {
            Console.WriteLine($"Odtwarzanie {tytul} przez {artysta}");
            Console.WriteLine($"Dźwięk: {dzwiek}, {saksofon}");
        }
    }

    class Rap : UtworMuzyczny
    {
        private string beat;
        public Rap(string tytul, string artysta, string beat) : base(tytul, artysta, "rym")
        {
            this.beat = beat;
        }

        public override void Odtwarzaj()
        {
            Console.WriteLine($"Odtwarzanie {tytul} przez {artysta}");
            Console.WriteLine($"Dźwięk: {dzwiek}, {beat}");

        }
    }

    class Metal : UtworMuzyczny
    {
        private string znieksztalcenie;
        public Metal(string tytul, string artysta, string znieksztalcenie) : base(tytul, artysta, "krzyk")
        {
            this.znieksztalcenie = znieksztalcenie;
        }

        public override void Odtwarzaj()
        {
            Console.WriteLine($"Odtwarzanie {tytul} przez {artysta}");
            Console.WriteLine($"Dźwięk: {dzwiek}, {znieksztalcenie}");
        }
    }

    class Odtwarzacz
    {
        private List<UtworMuzyczny> listaOdtwarzania;
        public Odtwarzacz()
        {
            listaOdtwarzania = new List<UtworMuzyczny>();
        }

        public void Dodaj(UtworMuzyczny utwor)
        {
            listaOdtwarzania.Add(utwor);
        }

        public void Usun(int numerUtworu)
        {
            listaOdtwarzania.RemoveAt(numerUtworu);
        }

        public void Odtwarzaj(int numerUtworu)
        {
            listaOdtwarzania[numerUtworu].Odtwarzaj();
        }

        public int LiczbaUtworow()
        {
            return listaOdtwarzania.Count();
        }
    }

    internal class Program
    {
        static UtworMuzyczny UtworzUtwor(string gatunek, string tytul, string artysta)
        {
            UtworMuzyczny utwor = null;

            switch (gatunek)
            {
                case "rock":
                    Console.Write("Podaj brzmienie gitary:");
                    string? gitara = Console.ReadLine();
                    utwor = new Rock(tytul, artysta, gitara);
                    break;
                case "pop":
                    Console.Write("Podaj brzmienie syntezy:");
                    string? syntezator = Console.ReadLine();
                    utwor = new Pop(tytul, artysta, syntezator);
                    break;
                case "jazz":
                    Console.Write("Podaj brzmienie saksofonu:");
                    string? saksofon = Console.ReadLine();
                    utwor = new Jazz(tytul, artysta, saksofon);
                    break;
                case "rap":
                    Console.Write("Podaj brzmienie beatu:");
                    string? beat = Console.ReadLine();
                    utwor = new Rap(tytul, artysta, beat);
                    break;
                case "metal":
                    Console.Write("Podaj zniekształcenie dźwięku:");
                    string? znieksztalcenie = Console.ReadLine();
                    utwor = new Metal(tytul, artysta, znieksztalcenie);
                    break;
            }
            return utwor;
        }

        static void Main(string[] args)
        {
            Odtwarzacz odtwarzacz = new Odtwarzacz();
            string odpowiedz;

            do
            {
                Console.Write("Wprowadź gatunek utworu:");
                string gatunek = Console.ReadLine();
                Console.Write("Wprowadź tytuł utworu:");
                string tytul = Console.ReadLine();
                Console.Write("Wprowadź wykonawcę utworu:");
                string artysta = Console.ReadLine();

                UtworMuzyczny utwor = UtworzUtwor(gatunek, tytul, artysta);

                if (utwor != null)
                {
                    odtwarzacz.Dodaj(utwor);
                }

                Console.Write("Czy chcesz dodać kolejny utwór? (t/n):");
                odpowiedz = Console.ReadLine();
            }
            while (odpowiedz == "t" || odpowiedz == "T");

            Console.Clear();
            Console.WriteLine("Lista odtwarzania:\n");

            while (odtwarzacz.LiczbaUtworow() > 0)
            {
                odtwarzacz.Odtwarzaj(0);
                odtwarzacz.Usun(0);
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nLista odtwarzania skończyła się\n\n");

        }
    }
}
