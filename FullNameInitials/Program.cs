using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string Lastname = Console.ReadLine();

            Console.WriteLine($"Tere, {Firstname[0]}.{Lastname[0]}");

        }
    }
}
