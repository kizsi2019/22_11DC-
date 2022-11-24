using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bevetel = new int[365];
            int[] kiadas = new int[365];
            int[] haszon = new int[365];
            int max = 0;
            Random r = new Random();
            for (int i = 1; i < bevetel.Length; i++)
            {
                bevetel[i] = r.Next(4000, 12000);
                kiadas[i] = r.Next(4000, 4000);
                haszon[i] = bevetel[i] - kiadas[1];
                if (haszon[i] > max)
                {
                    max = haszon[i];
                }
            }
            Console.WriteLine("A legjobb napi haszon: " + max);
            Console.ReadKey();
        }
    }
}
