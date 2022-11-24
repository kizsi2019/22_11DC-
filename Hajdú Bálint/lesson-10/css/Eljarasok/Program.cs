using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljarasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kiír();
            int i = Osszeg();
            Console .WriteLine(i);
            Console.ReadLine();
        }
        static void kiír()
        {
            Console.WriteLine("Ez kiír valamit a képernyőre");
            Console.ReadKey();
        }
        static int Osszeg()
        {
            return 5 + 7;
        }

    }
}
