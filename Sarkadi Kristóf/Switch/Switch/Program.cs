using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Switch
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
                    Console.Write("Nem jó számot adott meg!"); break;
            }
            Console.ReadKey();
        }
    }
}
