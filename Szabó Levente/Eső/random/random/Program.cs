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
            int dobott = r.NextDouble();
            Console.WriteLine("A dobott szám: " + dobott);
            Console.ReadKey();
        }
    }
}
