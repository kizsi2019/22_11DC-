using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Állatok { Kutya, Tigris, Zsiráf, Oroszlán};
        static void Main(string[] args)
        {
            Állatok állat = Állatok.Tigris;
            Console.WriteLine(állat);
            Console.WriteLine("Az 1-esnek megfelelelő a(z): {0}", (Állatok)1);
            Console.WriteLine("A(z) {0}-nak megfelelő szám a(z) {1} ", Állatok.Oroszlán, (int)Állatok.Oroszlán);
            Console.ReadKey();
        }
    }
}
