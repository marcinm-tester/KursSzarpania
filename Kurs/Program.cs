using System;
using System.Globalization;

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
            Console.WriteLine("#           module 17             #");
            Console.WriteLine("#       GENERYCZNOSC KLAS         #");
            Console.WriteLine("###################################\n");

            var intObj = new GenericClass<int>();


            intObj.Field = 123;
            Console.WriteLine(intObj.Field);

            var stringObj = new GenericClass<string>();
            stringObj.Field = "Kot zjadł Alę";
            Console.WriteLine(stringObj.Field);

            var innaKlasa = new GenericClass<string>();
            innaKlasa.Field = "1233";

            Console.WriteLine(innaKlasa.Field);

            var floatClass = new GenericClass<decimal>();
            floatClass.Field = 12.345M;
            
            Console.WriteLine(floatClass.Field);
            Console.WriteLine(floatClass.Field.ToString(CultureInfo.InvariantCulture.NumberFormat));


            //nowa.Run



        }
    }
}
