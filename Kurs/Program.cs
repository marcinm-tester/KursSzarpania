using System;

namespace Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kurs Szarpania - by Marek Zając");

            //obliczenie pola trapezu
            double a, b, h;

            a = 10;
            b = 11;
            h = 7;
            double trapezoidField = (a + b) * h / 2;

            Console.WriteLine($"Pole trapezu o bokach {a} i {b} oraz wysokości {h}");
            Console.WriteLine($"wynosi {trapezoidField}");
        }
    }
}
