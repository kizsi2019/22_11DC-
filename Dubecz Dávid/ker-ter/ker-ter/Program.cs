using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ker_ter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor(green);
            Console.WriteLine("adj szamot");
            int radius = int.Parse(Console.ReadLine());



            double terulet = radius * radius * Math.PI;
            double kerulet = 2 * radius * Math.PI;
            Console.ReadKey();
        }
    }
}
