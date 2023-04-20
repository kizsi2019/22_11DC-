using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 }; 
            int[] FTömb1 = new int[Tömb.Length]; 
            int[] FTömb2 = new int[Tömb.Length]; 
            int i1 = 0, i2 = 0; 
            for (int i = 0; i < Tömb.Length; i++) 
            { 
                if (Tömb[i] > 15) 
                { 
                    FTömb1[i1] = Tömb[i]; 
                    i1++; 
                } 
                if (Tömb[i] < 9) 
                { 
                    FTömb2[i2] = Tömb[i]; i2++; 
                } 
            }
            Console.WriteLine("FTömb1: ");
            foreach (var item in FTömb1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ftömbb2: ");
            foreach (var item in FTömb2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
