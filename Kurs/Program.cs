using System;

namespace Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Number;

            Console.WriteLine("###################################");
            Console.WriteLine("# Kurs Szarpania - by Marek Zając #");
            Console.WriteLine("#        Developer - Marcin M.    #");
            Console.WriteLine("#                                 #");
            Console.WriteLine("#               moduł 7           #");
            Console.WriteLine("#         interakcja z userem     #");
            Console.WriteLine("###################################\n");

            Console.Write("Podaj imie: ");
            Name = Console.ReadLine();
            Console.Write("Podaj liczbe: ");
            Number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Drogi użytkowniku {Name}.");
            Console.WriteLine($"Uważasz, że liczba {Number} jest właściwa ?");
            Console.WriteLine($"Czy {Number} ma dla Ciebie takie znaczenie ?");
            Console.WriteLine($"Dziwnie {Name}, że wybrana przez Ciebie liczba to {Number}.");
            Console.WriteLine($"A może podając {Number} miałeś na myśli {++Number} ?");
            Console.WriteLine($"Jak sądzisz {Name} ? ");
        }
    }
}
