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
            int[,] homerseklet_matrix = new int[30, 24];
            int[] napi_osszeg = new int[30];
            double[] napi_atlag = new double[30];
            int max_hom = 0;
            int min_hom = 0;
            int max_nap = 0;
            int min_nap = 0;
            int max_ora = 0;
            int min_ora = 0;
            
            Random r = new Random();
            for (int i = 0; i < homerseklet_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < homerseklet_matrix.GetLength(1); j++)
                {
                    homerseklet_matrix[i, j] = r.Next(-5, 15);
                }
            }
            for (int i = 0; i < homerseklet_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < homerseklet_matrix.GetLength(1); j++)
                {
                    Console.Write(homerseklet_matrix[i, j] + " ");
                    napi_osszeg[i] = napi_osszeg[i] + homerseklet_matrix[i, j];
                    if (homerseklet_matrix[i, j] > max_hom)
                    {
                        max_hom = homerseklet_matrix[i, j];
                        max_nap = i;
                        max_ora = j;
                    }
                    if (homerseklet_matrix[i, j] > min_hom)
                    {
                        min_hom = homerseklet_matrix[i, j];
                        min_nap = i;
                        min_ora = j;
                    }
                }
                napi_atlag[i] = Convert.ToDouble(napi_osszeg[i]) / homerseklet_matrix.GetLength(1);
                Console.WriteLine();
            }
            double max = 0;
            int index = 0;
            for (int k = 0; k < homerseklet_matrix.Length; k++)
            {
                if (napi_atlag[k] > max)
                {
                    max =napi_atlag[k];
                    index = k;
                }
            }

            Console.WriteLine("A legmagasabb átlag hőmérsékletű nap indexe: " + index);
            Console.WriteLine("A " + max_nap + " nap" + max_ora +" órájaban volt a legnagyobb hőmérséklet");
            Console.WriteLine("A " + min_nap + " nap" + min_ora + " órájaban volt a legnagyobb hőmérséklet");

            Console.ReadKey();
        }
    }
}
