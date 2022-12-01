using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maxkiválasztás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkissebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkissebb_index]) legkissebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem index{0}, ertéke{1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem index{0}, ertéke{1}", legkissebb_index, Tömb[legkissebb_index]);
            Console.ReadKey();
        }
    }
}
