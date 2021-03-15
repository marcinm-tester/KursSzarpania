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
            Console.WriteLine("#                                 #" );
            Console.WriteLine("#           moduł 5 - ex.2        #");
            Console.WriteLine("###################################\n");
            //obliczenie pola trapezu
            double a, b, h;

            Trapezoid trapezoid = new Trapezoid();
            trapezoid.a = 8;
            trapezoid.b = 11;
            trapezoid.h = 7;

            double trapezoidField = (trapezoid.a + trapezoid.b) * trapezoid.h / 2;

            Console.WriteLine($"Pole trapezu o bokach {trapezoid.a} i {trapezoid.b} oraz wysokości {trapezoid.h}");
            Console.WriteLine($"wynosi {trapezoidField}");
        }
    }
}
