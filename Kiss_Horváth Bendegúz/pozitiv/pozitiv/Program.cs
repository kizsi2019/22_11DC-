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
            Console.Write("Adj meg egy számot!");
            int szam = byte.Parse(Console.ReadLine());
            if (szam < 0)
                Console.WriteLine("A megadott szám negatív.");
            if (szam == 0)
                Console.WriteLine("A megadott szám 0 azaz nulla.");
            if (szam > 0)
                Console.WriteLine("A megadott szám pozitív");
            Console.ReadKey();
        }
    }
}
