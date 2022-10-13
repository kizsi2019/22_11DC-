using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mátrix2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[30,24];
            int[] osszeg = new int[30];
            double[] atlag = new double[30];
            int maxho = 0;
            int minho = 0;
            int maxnap = 0;
            int minnap = 0;
            int maxh = 0;
            int minh = 0;
            Random r = new Random();

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
                    Console.WriteLine(matrix[i,j]+ " ");
                    osszeg[i] = osszeg[i] + matrix[i, j];
                    if (matrix[i, j] >maxho)
                    {
                        maxho = matrix[i,j];
                        maxnap = i;
                        maxh = j;
                    }
                    if (matrix[i, j] < minho) ;
                    {
                        minho = matrix[i,j];
                        minnap = i;
                        minh = j;
                    }
                }
                atlag[i] = Convert.ToDouble(maxnap) / maxho.GetLength(1);
                Console.WriteLine();
            }
            double maxcucc = 0;
            int index = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                if (atlag[k] > maxcucc)
                {
                    maxcucc = atlag[k];
                    index = k;
                }
            }
            Console.WriteLine("Legmagasabb átlag hő", + index);
            Console.WriteLine("A legnagyob zsutyimutyi", + maxcucc);
        }
    }
}
