using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harom_operandusu_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot!");
            int szám = int.Parse(Console.ReadLine()); 
            //if-else -vel:
            if (szám < 0) Console.WriteLine("Negatív"); 
            else Console.WriteLine("Pozitív"); 
            //A ternáris operátorral:
            Console.WriteLine(szám < 0 ? "Negatív" : "Pozitív");
            Console.ReadKey();
        }
    }
}
