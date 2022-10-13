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
            Random r = new Random();
            int[] bevétel = new int [365];
            int[] kiadás = new int [365];
            int[] haszon = new int [365];
            int legjobb = 0;
            for (int i = 0; i < 365; i++)
            {
                bevétel[i] = r.Next(4000, 12000);
                kiadás[i] = r.Next(2000, 4000);
                haszon[i] = bevétel[i] - kiadás[i];
                if (haszon[i] > legjobb)
                {
                    legjobb = haszon[i];
                }
            }
            Console.WriteLine("A haszon", + legjobb);
            Console.ReadKey();
        }
    }
}
