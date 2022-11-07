using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[] { 5, 31, 78, 124, 4048 };
            Osszegezo(szamok);
            Console.ReadKey();
        }
        static int Osszegezo(int[] tomb)
        {
            int ossz = 0;
            foreach (int item in tomb)
            {
                ossz += item;
            }
            Console.WriteLine(ossz);
            return ossz;
        }
    }
}
