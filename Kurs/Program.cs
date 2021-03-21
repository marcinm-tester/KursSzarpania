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
            Console.WriteLine("#          module 8, ex.1         #");
            Console.WriteLine("#               if                #");
            Console.WriteLine("###################################\n");

            decimal Number;
            decimal discount;
            decimal sum;
            Console.WriteLine("Podaj liczbę: ");
            Console.Write("> ");
            Number = decimal.Parse(Console.ReadLine());

            if (Number > 300)
            {
                discount = 0.1M;
            }
            else if (Number > 200)
            {
                discount = 0.15M;
            }
            else discount = 0.2M;

            sum = Number * discount;
            Console.WriteLine($"Rabat {discount * 100}% z {Number} wynosi {sum}");

        }
    }
}
