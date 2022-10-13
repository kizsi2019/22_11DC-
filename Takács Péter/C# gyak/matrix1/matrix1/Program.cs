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
            int[,] randomszamok_matrix = new int[30, 24];
            int[] napi_osszeg = new int[30];
            double[] napi_atlag = new double[30];
            int max_hom = 0;
            int min_hom = 0;
            int max_nap = 0;
            int min_nap = 0;
            int max_ora = 0;
            int min_ora = 0;


            Random r = new Random();
            for (int i = 0; i < randomszamok_matrix.GetLength(0); i++) ;
            {
                for (int j = 0; j < randomszamok_matrix.GetLength(1); j++) ;
                {
                    randomszamok_matrix[i,j] r.Next(-5, 15);
                }
            }
            for (int i = 0; i < randomszamok_matrix.GetLength(0);)
            {
                Console.WriteLine(randomszamok_matrix[i,j] + "");
            }
            Console.WriteLine();
        } 
        Console.Readkey();
    }
}
