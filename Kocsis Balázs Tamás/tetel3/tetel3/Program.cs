using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetel3
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
            int max = 0;
            int min = 0;
            foreach (int item in randT)
            {
                Console.Write(item + ", ");
            }
            for (int i = 0; i < randT.Length; i++)
            {

                if (randT[i] > randT[max]) max = i;
                if (randT[i] < randT[min]) min = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", max, randT[max]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", min, randT[min]);
            Console.ReadKey();
        }
    }
}
