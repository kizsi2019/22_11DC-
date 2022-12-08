using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumi_kliatsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[100];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 1001);
            }
            Console.WriteLine("Rendezés előtt: ");
            foreach (int item in randT)
            {
                Console.Write(item + ", ");
            }
            for (int i = randT.Length - 1; i > 0; i--)
            {
                int m = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (randT[j] > randT[m])
                        m = j;
                }
                int csere = randT[i];
                randT[i] = randT[m];
                randT[m] = csere;
            }
            Console.WriteLine("\nRendezés után: ");
            foreach (int item in randT)
            {
                Console.Write(item + ", ");

            }
            Console.ReadKey();
        }
    }
}
