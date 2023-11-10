namespace Konstruktory
{
    class samochód
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public Silnik Silnik { get; set; }

        public samochód(string marka, string model, Silnik silnik) 
        {
            Marka = marka;
            Model = model;
            Silnik = silnik;
        }

        public samochód(string marka,string model,double pojemność,double ilośćpaliwa) 
        { 
            Marka = marka;
            Model = model;
            Silnik.Pojemność = pojemność;
            Silnik.Ilośćpaliwa = ilośćpaliwa;
        }

        public samochód(string marka, string model, double pojemność, double ilośćpaliwa, double pojemnośćbaku)
        {
            Marka = marka;
            Model = model;
            Silnik = new Silnik(pojemność, ilośćpaliwa, pojemnośćbaku);
        }

        public void jedź(int dystans)
        {
            Console.WriteLine("Jadę");
            int time = dystans * 100;
            Thread.Sleep(time);
            Silnik.działaj(dystans);
        }

        public void Tankuj(double ilośćpaliwa)
        {
            if (Silnik.Ilośćpaliwa + ilośćpaliwa > Silnik.Pojemnośćbaku) ;
            throw new Exception("Chcesz zatankować za dużo paliwa");
                Silnik.Ilośćpaliwa += ilośćpaliwa;
        }
            }

    class Silnik
    {
        public double Pojemność { get; set; }

        public double Ilośćpaliwa { get; set; }

        public double Pojemnośćbaku { get; } = 50.0;


        public Silnik(double pojemność, double ilośćpaliwa)
        {
            this.Pojemność = pojemność;
            this.Ilośćpaliwa = ilośćpaliwa;
            this.Pojemnośćbaku = 40.0;
        }

        public Silnik(double pojemność, double ilośćpaliwa, double pojemnośćbaku) : this(pojemność, ilośćpaliwa)
        {
            this.Pojemnośćbaku = pojemnośćbaku;
        }


        public static double litrna100kmnamilenagalon(double litrna100km)
        {
            return 235.214583 / litrna100km;
        }

        public static double milenagalonnalitryna100km(double milanagalon)
        {
            return 235.214583 / milanagalon;
        }

        public void działaj(int dystans)
        {
            double zużyciepaliwa = (Pojemność * 4 * dystans) / 100;
            if (zużyciepaliwa <= Ilośćpaliwa)
            {
                Ilośćpaliwa -= zużyciepaliwa;
                Console.WriteLine("Jestem");
            }
            else
            {
                Console.WriteLine($"Brak paliwa na dojazd do celu{zużyciepaliwa}");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w symulatorze jazdy samochodem\n\n");

            Console.Write("Podaj markę samochodu: ");
            string marka = Console.ReadLine();

            Console.Write("Podaj model samochodu: ");
            string model = Console.ReadLine();

            Console.Write("Podaj pojemność samochodu(w litrach): ");
            double pojemność = double.Parse(Console.ReadLine());

            Console.Write("Podaj ilość paliwa w baku: ");
            double ilośćpaliwa = double.Parse(Console.ReadLine());

            Console.Write("Podaj pojemność zbiornika na paliwo: ");
            double pojemnośćbaku = double.Parse(Console.ReadLine());

            samochód samochód = new samochód(marka, model, pojemność, ilośćpaliwa, pojemnośćbaku);
            bool czy;
            while (czy = true)
            {
                Console.WriteLine("\n1: Jadę");
                Console.WriteLine("\n2: Tankuję");
                Console.WriteLine("\n3: ile mam paliwa");
                Console.WriteLine("\n4: Dane mojego auta");
                Console.WriteLine("\n5: Wyjście z programu");

                Console.Write("\n\nWybierz opcję:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice) 
                {
                    case 1: Console.WriteLine("Jaką odległość chcesz przejechać?:\n");
                        samochód.jedź(int.Parse(Console.ReadLine()));
                        break;
                    case 2:Console.WriteLine("Jaką ilość paliwa chcesz zatankować?:\n");
                        samochód.Tankuj(int.Parse(Console.ReadLine()));
                        break;
                    case 3:Console.WriteLine($"Ilość paliwa: {samochód.Silnik.Ilośćpaliwa}");
                        break;
                    case 4: Console.WriteLine($"Marka: {samochód.Marka}, model: {samochód.Model}\nPojemność: {samochód.Silnik.Pojemność}, ilość benzyny: {samochód.Silnik.Ilośćpaliwa}, pojemność baku: {samochód.Silnik.Pojemnośćbaku}");
                        break ;
                    case 5: Console.WriteLine("Koniec programu");
                        return;
                    default: Console.WriteLine("Nieprawidłowy wybór");
                        break;
                }
            }

            /*
            samochód fiat = new samochód("Fiat", "126p", 1, 25, 40);
            Console.WriteLine($"Marka: {fiat.Marka}, model: {fiat.Model}\nPojemność: {fiat.Silnik.Pojemność}, ilość benzyny: {fiat.Silnik.Ilośćpaliwa}, pojemność baku: {fiat.Silnik.Pojemnośćbaku}");

            Console.WriteLine($"Ilość paliwa: {fiat.Silnik.Ilośćpaliwa}");
            fiat.jedź(100);
            Console.WriteLine($"Ilość paliwa: {fiat.Silnik.Ilośćpaliwa}");
            fiat.Tankuj(10);
            Console.WriteLine($"Ilość paliwa: {fiat.Silnik.Ilośćpaliwa}");
            */
            /*
            Silnik s = new Silnik(2, 33, 66);
            Console.WriteLine($"Pojemność silnika: {s.Pojemność}, ilość paliwa: {s.Ilośćpaliwa}, pojemność baku: {s.Pojemnośćbaku}");

            Silnik s2 = new Silnik(2, 33.5, 40);
            Console.WriteLine($"Pojemność silnika: {s2.Pojemność}, ilość paliwa: {s2.Ilośćpaliwa}, pojemność baku: {s2.Pojemnośćbaku}");
            */

            /* Console.WriteLine("Przeliczenie z l/100km na mile/galon");
             double litrna100km = 7.5;
             double milanagalon = silnik.litrna100kmnamilenagalon(litrna100km);
             Console.WriteLine($"{litrna100km}l/100km jest równe {milanagalon:F4}mpg");

             Console.WriteLine("Przeliczenie z mile/galon na l/100km");
             milanagalon = 31.3619;
             litrna100km = silnik.litrna100kmnamilenagalon(milanagalon);
             Console.WriteLine($"{milanagalon}mpg jest równe {litrna100km:F4}l/100km");*/
        }
    }
}
