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
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };

            int i = 0;
            while (i < tomb.Length && tomb[i] != 32)
            {
                i++;
            }
            if (i < tomb.Length)
                Console.WriteLine("Van");
            else Console.WriteLine("nincs");
            Console.ReadKey();
        }
    }
}
