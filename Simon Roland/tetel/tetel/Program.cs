using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace tetel
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
                Console.WriteLine(item + ", ");
            }
            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] > 20) Console.WriteLine("Van benne 20-nál kisebb szám");
                break;
            }
            int max = 0;
            int min = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] > randT[max]) max = i;
                if (randT[i] < randT[min]) max = i;
            }
            Console.WriteLine("A legnagyobb szám indexe {0}, értéke {1}", max, randT[max]);
            Console.WriteLine("A legnagyobb szám indexe {0}, értéke {1}", min, randT[min]);
            int[] oszhato3szamokT = new int[100];
            int osz3_i = 0;
            for (int i = 0; i < randT.Length; i++)
                if
                (randT[i] % 3 == 0)
                {
                    oszhato3szamokT[osz3_i] = randT[i];
                    osz3_i++;
                    Console.WriteLine("Osztható számok hárommal, indexe {0} ", osz3_i);
                }
            int i1 = 0;
            int[] paratlan = new int[randT.Length];
            for (int item = 0; item < randT.Length; item++)
            {
                if (randT[item] % 2 == 1)
                {
                    paratlan[i1] = randT[item]; item++;
 
                }
                for (int i = 0; i < randT.Length; i++)
                {
                    Console.WriteLine(randT[i] + ",");
                }

                for (int i = randT.Length - 1; i > 1; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (randT[j] > randT[j + 1])
                        {
                            int csere = randT[j];
                            randT[j] = randT[j + 1];
                            randT[j + 1] = csere;
                        }
                    }
                }
                for (int i = 0; i < randT.Length; i++)
                {
                    Console.WriteLine(randT[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
