namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.imie = "Janusz";
            person.nazwisko = "Nowak";
            person.wzrost = 192;
            person.waga = 100;

            Console.WriteLine("Dane użytkownika: " + person.getData());

            Person kowalski = new Person();
            person.imie = "Andrzej";
            person.nazwisko = "Kowalski";
            person.wzrost = 170;
            person.waga = 100;

            Console.WriteLine("\nDane użytkownika: " + person.getData());
        }
    }
}