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
            Console.WriteLine("Adj egy paros szamot");
            int szam1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam1; i++)
            {
                int j = 1;
                while (j < i)
                {
                    Console.Write("x");
                    j++;

                    if (j == szam1);
                    {
                        int j = 1;
                        while (j > i)
                        {
                            Console.Write("x");
                            j--;
                        }
                    }
                }
                    Console.WriteLine();
                }
            Console.ReadKey();
            }
        }
    }
