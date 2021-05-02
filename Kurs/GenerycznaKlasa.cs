using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    class GenerycznaKlasa
    {
        public void Show<T>(T value)
        {
            Console.WriteLine(value.ToString());
            Console.WriteLine("w Generyczna Klasa uruchomiono Show");
        }

        public void Run<T>(T value)
            where T : IMyInterface
        {
            value.Run();
            Console.WriteLine("w Generyczna Klasa uruchomiono Run");
        }

    }
}
