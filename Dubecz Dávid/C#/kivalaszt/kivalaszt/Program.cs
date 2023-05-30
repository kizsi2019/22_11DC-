using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalaszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int[] FTömb = new int[Tömb.Length];
            int[] FTömb2 = new int[Tömb.Length];
            int j = 0, i2 = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > 15)
                {
                    FTömb[j] = Tömb[i];
                    j++;
                }
                if (Tömb[i] < 9)
                {
                    FTömb2[j] = Tömb[i];
                    i2++;
                }
            }
            Console.WriteLine("Ftömb: ");
            foreach (var item in FTömb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ftömb2: ");
            foreach (var item in FTömb2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
