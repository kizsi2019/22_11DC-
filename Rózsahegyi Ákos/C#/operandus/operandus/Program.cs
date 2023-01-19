using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írjá be egy számot:");
            int szam = int.Parse(Console.ReadLine());
            //if-else -vel:
            if (szam < 0)
                Console.WriteLine("Negatív");
            else
                Console.WriteLine("Pozitív");
            //A ternáris operátorral:
            Console.WriteLine(szam < 0 ? "Negatív" : "Pozitív");
            Console.ReadKey();
        }
    }
}
