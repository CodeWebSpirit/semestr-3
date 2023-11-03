namespace Konstruktory
{
    class samochód
    {
        public string marka {  get; set; }

        public string model {  get; set; }

        public Silnik Silnik { get; set; }

        public void jedź(int dystans)
        {
            Console.WriteLine("Jadę");
            int time = dystans * 100;
            Thread.Sleep(time);
        }

    }

    class Silnik
    {
        public double Pojemność {  get; set; }

        public double Ilośćpaliwa {  get; set; }

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
            double zużyciepaliwa = Pojemność * 4 * (dystans/100);
            if (zużyciepaliwa > Ilośćpaliwa)
            {
                Ilośćpaliwa -= zużyciepaliwa;
                Console.WriteLine("Jestem");
            }
            else
            {
                Console.WriteLine("Brak paliwa na dojazd do celu");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Silnik s = new Silnik(2, 33, 66);
            Console.WriteLine($"Pojemność silnika: {s.Pojemność}, ilość paliwa: {s.Ilośćpaliwa}, pojemność baku: {s.Pojemnośćbaku}");

            Silnik s2 = new Silnik(2, 33.5, 40);
            Console.WriteLine($"Pojemność silnika: {s2.Pojemność}, ilość paliwa: {s2.Ilośćpaliwa}, pojemność baku: {s2.Pojemnośćbaku}");


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