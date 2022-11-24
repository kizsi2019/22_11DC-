using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 faktorialisa: ");
            Console.WriteLine(faktorialis(6));
            Console.ReadKey();
        }
        static ulong faktorialis(ulong n)
        {
            if (n <= 1) return n;
            return n * faktorialis(n - 1);
        }
    }
}
