using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromoper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot! ");
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
