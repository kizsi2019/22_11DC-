using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int[] FTömb1 = new int[Tömb.Length];
            int[] FTömb2 = new int[Tömb.Length];
            int i1 = 0, i2 = 0;
            for (int i = 0;
                i < Tömb.Length; 
                i++) 
            {
                if (Tömb[i] == Feltétel1) 
                {
                    FTömb1[i1] = Tömb[i];
                    i1++;
                }
                if (Tömb[i] == Feltétel2) { FTömb2[i2] = Tömb[i]; i2++; 
                }
            }
            Console.WriteLine("FTömb1");
        }
    }
}

