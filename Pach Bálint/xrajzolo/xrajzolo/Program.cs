using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xrajzolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy páros számot");
               int  szam = byte.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("x");
                    j++;
                while (szam / 2 > 0)

                    Console.Write("x");
                    j++;

                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
