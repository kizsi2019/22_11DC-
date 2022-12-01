using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldöntéspélda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[10];
            Random r = new Random();
            for (int j = 0; j < tömb.Length; j++)
            {
                tömb[j] = r.Next(0, 21);
            }
            int i = 0;
            while (i < tömb.Length && tömb[i] >= 15)
            {
                i++;
            }
            for(int j = 0; j < tömb.Length; j++)
            {
                Console.WriteLine(tömb[j]);
            }
            if (i < tömb.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");
            Console.ReadKey();
        }
    }
}
