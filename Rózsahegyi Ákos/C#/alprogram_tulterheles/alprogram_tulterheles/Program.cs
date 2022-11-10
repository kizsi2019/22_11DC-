using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alprogram_tulterheles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(osszegzo(5, 3.8));
            Console.ReadKey();
        }

        static int osszegzo(int szam1, int szam2) { return szam1 + szam2; }
        static double osszegzo(double szam1, double szam2) { return szam1 + szam2; }
        static double osszegzo(double szam1, int szam2) { return szam1 + szam2; }
        static double osszegzo(int szam1, double szam2) { return szam1 + szam2; }
    }
}
