using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalasztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < tomb.Length && tomb[i] != 90)
            {
                i++;
            }
            Console.WriteLine("A 'Feltétel' feltételnek megfelelő elem sorszáma {0}", i);
            Console.ReadKey();
        }
    }
}
