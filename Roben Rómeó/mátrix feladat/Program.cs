using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mátrix_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] mátrix = new int[30,24];
            int[] napi = new int[30];
            double[] napisum = new double[30];
            int max = 0;
            int min = 0;
            int maxnap = 0;
            int minnap = 0;
            int minora = 0;
            int maxora = 0;

            for (int i = 0; i < mátrix.GetLength(0); i++)
            {
                for (int j = 0; j < mátrix.GetLength(1); j++)
                {
                    mátrix[i, j] = random.Next(-5,15);
                }
            }

            for (int i = 0; i < mátrix.GetLength(0); i++)
            {
                for (int j = 0; j < mátrix.GetLength(1); j++)
                {
                    napi[i] = napi[i] + mátrix[i, j];
                    Console.Write(mátrix[i, j] + " ");
                    if (mátrix[i,j] > max)
                    {
                        max = mátrix[i, j];
                        maxnap = i;
                        maxora = j;
                    }
                    if (mátrix[i, j] > min)
                    {
                        min = mátrix[i, j];
                        minnap = i;
                        minora = j;
                    }
                }
                napisum[i] = Convert.ToDouble(napi) / mátrix.GetLongLength(1);
                Console.WriteLine(" ");
            }
            double maxim = 0;
            int index = 0;
            for (int k = 0; k < napisum.GetLength(0); k++)
            {
                if (napisum[k] > maxim)
                {
                    maxim = napisum[k];
                    index = k;
                }
            }
            Console.WriteLine("legmagasabb átlag nap indexe" + index);
            Console.WriteLine("A" + maxnap + "nap" + maxora + "ora" + "legnyabobb hő");
            Console.WriteLine("A" + minnap + "nap" + minora + "ora" + "legkissweevv hő");
            Console.ReadKey();
        }
    }
}
