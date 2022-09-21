using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ciklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a fakt változót 1-ről indítsuk, mivel ez nem foglya befolyásolni a megoldást 
            int fakt = 1; // elég lenne az i-t 2-vel indítani mivel az eggyel való szorzásnak nincs jelentősége 
            for (int i = 1; i <= 10; i++)
            {
                //fakt = fakt * i; rövidített alakja; 
                fakt *= i;
            }
            Console.WriteLine(fakt);
            Console.ReadKey();
        }
    }
}
