using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            Random random = new Random();
            int[] bevétel = new int[365];
            int[] kiadás = new int[365];
            int[] profit = new int[365];
            for (int i = 0; i < bevétel.Length; i++)
            {
                bevétel[i] = random.Next(4000, 12000);
                kiadás[i] = random.Next(2000, 4000);
                profit[i] = bevétel[i] - kiadás[i];
                if (profit[i] > max)
                {
                    max = profit[i];
                }
                Console.WriteLine(" A napi profit: " + profit[i]);
            }
            Console.WriteLine("Legnyabobb profit: " + max);
            Console.ReadKey();
        }
    }
}
