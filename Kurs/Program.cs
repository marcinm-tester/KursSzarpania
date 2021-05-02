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
            Console.WriteLine("#        module 17 ex.2           #");
            Console.WriteLine("#       metody generyczne         #");
            Console.WriteLine("###################################\n");


            var obj = new GenerycznaKlasa();

            obj.Show<int>(11);
            Console.WriteLine("*********************");

            obj.Run<MyClass>(new MyClass());



        }
    }
}
