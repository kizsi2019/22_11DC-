using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimenzios_tom_rejderrrrrrrrrrrrrr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mutatokovetor = new int[][]
            {
                new int[] {6,2,2,7,3},
                new int[] {3,1},
                new int[] {12,31,56},
            };
            Console.WriteLine("For ciklussal: ");
            foreach (int[] belsővektor in mutatokovetor)
            {
                foreach (int elem in belsővektor)
                {
                    Console.WriteLine(elem + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
