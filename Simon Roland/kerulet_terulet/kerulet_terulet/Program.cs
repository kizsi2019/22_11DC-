using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kerulet_terulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adja meg a kör sugarát");
            double r = int.Parse(Console.ReadLine());
            int x = Console.WriteLine("Ez a kör kerülete: "  2 * r * Math.PI  );
            int y = Console.WriteLine("Ez a kör területe: "  r * r * Math.PI );




            
            Console.ReadKey();

            

        }
    }
}
