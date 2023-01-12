using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubisrendezes_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            for (int i = Tomb.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Tomb[j] > Tomb[j + 1])
                    {
                        int csere = Tomb[j];
                        Tomb[j] = Tomb[j + 1];
                        Tomb[j + 1] = csere;
                    }
                }
            }
            for (int i = 0; i < Tomb.Length; i++)
            {
                Console.WriteLine(Tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
