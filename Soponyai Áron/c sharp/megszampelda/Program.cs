using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megszampelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[10];
            Random asd = new Random();
            for (int i = 0; i < tömb.Length; i++)
            {
                tömb[i] = asd.Next(0, 25);
            }
            int db = 0;
            for (int i = 0; i < tömb.Length; i++)
            {
                Console.WriteLine(tömb[i]);
                if (tömb[i] %2 == 0) db++;
            }
            Console.WriteLine(db);
            Console.ReadKey();
            rossz mert a tanárúr rohant
        }
    }
}
