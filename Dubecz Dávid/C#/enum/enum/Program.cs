using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Allatok { kutya, tigris, zsiraf, oroszlan };
        static void Main(string[] args)
        {
            Allatok allat = Allatok.tigris;
            Console.WriteLine(allat);
            Console.WriteLine("Az 1-esnek megfelelo az: {0}", (Allatok)1);
            Console.WriteLine("Az {0} -nak megfelelo szam az {1}", Allatok.oroszlan, (int)Allatok.oroszlan);
            Console.ReadKey();
        }
    }
}
