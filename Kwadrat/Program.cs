namespace Kwadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Pole pole = new Pole();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj pierwszy bok: ");
            Console.ForegroundColor= ConsoleColor.Green;
            while (!double.TryParse(Console.ReadLine(), out pole.boka) || pole.boka <= 0)
            {
                Console.Write("Nieprawidłowe dane. Podaj liczbę większą od zera:");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPodaj drugi bok: ");
            Console.ForegroundColor = ConsoleColor.Green;

            while (!double.TryParse(Console.ReadLine(), out pole.bokb) || pole.bokb <= 0)
            {
                Console.Write("Nieprawidłowe dane. Podaj liczbę większą od zera:");
            }
            Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDane prostokąta: \n" + pole.getData());
            Console.ResetColor();
        }
    }
}