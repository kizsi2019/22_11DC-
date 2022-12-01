using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontes_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] >= 15)
            {
                j++;
            }
            for (int i = 0; i < randT.Length; i++)
            {
                Console.WriteLine(randT[i]);
            }
            if (j < randT.Length)
                Console.WriteLine("Van 15-nél nagyobb szám");
            else Console.WriteLine("Nincs 15-nél nagyobb szám");
            Console.ReadKey(); 
        }
    }
}