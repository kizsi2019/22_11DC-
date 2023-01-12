using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            Console.ReadKey();
        }
        
    }
    
}
