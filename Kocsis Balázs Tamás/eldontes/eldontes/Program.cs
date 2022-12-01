using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while ( i < Tömb.Length && Tömb[i] != 32)
            {
                i++;
            }
            if ( i < Tömb.Length)
                Console.WriteLine("van");
            else Console.WriteLine("nincs");
            Console.ReadKey();
        }
    }
}
