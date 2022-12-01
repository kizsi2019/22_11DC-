using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edlontes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < tömb.Length && tömb[i] != 32)
            {
                i++;
            }
            if (i < tömb.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");
            Console.ReadKey();
        }
    }
}
