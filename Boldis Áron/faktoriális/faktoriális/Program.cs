using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriális
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 faktoriálisa: ");
            Console.WriteLine(Faktorialis(10));
            Console.ReadKey();

        }
        static ulong Faktorialis(ulong n)
        {
            if (n <= 1) return n;
            return n * Faktorialis(n - 1);
        }
    }
}
