using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj szamot");
            int szam = int.Parse(Console.ReadLine());

            if (szam == 0)
            {
                Console.WriteLine("A szam 0");
            }
            else if (szam > 0)
            {
                Console.WriteLine("A szam positiv");
            }
            else if (szam < 0)
            {
                Console.WriteLine("A szam negativ");
            }
            Console.ReadKey();
        }

    }
}
