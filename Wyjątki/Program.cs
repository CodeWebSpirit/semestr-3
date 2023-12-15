namespace Wyjątki
{
    class AwariaSilnikaException : Exception
    {
        public AwariaSilnikaException(string message) : base(message)
        {

        }
    }

    interface IPoruszalny
    {
        void jedź(int dystans);
        event EventHandler<Samochód> Zepsuty;
    }
    class Samochód : IPoruszalny
    {
        public string marka {  get; private set; }
        public string model { get; private set; }
        public string kolor { get; set; }
        public int pojemnośćsilnika { get; set; }
        public int przebieg {  get; private set; }

        public Samochód(string marka, string model, string kolor, int pojemnośćsilnika)
        {
            this.marka = marka;
            this.model = model;
            this.kolor = kolor;
            this.pojemnośćsilnika = pojemnośćsilnika;
            Zepsuty += (sender, args) => Console.WriteLine("samochód jest zepsuty!");
        }

        public event EventHandler<Samochód> Broken;

        public void jedź(int dystans)
        {
            throw new NotImplementedException();
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}