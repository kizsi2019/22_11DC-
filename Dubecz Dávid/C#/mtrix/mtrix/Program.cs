using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mátrix = new int[,] {
                { 421, 23, 42, 1 },
                { 45, 674, 341, 52 },
                { 56, 12, 343, 54 }
            };
            Console.WriteLine("Magassága: " + mátrix.GetLength(0));
            Console.WriteLine("Szélessége: " + mátrix.GetLength(1));
            Console.ReadKey();
        }
    }
}
