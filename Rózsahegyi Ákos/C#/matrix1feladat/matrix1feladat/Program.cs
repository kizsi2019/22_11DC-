using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix1feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] homersekletek = new int[30, 24];
            int[] napi_osszeg = new int[30];
            double[] napi_atlag = new double[30];
            int max_hom = 0;
            int min_hom = 0;
            int max_nap = 0;
            int min_nap = 0;
            int max_ora = 0;
            int min_ora = 0;


            for (int i = 0; i < homersekletek.GetLength(0); i++)
            {
                for (int x = 0; x < homersekletek.GetLength(1); x++)
                {
                    homersekletek[i, x] = r.Next(-5, 15);
                }
            }
            for (int i = 0; i < homersekletek.GetLength(0); i++)
            {
                for (int x = 0; x < homersekletek.GetLength(1); x++)
                {
                    Console.Write(homersekletek[i, x] + " ");
                    napi_osszeg[i] = napi_osszeg[i] + homersekletek[i, x];

                    if (homersekletek[i, x] > max_hom)
                    {
                        max_hom = homersekletek[i, x];
                        max_nap = i;
                        max_ora = x;
                    }
                    if (homersekletek[i, x] < min_hom)
                    {
                        min_hom = homersekletek[i, x];
                        min_nap = i;
                        min_ora = x;
                    }
                }
                napi_atlag[i] = Convert.ToDouble(napi_osszeg[i]) / homersekletek.GetLength(1);
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

            Console.WriteLine("A legmagasabb átlaghőmérsékletű nap indexe: " + index);
            Console.WriteLine("A " + max_nap + " nap " + max_ora + " órájában volt a legnagyobb a hőmérséklet.");
            Console.WriteLine("A " + min_nap + " nap " + min_ora + " órájában volt a legkisebb a hőmérséklet.");
            Console.ReadKey();
        }
    }
}
