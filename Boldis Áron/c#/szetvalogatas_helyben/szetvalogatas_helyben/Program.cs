using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas_helyben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int e = 0;
            int u = Tömb.Length - 1;
            while (e < u)
            {
                int csere = 0;
                if (Tömb[e] > 20)
                    e++;
                else
                {
                    csere = Tömb[e];
                    Tömb[e] = Tömb[u];
                    Tömb[u] = csere;
                    u--;
                }
            }
            foreach(int i in Tömb)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
