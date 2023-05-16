using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetel5
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
                int[] páratlanok = new int[randT.Length];
                int páratlanindex = 0;
                for (int i = 0; i < randT.Length; i++)
                {
                    if (randT[i] % 2 != 0) 
                    {
                        páratlanok[páratlanindex] = randT[i];
                        páratlanindex++;
                    }
                }
                
            
            Console.ReadKey();
        }
    }
}
