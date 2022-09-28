using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor_terulet_kerulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add meg a körsugarát!");
            int sugar = int.Parse(Console.ReadLine());

            double pi = 3.14, hatvany = 2;
            double pow = Math.Pow(pi, hatvany);

            Console.WriteLine("A kör területe: " + Math.Round(sugar * pow));
            Console.WriteLine("A kör kerülete: " + Math.Round(sugar * 2 * Math.PI));
            Console.ReadKey();
        }
    }
}
