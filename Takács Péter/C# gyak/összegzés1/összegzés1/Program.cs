using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace összegzés1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int osszeg = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                osszeg += Tömb[i];
            }
            Console.WriteLine("A tömben tárolt számok összege : {0}", osszeg);
            Console.ReadKey();
        }
    }
}
