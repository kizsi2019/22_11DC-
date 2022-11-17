using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_rajzoloú
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adj meg egy páros számot: ");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                int j = 1;
                while (j <= szam / 2)
                {
                    Console.Write("x");
                    j++;
                }
                Console.WriteLine();
            }Console.ReadKey();

        }
    }
}
