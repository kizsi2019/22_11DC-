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
            for (int i = 1; i <= 5; i++)
            {
                double dobott =Math.Round (r.NextDouble() * 91);
                Console.WriteLine("Szám : " + dobott);
            }
            
            Console.ReadKey();
        }
    }
}
