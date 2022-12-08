using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tulterheles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Osszegzo(10, 20);
            double b = Osszegzo(11.5, 13.2);
            double c = Osszegzo(13.1, 10);
            Console.WriteLine(Osszegzo(7,3));
            Console.WriteLine(Osszegzo(7.6, 3.6));
            Console.WriteLine(Osszegzo(7.2, 3));
            Console.WriteLine(Osszegzo(7, 3.6));
            Console.ReadKey();
        }
        static int Osszegzo(int szam1, int szam2)
        {
            return szam1 + szam2;
        }
        static double Osszegzo(double szam1, double szam2)
        {
            return szam1 + szam2;
        }
        static double Osszegzo(double szam1, int szam2)
        {
            return szam1 + szam2;
        }
        static double Osszegzo(int szam1, double szam2)
        {
            return szam1 + szam2;
        }
    }
}
