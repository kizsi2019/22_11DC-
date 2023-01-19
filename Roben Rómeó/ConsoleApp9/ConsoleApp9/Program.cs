using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 13, b = 7;
            Console.WriteLine("a: " + Convert.ToString(a, 2)); 
            Console.WriteLine("b: " + Convert.ToString(b, 2)); int c = a &
                b; 
            Console.WriteLine("c: " + Convert.ToString(c, 2));

            Console.WriteLine("d: " + Convert.ToString(a, 2));
            int c = a >> 2; 
            Console.WriteLine("d:   " + Convert.ToString(d, 2));
            Console.ReadKey();



        }
    }
}
