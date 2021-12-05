using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string name = Console.ReadLine();
            Random random = new Random();
            const string chars = "Henry";
            int index = random.Next(0, name.Length);
            Console.WriteLine($"{name[index]}");

        }
    }
}

