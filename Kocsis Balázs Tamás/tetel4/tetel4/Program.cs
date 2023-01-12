using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetel4
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
            int szam = 0;
            foreach (int item in randT)
            {
                Console.Write(item + ", ");
                break;
            }
            for (int i = 0; i < randT.Length; i++)
            {

                if (randT[i] % 3 == 0) szam++;
            }
            Console.WriteLine("A generált tömbben {0}db 3-mal osztható szám van, indexe {1}, értéke{2}", szam);
            Console.ReadKey();
        }
    }
}
