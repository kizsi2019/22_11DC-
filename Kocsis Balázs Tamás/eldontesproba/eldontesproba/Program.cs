using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldontesproba
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
            if (j < randT.Length) Console.WriteLine("Van 15nél nagyobb");
            else Console.WriteLine("nincs 15nél nagyobb");
            Console.ReadKey();
        }
    }
}
