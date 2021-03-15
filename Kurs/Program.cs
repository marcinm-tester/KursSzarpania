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
            Console.WriteLine("#           moduł 5 - ex.3        #");
            Console.WriteLine("#        wykorzystanie enuma      #");
            Console.WriteLine("###################################\n");

            string status = Status.InProgress.ToString();
            Console.WriteLine($"Obecny status to {status}");
            int statusInt = (int) Status.InProgress;
            Console.WriteLine($"Obecny status to {statusInt}");
            Status status1 = Status.InProgress;
            statusInt = (int)status1;
            Console.WriteLine($"Obecny status to {statusInt}");



        }
    }
}
