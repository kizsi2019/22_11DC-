using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[] { 5, 31, 78, 124, 4048 };
            osszegzo(szamok);
            Console.ReadKey();

        }
        static int osszegzo(int[] tomb)
        {
                int ossz = 0;
                foreach (int item in tomb)
                {
                    ossz += item;
                }
                return ossz;
            


        }
    }
}
