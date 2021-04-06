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
            Console.WriteLine("#                                 #");
            Console.WriteLine("#                                 #");
            Console.WriteLine("###################################\n");

            string kot = "AAAA";
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(decimal));


            Console.WriteLine("Napisz kilka zdań. Aby zakończyć naciśnij Enter.");
            Console.Write(">");
            string tekst = Console.ReadLine();
            string nowyTekst = "";
            
                string[] zdania = tekst.Split(".");

            for (int i = 0; i < zdania.Length; i++)
            {
                zdania[i] += "(CHYBA)\n";
       
            }

            foreach (string zdanie in zdania)
            {
                nowyTekst += zdanie;
            }

            Console.WriteLine(nowyTekst);
    

        }
    }
}
