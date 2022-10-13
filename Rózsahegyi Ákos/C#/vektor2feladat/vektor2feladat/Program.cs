using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektor2feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            int[] bevetel = new int[365];
            int[] kiadas = new int[365];
            int[] haszon = new int[365];
            int max = haszon[0];

            int elsorandom = r.Next(4000, 12000);
            int masodrandom = r.Next(2000, 4000);

            for (int i = 0; i < 365; i++)
            {
                bevetel[i] = elsorandom;
                kiadas[i] = masodrandom;
                haszon[i] = bevetel[i] - kiadas[i];
            }

            for (int x = 1; x < haszon.Length; x++)
            {
                if (haszon[x] > max)
                {
                    max = haszon[x];
                }
            }

            Console.WriteLine("Ennyi volt a legjobb nap: " + max);
            Console.ReadKey();
        }
    }
}
