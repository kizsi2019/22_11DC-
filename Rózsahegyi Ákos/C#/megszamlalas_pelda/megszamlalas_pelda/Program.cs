using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megszamlalas_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] tomb = new int[10];
            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0, 21);
            }

            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
                if (tomb[i] % 2 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);
            Console.ReadKey();
        }
    }
}
