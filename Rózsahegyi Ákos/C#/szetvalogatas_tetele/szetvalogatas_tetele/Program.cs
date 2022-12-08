using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas_tetele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int[] ftomb1 = new int[tomb.Length];
            int[] ftomb2 = new int[tomb.Length];
            int i1 = 0, i2 = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 15)
                {
                    ftomb1[i1] = tomb[i];
                    i1++;
                }
                if (tomb[i] < 9)
                {
                    ftomb2[i2] = tomb[i];
                    i2++;
                }
            }
            Console.WriteLine("Tömb 1:");
            foreach (int item in ftomb1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tömb 2:");
            foreach (int item in ftomb2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
