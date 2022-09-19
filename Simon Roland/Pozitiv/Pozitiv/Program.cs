using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozitiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam > 0)
            { Console.WriteLine("A szám pozitív");
            }
            else if (szam == 0)
            { Console.WriteLine("A szám 0");
            }
            else Console.WriteLine("A szám negatív");
            Console.ReadKey();
            

           


        }
    }
}
