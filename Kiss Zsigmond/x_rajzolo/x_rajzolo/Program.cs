using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_rajzolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy páros számot!");
            int szam = int.Parse(Console.ReadLine());

            for (int i = 1; i<=szam/2; i++)
            {
                

                for (int j = szam/2; j > i; j--)
                {
                    
                    Console.Write("X");
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
