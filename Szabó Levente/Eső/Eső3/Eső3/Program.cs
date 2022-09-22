using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eső3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fakt = 1;
            for (int i = 1; i<=10; i++)
            {
                fakt *= i;
            }
            Console.WriteLine(fakt);
            Console.ReadKey();
        }
    }
}
