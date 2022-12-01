using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes_tetele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //összegzés tétele:
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 405, 42 };
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: " + osszeg);
            Console.ReadKey();
        }
    }
}
