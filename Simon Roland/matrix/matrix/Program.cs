using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {421, 23, 42, 1  },
                {45, 674, 342, 52 },
                {56, 12, 343, 54 }
            };
            Console.WriteLine("Magassága: " + matrix.GetLength(0));
            Console.WriteLine("Magassága: " + matrix.GetLength(1));
            Console.ReadKey();
        }
    }
}
