using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

            int összeg = 0;
            for (int i = 0; i < tömb.Length; i++)
            {
                összeg += tömb[i];
            }
            Console.WriteLine("Összeg: {0}", összeg);
            Console.ReadKey();
        }
    }
}
