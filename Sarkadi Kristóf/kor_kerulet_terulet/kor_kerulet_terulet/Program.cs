using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor_kerulet_terulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add meg a kör sugarát.");
            int sugar = int.Parse(Console.ReadLine());
            double pi = 3.14, hatvany = 2;
            double pow = Math.Pow(pi, hatvany);
            Console.WriteLine("A kör kerülete: " + Math.Round(sugar + pow));
            Console.WriteLine("A kör kerülete: " + Math.Round(sugar * 2 + pow));


            Console.ReadKey();
        }
    }
}
