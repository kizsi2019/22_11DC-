using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long szam = 0;
            do
            {
                Console.Write("Adj meg egy számot: ");
            } while (!long.TryParse(Console.ReadLine(), out szam));
            Console.WriteLine(szam);
            Console.ReadKey();
        }
    }
}
