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
            int[,] homersekletek = new int[30, 24];
            int[] napi_osszeg = new int[30];
            double[] napi_atlag = new double[30];
            int max_homereseklet = 0;
            int min_homerseklet = 0;
            int max_nap = 0;
            int min_nap = 0;
            int max_ora = 0;
            int min_ora = 0;

            Random r = new Random();
            for (int i = 0; i < homersekletek.GetLength(0); i++)
            {
                for (int j = 0; j < homersekletek.GetLength(1); j++)
                {
                    homersekletek[i, j] = r.Next(-15, -5);
                }
            }
            for (int i = 0; i < homersekletek.GetLength(0); i++)
            {
                for (int j = 0; j < homersekletek.GetLength(1); j++)
                {
                    Console.Write(homersekletek[i, j] + " ");
                    napi_osszeg[i] = napi_osszeg[i] + homersekletek[i, j];
                    if (homersekletek[i, j] > max_homereseklet)
                    {
                        max_homereseklet = homersekletek[i, j];
                        max_nap = i;
                        max_ora = j;
                    }
                    if (homersekletek[i, j] > min_homerseklet)
                    {
                        min_homerseklet = homersekletek[i, j];
                        min_nap = i;
                        min_ora = j;
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
            Console.WriteLine("A legmagasabb atlag hőmérsékletű nap indexe " + index);
            Console.WriteLine("A " + max_nap + " nap" + max_ora + " orájában volt a legnagyobb a hőmérséklet");
            Console.WriteLine("A " + min_nap + " nap" + min_ora + " orájában volt a legkisebb a hőmérséklet");
            Console.ReadKey();

        }
    }
}                                                                                                                                                                                                                                                                                                                                               