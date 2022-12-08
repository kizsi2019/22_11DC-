using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szétválaszt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamokT = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a {0}. számot: ", i + 1);
                szamokT[i] = int.Parse(Console.ReadLine());
            }
            int e = 0;
            int u = szamokT.Length - 1;
            while (e <= u)
            {
                int csere = 0;
                if (szamokT[e] % 2 == 0)
                    e++;
                else
                {
                    csere = szamokT[e];
                    szamokT[e] = szamokT[u];
                    szamokT[u] = csere;
                    u--;
                }
                Console.ReadKey();
            }
        }
    }
}
