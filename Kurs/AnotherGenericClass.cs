using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    interface MyInterface
    {
    }

    class AnotherHenericClass<T>
        where T : MyInterface
    {
        public T Field { get; set; }
    }
}
