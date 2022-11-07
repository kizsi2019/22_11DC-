using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtomb_merettel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in randt(10, 20, 30))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static int[] randt(int tmeret, int mettol, int meddig)
        {
            Random r = new Random();
            int[] visszat = new int[tmeret];
            for (int i = 0; i < visszat.Length; i++)
            {
                visszat[i] = r.Next(mettol, meddig);
            }
            return visszat;
        }
    }
}
