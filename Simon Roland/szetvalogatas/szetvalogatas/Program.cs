using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int[] FTomb1 = new int[Tomb.Length];
            int[] FTomb2 = new int[Tomb.Length];
            int i1 = 0, i2 = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                if (Tomb[i] > 15)
                {
                    FTomb1[i1] = Tomb[i];
                        i1++;
                }
                if (Tomb[i] < 9)
                {
                    FTomb2[i2] = Tomb[i];
                    i2++;
                }
            }
            Console.WriteLine("FTomb1: ");
            foreach (var item in FTomb1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("FTomb2");
            foreach(var item in FTomb2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
