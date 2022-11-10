using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    internal class Program
    {
        enum jegyek { elégtelen = 1, elégséges, közepes, jó, kiváló}
        static void Main(string[] args)
        {
            Console.WriteLine((jegyek)2);
            Console.ReadKey();
        }
    }
}
