using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_tomb_merete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in random_tomb_merete(10, 20, 30))
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
            static int[] randt(int tméret, int mettol, int meddig)
            {
            Random r = new Random();
            int[ ]visszat = new int[tméret];
            for(int i = 0; i < visszat.lenght; i++)
            {
                visszat[i] = r.Next(mettol, meddig);
            }
            return visszat;
        }
    }
}
