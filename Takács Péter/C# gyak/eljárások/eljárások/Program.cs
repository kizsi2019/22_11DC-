using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eljárások
{
    class Program
    {
        static void Main(string[] args)
        {
            //kiir();
            int i = osszeg();
            Console.WriteLine(i);
            Console.ReadKey();
        }
        static void kiir()
        {
            Console.WriteLine("ez kiír valamit a képernyöre");
            Console.ReadKey();
        }
        static int osszeg()
        {
            return 5 + 7;
        }
    }
}
