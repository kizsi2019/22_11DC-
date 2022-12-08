using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csokekno_rendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            for (int i = Tömb.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Tömb[j] < Tömb[j + 1])
                    {
                        int csere = Tömb[j];
                        Tömb[j] = Tömb[j + 1];
                        Tömb[j + 1] = csere;
                    }
                }
            }
            foreach (var item in Tömb)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
