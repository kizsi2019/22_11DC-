using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mátrix_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,4];
            Random r = new Random();
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                for( int j = 1; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = r.Next(1, 100);
                }
            }
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(0); j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");

                }
            }
            Console.ReadKey();
        }
    }
}
