using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubisrendezes_tetele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            for (int i = tomb.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] < tomb[j + 1])
                    {
                        int csere = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = csere;
                    }
                }
            }
            
            Console.WriteLine("Tömb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
