using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam == 0)
            {
                Console.WriteLine("A megadott szám 0");
            }
            else if (szam > 0)
            {
                Console.WriteLine("A megadott szám pozitív");
            }
            else if (szam < 0)
            {
                Console.WriteLine("A megadott szám negatív");
            }
            Console.ReadKey();
        }
    }
}
