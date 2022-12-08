using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvhelyben_tetele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int e = 0;
            int u = tomb.Length - 1;
            while (e < u)
            {
                int csere = 0;
                if (tomb[e] > 20)
                    e++;
                else
                {
                    csere = tomb[e];
                    tomb[e] = tomb[u];
                    tomb[u] = csere;
                    u--;
                }
            }
            Console.WriteLine("Tömb:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
