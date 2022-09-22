using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lefele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine(i);

            while (i > 0)
            {
                i = i - 2;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
