using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: " + Convert.ToString(a, 2)); //1101 = 13 dec
            int c = a >> 2;
            Console.WriteLine("c: " + Convert.ToString(c, 2)); //0011 = 3 dec
        }
    }
}
