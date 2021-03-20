using CityBase.Estates;
using System;
using System.Threading;

namespace CityBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################");
            Console.WriteLine("# Kurs Szarpania - by Marek Zając #");
            Console.WriteLine("#        Developer - Marcin M.    #");
            Console.WriteLine("#                                 #");
            Console.WriteLine("#         Projekt: CityBase       #");
            Console.WriteLine("#            module 6             #");
            Console.WriteLine("###################################\n");


            Estate estate = new Estate();
            Console.WriteLine(estate);            
        }
    }
}
