using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double PI = 3.14;
            Console.WriteLine("adj meg sugarat : ");
            double sugar = Convert.ToDouble(Console.ReadLine());
            double terület = PI * sugar * sugar;
            Console.WriteLine("A terület : " + terület);
            double kerület = PI * sugar * 2;
            Console.WriteLine("A kerület : " + kerület);


            Console.ReadKey();

        }
    }
}
