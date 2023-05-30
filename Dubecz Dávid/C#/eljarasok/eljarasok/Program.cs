using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eljarasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kiir();
            int i = osszeg();
            Console.WriteLine(i);
        }
        static void kiir()
        {
            Console.WriteLine("Csá");
            Console.ReadKey();
        }
        static int osszeg()
        {
            return 5 + 7;
        }
    }
}
