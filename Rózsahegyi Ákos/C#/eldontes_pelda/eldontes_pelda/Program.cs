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
            Random r = new Random();
            int[] tomb = new int[10];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 20);
                Console.WriteLine(tomb[i]);
            }
            int j = 0;
            
            while (j < tomb.Length && tomb[j] <= 15)
            {
                j++;
            }
            if (j < tomb.Length)
            {
                Console.WriteLine("Van 15-nél nagyobb szám");
            }
            else
            {
                Console.WriteLine("Nincs 15-nél nagyobb szám");
            }
            Console.ReadKey();
        }
    }
}
