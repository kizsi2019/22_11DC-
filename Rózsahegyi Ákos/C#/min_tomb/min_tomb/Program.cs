using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 5, 31, 78, 124, 4048 };
            min(tomb);
            Console.ReadKey();
        }

        static void min(int[] tomb)
        {
            int legk = tomb[0];
            foreach (int item in tomb)
            {
                if (item < legk) legk = item;
            }
            Console.WriteLine("A legkisebb:" + legk);
        }
    }
}
