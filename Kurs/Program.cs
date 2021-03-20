using fns = FirstNameSpace;
using SecondNameSpace;
using System;
using OtherNameSpace;

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
            Console.WriteLine("#         moduł 6 - ex.3          #");
            Console.WriteLine("#            namespaces           #");
            Console.WriteLine("###################################\n");

            fns.First ff1 = new fns.First();
            fns.First ff2 = new fns.First();
            Second so1 = new Second();
            Second so2 = new Second();

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
