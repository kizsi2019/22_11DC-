using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_rajzolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy páros számot!");
            int szam = byte.Parse(Console.ReadLine());
            int szam2 = szam/2; 

            for (int i = 1; i <= szam2; i++)
            for (int g = szam2; g <= szam2; g--)
                {

                
                int j = i;
                while (j <= szam2)
                {
                    Console.Write("x");
                    j++;
                }

                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
