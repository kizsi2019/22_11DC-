using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalrtoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            byte randszam = byte.Parse(Console.ReadLine());
            byte tipp = 0;
            do
            {
                Console.WriteLine("Tipp: ");
                tipp = byte.Parse(Console.ReadLine());
                if (tipp > randszam)
                {
                    Console.WriteLine("Nagyobb");
                }
                else if (tipp < randszam)
                {
                    Console.WriteLine("Kisebb");
                }
                else
                    Console.WriteLine("Nagyobb");
            } while (tipp != randszam);
            Console.ReadKey();
        }
    }
}
