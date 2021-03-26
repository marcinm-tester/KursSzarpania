using System;
using System.Collections.Generic;


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
            Console.WriteLine("#           module 9               #");
            Console.WriteLine("#            pętle                 #");
            Console.WriteLine("###################################\n");



            List<int> lista = new List<int>();

            int j;
            string s;
            int liczba;
            Console.WriteLine("Podaj liczbę liczb:");
            Console.Write("> ");
            j = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= j ; i++)
            {
                Console.WriteLine($"Podaj {i}. liczbę: ");
                liczba = int.Parse(Console.ReadLine());
                lista.Add(liczba);
            }

            foreach (int element in lista)
            {
                if (element > 100)
                    Console.WriteLine($"{element}");
            }
            }
        }


}

