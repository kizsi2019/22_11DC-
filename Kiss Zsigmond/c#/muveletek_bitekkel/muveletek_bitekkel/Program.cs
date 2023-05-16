using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muveletek_bitekkel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 13, b = 7; 
            Console.WriteLine("a: " + Convert.ToString(a, 2)); 
            //1101
            Console.WriteLine("b: " + Convert.ToString(b, 2)); 
            //0111
            int c = a & b; 
            Console.WriteLine("c: " + Convert.ToString(c, 2));
            //0101
            Console.WriteLine("a: " + Convert.ToString(a, 2)); 
            //1101 = 13 dec
            int d = a >> 2;
            Console.WriteLine("d: " + Convert.ToString(d, 2)); 
            //0011 = 3 dec
            Console.ReadKey();
        }
    }
}
