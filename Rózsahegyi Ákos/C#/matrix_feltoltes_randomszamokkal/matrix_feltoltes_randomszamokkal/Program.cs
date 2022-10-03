using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace matrix_feltoltes_randomszamokkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] matrix = new int[3,4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 100);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(" \n");
            }
            Console.ReadKey();
        }
    }
}
