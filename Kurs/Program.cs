using fns = FirstNameSpace;
using SecondNameSpace;
using System;

namespace Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################");
            Console.WriteLine("# Kurs Szarpania - by Marek Zając #");
            Console.WriteLine("#        Developer - Marcin M.    #");
            Console.WriteLine("#                                 #");
            Console.WriteLine("#         moduł 6 - ex.1 & 2      #");
            Console.WriteLine("#            namespaces           #");
            Console.WriteLine("###################################\n");

            fns.First ff1 = new fns.First();
            fns.First ff2 = new fns.First();
            fns.Second so1 = new fns.Second();
            fns.Second so2 = new fns.Second();

            First fs1 = new First();
            First fs2 = new First();

            ff1.Hello();
            ff2.Hello();
            so1.Hello();
            so2.Hello();
            fs1.Hello();
            fs2.Hello();















        }
    }
}
