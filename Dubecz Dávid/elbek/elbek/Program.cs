using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elbek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EllBekerf("adj meg egy szamot 10 es 20 kozt ", 10,20);
            Console.ReadKey();
        }
        static int EllBekerf(string bekeresuzi, int mettol = int.MinValue, int meddig = int.MaxValue)
        {
            int szam;
            do
            {
                Console.WriteLine(bekeresuzi);
            } while (!int.TryParse(Console.ReadLine(), out szam) || !(szam > mettol && szam < meddig));
            return szam;
        }

    }
}
