using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megszamlalaspelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                Console.WriteLine(randT[i]);
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("a generalt tombben {0}db paros szam van", db);
            Console.ReadKey();
            
        }
    }
}
