using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tulteher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Osszegzo(2.4, 3));
            Console.ReadKey();
        }
        static int Osszegzo(int szam1, int szam2) { return szam1 + szam2; }
        static double Osszegzo(double szam1, double szam2) { return szam1 + szam2; }
        static double Osszegzo(double szam1, int szam2) { return szam1+ szam2; }
        static double Osszegzo(int szam1, double szam2) { return szam1 + szam2; }
    }
}
