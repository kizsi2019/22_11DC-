using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sOKK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] homersekletek = new int[30, 24];
            int[] napok = new int[30];
            double[] napi_atlag = new double[30];
            int max = 0;
            int min = 0;
            int max_nap = 0;
            int min_nap = 0;
            int max_ora = 0;
            int min_ora = 0;

            Random r = new Random();

            for(int i = 0; i < homersekletek.GetLength(0); i++)
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
                    Console.Write(homersekletek[i,x] + " ");
                    napok[i] = napok[i] + homersekletek[i, x];
                    if (homersekletek[i, x] > max)
                    {
                        max = homersekletek[i, x];
                        max_nap = i;
                        max_ora = x;
                    }
                    if (homersekletek[i, x] > min)
                    {
                        min = homersekletek[i, x];
                        min_nap = i;
                        min_ora = x;
                    }
                }
                napi_atlag[i] = Convert.ToDouble(napok[i]) / homersekletek.GetLength(1);
                Console.WriteLine();
            }

            double maxvalami = 0;
            int index = 0;

            for (int k = 0; k < napi_atlag.Length; k++)
            {
                if (napi_atlag[k] > maxvalami)
                {
                    maxvalami = napi_atlag[k];
                    index = k;
                }
            }
            Console.WriteLine("A legmagasabb atlag ho indexe: " + index);
            Console.WriteLine("A " + max_nap + " nap " + max_ora + " orajaban volt a legnagyobb homerseklet");
            Console.WriteLine("A " + min_nap + " nap " + min_ora + " orajaban volt a legkissebb homerseklet");
            Console.ReadKey();
        }
    }
}
