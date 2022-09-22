using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitiv_2022._09._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam == 0)
            {
                Console.WriteLine("A szam nullával egyenlő.");
            }
            else if (szam > 0)
            {
                Console.WriteLine("A szam nullánál nagyobb.");
            }
            else if (szam < 0)
            {
                Console.WriteLine("A szam nullánál kisebb.");
            }
            Console.ReadKey();
        }
    }
}
