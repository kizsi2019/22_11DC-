using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            double dobott = r.NextDouble() * 100;
            Console.WriteLine("A dobott szám: " + dobott);



            Console.ReadKey();
        }
    }
}
