using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abszolutoperandus
{
    internal class Program
    {
        static int Abszolutertek(int szam)
        {
            return szam > 0 ? szam : szam * -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Abszolutertek(-5));
            Console.ReadKey();
        }
    }
}
