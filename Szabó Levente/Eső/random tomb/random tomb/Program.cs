using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] veletlen = new int[10];
            RandTomb(veletlen, 10, 100);
            foreach (int item in veletlen)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            }
        static void RandTomb(int[] tomb, int mettol, int meddig)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(mettol, meddig);
            }
        }
    }
}
