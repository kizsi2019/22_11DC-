using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ciklus_2022._09._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fakt = 1;
            for (int i = 1; i <= 10; i++)
            {
                fakt *= i;
            }
            Console.WriteLine(fakt);
            Console.ReadKey();
        }
    }
}
