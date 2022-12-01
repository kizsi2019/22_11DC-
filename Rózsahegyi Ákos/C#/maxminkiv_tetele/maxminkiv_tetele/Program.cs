using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxminkiv_tetele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // maximum/minimum kiválasztás tétele
            int[] tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[legnagyobb_index])
                {
                    legnagyobb_index = i;
                }
                if (tomb[i] < tomb[legkisebb_index])
                {
                    legkisebb_index = i;
                }
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, tomb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, tomb[legkisebb_index]);
            Console.ReadKey();
        }
    }
}
