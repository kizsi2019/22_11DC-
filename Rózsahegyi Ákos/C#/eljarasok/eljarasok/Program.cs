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
            Kiir();
            int i = Osszeg();
            Console.WriteLine(i);
            Console.ReadKey();
        }

        static void Kiir()
        {
            Console.WriteLine("Üdvözöllek a programban!");
            Console.ReadKey();
        }
        static int Osszeg()
        {
            return 5 + 7;
        }
    }
}
