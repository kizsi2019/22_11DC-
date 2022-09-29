using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy páros számot!");
            int szám = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szám; i++)
            {
                int j = 1;
                while (j <= 1)
                {
                    Console.Write("X");
                    j++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
