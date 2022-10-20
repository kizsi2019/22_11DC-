using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepcso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj emg egy páros számot!");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("x");
                    j++;

                }
                Console.WriteLine();

                for (int j = szam / 2; j > i; j--)
                {

                    Console.Write("x");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
;
}
