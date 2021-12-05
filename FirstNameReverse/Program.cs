using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();

            for (int i = userFirstName.Length - 1; i >= 0; i--)
            {
                if (userFirstName.Length > 5)
                {
                    Console.Write(userFirstName[i]);
                }
                else
                {
                    Console.WriteLine(userFirstName);
                    break;
                }
            }
        }
    }
}
