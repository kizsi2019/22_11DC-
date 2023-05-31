using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tombmerettel
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
                int[] visszaT = new int[tmeret];
                for (int i = 0; i < visszaT.Length; i++)
                {
                    visszaT[i] = r.Next(mettol, meddig);
                }
                return visszaT;
            }
    }
}
