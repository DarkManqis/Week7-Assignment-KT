using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            int ctr = 0;

            while (ctr < 3)
            {
                Console.WriteLine("Sisestage PIN:");
                string PIN = Console.ReadLine();
                Console.WriteLine("Sisestage nimi:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage parool:");
                string password = Console.ReadLine();

                if (PIN.Length == 4)
                {
                    if (userName != "user1" || password != "password1" || PIN != "1532")
                    {
                        Console.WriteLine("Midagi läks valesti. Proovige uuesti.");
                        ctr++;
                    }
                    else if (userName == "user1" && password == "password1" && PIN == "1532")
                    {
                        Console.Write("\nParool sisestati õigesti!\n\n");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Vale PIN, proovi uuesti");
                    ctr++;
                    continue;
                }
            }

        }
    }
}