using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontes__2022.XII._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömd = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < Tömd.Length && Tömd[i] != 32)
            {
                i++;
            }
            if (i < Tömd.Length)
                Console.WriteLine("van");
            else Console.WriteLine("Nincs");
            Console.ReadKey();
        }
    }
}
