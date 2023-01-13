using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace tetel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[20];
            Random r = new Random();
            for(int i = 0; i < randT.Length; i++) 
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
                
                if(randT[i] % 2 == 0) paros++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", paros);

            for (int i = 0; i < randT.Length; i++)
            {

                if (randT[i] < 20) paros++;
            }
            Console.WriteLine("A generált tömbben {0}db 20-nél kisebb szám van", paros);

            int max = 0;
            int min = 0;
            for (int i = 0; i < randT.Length; i++)
            {

                if (randT[i] > randT[max]) max = i;
                if (randT[i] < randT[min]) min = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", max, randT[max]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", min, randT[min]);

            int osz3_i = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 3 == 0)
                {
                    randT[osz3_i] = randT[i];
                    osz3_i++;
                    Console.WriteLine("3-mal osztható számok indexe {0}", osz3_i);
                }

                int[] lan = 0;
                int[] paratlan = new int[randT.Length];
                for (int i = 0; i < randT.Length; i++)
                {
                    if (randT[i] % 2 == 1)
                    {
                        paratlan[lan] = randT[i]; i++
                    }
                    for (int i = 0; i < randT.Length; i++)
                    {
                        Console.WriteLine(randT[i] + ",");
                    }

                    

            Console.ReadKey();
        }
        
    }
    
}
