using System;

namespace Kurs
{
    class CityBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################");
            Console.WriteLine("# Kurs Szarpania - by Marek Zając #");
            Console.WriteLine("#        Developer - Marcin M.    #");
            Console.WriteLine("#                                 #");
            Console.WriteLine("#         Projekt: CityBase       #");
            Console.WriteLine("###################################\n");

            Estate estate = new Estate();
            Console.WriteLine(estate.ToString());
            estate.Propery = FormOfProperty.City.ToString();
            Console.WriteLine(estate.Propery);
        }
    }
}
