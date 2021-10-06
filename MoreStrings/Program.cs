using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            // initsiaalid lõpevad punktiga
            //--> Harry Potter --> H.P.

            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Tere, {userName[0]}. {userLastName[0]}.");
        }
    }
}
