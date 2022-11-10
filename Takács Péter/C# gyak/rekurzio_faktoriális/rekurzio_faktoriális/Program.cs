using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio_faktoriális
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 faktoriális: ");
            Console.WriteLine(Faktoriális(6));
            Console.ReadKey();
        }
        static ulong Faktoriális(ulong n)
        {
            if (n <= 1) return n;
            return n * Faktoriális(n - 1);
        }
    }
}
