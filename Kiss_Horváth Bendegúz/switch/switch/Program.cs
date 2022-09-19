using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dobottszam = int.Parse(Console.ReadLine());
            switch (dobottszam)
            {
                case 1:
                    Console.Write("Egy"); break;
                case 2:
                    Console.Write("Kettő"); break;
                case 3:
                    Console.Write("Három"); break;

                default:
                    Console.WriteLine("Nem jo szamot adtal meg"); break;
            }

            Console.ReadKey();

        }
    }
}
