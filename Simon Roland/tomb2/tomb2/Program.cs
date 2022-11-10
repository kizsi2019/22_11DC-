using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb2 = new int[] { 55, 31, 78, 124, 4048 };
            Min(tomb2);
            Console.ReadKey();
        }
        static void Min(int[] tomb)
        {
            int legk = tomb[0];
            foreach (int item in tomb)
            {
                if (item < legk) legk = item;
            }
            Console.WriteLine("A legkisebb: " + legk);
        }
    }
}
