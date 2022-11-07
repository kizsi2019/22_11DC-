using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnadom_tobb_meretel
{
    internal class Program
    {
        static void Main(string[] args)
        {
        foreach(int item in RandT(10,20,30))
            {
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        Random r = new Random();
        int[] visszaT = new int[Tméret];
            for (int i = 0;i<visszaT.Length;i++)
            {
                visszaT[i] = r.Next(mettol, meddig);
            }
            return visszaT;

    }
}
