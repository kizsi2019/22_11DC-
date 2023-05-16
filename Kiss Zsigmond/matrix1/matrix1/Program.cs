using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] randomoltszamok_Matrix = new int[30,24];
            int[] napi_osszeg = new int[30];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    randomoltszamok_Matrix[i, j] = r.Next(-5,15);
                    
                }
                
            }
           
            double[] napi_atlag = new double[30];
            int max_hom = 0;
            int min_hom = 0;
            int max_nap = 0;
            int max_ora = 0;
            int min_nap = 0;
            int min_ora = 0;

            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.Write(randomoltszamok_Matrix[i, j] + "  ");
                    napi_osszeg[i] = napi_osszeg[i] + randomoltszamok_Matrix[i, j];
                    if (randomoltszamok_Matrix[i,j] > max_hom)
                    {
                        max_hom = randomoltszamok_Matrix[i, j];
                        max_nap = i;
                        max_ora = j;
                    }
                    if (randomoltszamok_Matrix[i, j] < min_hom)
                    {
                        min_hom = randomoltszamok_Matrix[i, j];
                        min_nap = i;
                        min_ora = j;
                    }

                }
                napi_atlag[i] = Convert.ToDouble(napi_osszeg[i]) / randomoltszamok_Matrix.GetLength(1);
                Console.WriteLine();
                
            }
            double max = 0;
            int index = 0;
            for (int k = 0; k < napi_atlag.Length; k++)
            {
                if (napi_atlag[k] > max)
                {
                    max = napi_atlag[k];
                    index = k;
                }
            }
            Console.WriteLine(" A legmagasabb átlaghőmérsékletű nap indexe: " + index);
            Console.WriteLine(" A " + max_nap + " nap " + max_ora + " órájában volt a legnagyobb a hőmérséklet");
            Console.WriteLine(" A " + min_nap + " nap " + min_ora + " órájában volt a legkisebb a hőmérséklet");
            Console.ReadKey();
        }
    }
}
