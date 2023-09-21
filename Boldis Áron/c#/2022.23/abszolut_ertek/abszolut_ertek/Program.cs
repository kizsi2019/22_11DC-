using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abszolut_ertek
{
    internal class Program
    {
        static int AbszolutErtek(int szam)
        {
            return szam > 0 ? szam : szam * -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AbszolutErtek(-10));
            Console.ReadKey();
        }
    }
}
