using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[20];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 101);
            }
            int paros = 0;
            foreach (int item in randT)
            {
                Console.Write(item + ", ");
            }
            for (int i = 0; i < randT.Length; i++)
            {

                if (randT[i] < 20) paros++;
            }
            Console.WriteLine("A generált tömbben {0}db 20-nél kisebb szám van", paros);
            Console.ReadKey();
        }
    }
}
