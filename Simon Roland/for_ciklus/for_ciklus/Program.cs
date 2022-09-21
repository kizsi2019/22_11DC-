using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ciklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int fakt = 1;
        for (int i = 2; i <= 10; i++) {
                fakt *= i;
            }
        Console.WriteLine(fakt);
        Console.ReadKey();
        }
    }
}
