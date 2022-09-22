using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eloltesztelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meddig írjam ki a páros számokat? "      );
            int meddig = int.Parse(Console.ReadLine());
            int parosszam = 0;
            while (parosszam < meddig)
            {
                parosszam += 2;
                Console.Write(parosszam + ", ");
            }
            Console.ReadKey();  
        }
    }
}
