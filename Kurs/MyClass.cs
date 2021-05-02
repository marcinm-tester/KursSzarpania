using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    class MyClass : IMyInterface
    {
        public void Run()
        {
            Console.WriteLine("w MyClass uruchomiono Run");
            return;
        }
    }
}
