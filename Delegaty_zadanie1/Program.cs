using static Delegaty_zadanie1.Program;

namespace Delegaty_zadanie1
{
    internal class Program
    {
        public delegate int operacja(int x,int y);
        public static int dodaj(int x, int y)
        {
            return x + y;
        }
        public static int odejmij(int x, int y)
        {
            return x - y;
        }
        public static int pomnóż(int x, int y)
        {
            return x * y;
        }
        public static int podziel(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            operacja dodawanie = new operacja(dodaj);
            operacja odejmowanie = new operacja(odejmij);
            operacja mnożenie = new operacja(pomnóż);
            operacja dzielenie = new operacja(podziel);

        }
        public static void WyświetlWyniki(operacja op, int x, int y)
        {
            int wynik;
            if (op.Method.Name == "podziel" && y ==0)
            {
                Console.WriteLine("dzielenie przez zero");
                wynik = 0;
            }
            else {
                wynik = op(x, y);
                Console.WriteLine("wynik operacji na liczbach wynosi", op.Method.Name)
            }
        }
    }
}