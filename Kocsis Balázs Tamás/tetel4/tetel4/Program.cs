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
            foreach (int item in randT)
            {
                Console.Write(item + ", ");
            }
            int osz3_i = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 3 == 0)
                {
                    randT[osz3_i] = randT[i];
                    osz3_i++;
                    Console.WriteLine("3-mal osztható számok indexe {0}", osz3_i);
                }
                
                Console.ReadKey();
            }
        }
    }
}