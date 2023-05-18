using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    class Program
    {
        enum Jegyek { Elégtelen = 1, Elégséges, Közepes, Jó, Kiváló }
        static void Main(string[] args)
        {
            Console.WriteLine((Jegyek)2); 
            Console.ReadKey();
        }
    }
}
