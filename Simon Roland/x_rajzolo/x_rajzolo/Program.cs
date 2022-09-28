using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_rajzolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számot ");
            int szam = int.Parse(Console.ReadLine());

            for (int i = 1; i <= szam /2 ; i++) 
            {
                int j = 1; 
                while (j <= i) 
                { 
                    Console.Write("x");
                    j++; 
                } 
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
