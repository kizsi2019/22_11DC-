using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
