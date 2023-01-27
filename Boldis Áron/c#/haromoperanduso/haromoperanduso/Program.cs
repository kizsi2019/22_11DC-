using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromoperanduso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Irj be egy számot: ");
            int szám = int.Parse(Console.ReadLine());
            if (szám < 0)
                Console.WriteLine("Negatív");
            else
                Console.WriteLine("Pozitív");
            Console.WriteLine(szám < 0 ? "Negatív" : "Pozitív");
            Console.ReadKey();
        }
    }
}
