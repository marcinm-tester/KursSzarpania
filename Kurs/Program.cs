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
            Console.WriteLine("#          module 8, ex.2         #");
            Console.WriteLine("#            if & enum            #");
            Console.WriteLine("###################################\n");

            decimal Number;
            decimal discount;
            decimal sum;
            string type;
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

            type = (Number - sum) > 400 ? UserType.Premium.ToString() : UserType.Standard.ToString();

            Console.WriteLine($"Rabat {discount * 100}% z {Number} wynosi {sum}");
            if (type == "Standard")
            {
                Console.WriteLine("Użytkowniku, dziękujemy za zakupy");
            }
            else
            {
                Console.WriteLine("Użytkowniku! Serdecznie dziękujemy za zakupy!");
            }

        }
    }

    enum UserType
    {
        Standard,
        Premium

    }
}
