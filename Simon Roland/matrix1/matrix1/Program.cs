using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] matrix = new int[30, 24];
            int[] napi_osszeg = new int[30];
            double[] napi_atlag = new double[30];
            int max_hom = 0;
            int min_hom = 0;
            int max_nap = 0;
            int min_nap = 0;
            int max_ora = 0;
            int min_ora = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(-5, 15);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    napi_osszeg[i] = napi_osszeg[i] + matrix[1, j];
                    if (matrix[i,j] > max_hom)
                    {
                        max_hom = matrix[i,j];
                        max_nap = i;
                        max_ora = j;
                    }
                    
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
