using System;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n What is your name?");
            string name = Console.ReadLine();
            DateTime date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
