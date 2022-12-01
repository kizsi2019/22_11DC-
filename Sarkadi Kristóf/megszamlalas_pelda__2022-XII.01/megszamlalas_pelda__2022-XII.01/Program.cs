using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megszamlalas_pelda__2022_XII._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[10];
            Random r = new Random();
            //randomolás
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            //megszámlálás tétele:
            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                Console.WriteLine(randT[i]);
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van.", db);
            Console.ReadKey();
        }
    }
}
