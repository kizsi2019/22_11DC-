using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorialis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 faktoriálisa: ");
            Console.WriteLine(Faktorialis(7));
            Console.ReadKey();
        }
        static ulong Faktorialis(ulong n)
        {
            if (n <= 1) return n;
            return n * Faktorialis(n - 1);
        }
    }
}
