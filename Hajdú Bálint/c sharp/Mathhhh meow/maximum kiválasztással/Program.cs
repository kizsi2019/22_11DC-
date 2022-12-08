using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_kiválasztással
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            
            for (int i = Tömb.Length - 1; i > 0; i--)
            {
                int m = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (Tömb[j] > Tömb[m])
                        m = j;
                }
                int csere = Tömb[i];
                Tömb[i] = Tömb[m];
                Tömb[m] = csere;
            }
            Console.WriteLine();
            

        }
    }
}
