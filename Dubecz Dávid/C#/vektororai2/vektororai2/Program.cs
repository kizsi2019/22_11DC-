using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace vektororai2
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

            int elsoR = r.Next(4000, 12000);
            int masodikR = r.Next(2000, 4000);

            for(int i = 0; i < 365; i++)
            {
                bevetel[i] = elsoR;
                kiadas[i] = masodikR;
                haszon[i] = bevetel[i] - kiadas[i];
            }

            for (int x = 1; x < haszon.Length; x++)
            {
                if (haszon[x] > max)
                {
                   max = haszon[x];
                }
            }

            Console.WriteLine("Haszon: " + max);
            Console.ReadKey();
        }
    }
}
