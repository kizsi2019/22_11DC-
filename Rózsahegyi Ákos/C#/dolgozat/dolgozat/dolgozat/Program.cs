using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a dolgozat maximális pontszámát: ");
            int dogamaxp = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a dolgozatban elért pontszámot: ");
            int dogaelertp = int.Parse(Console.ReadLine());
            double szazalek = (double)dogaelertp / dogamaxp * 100;
            if (szazalek > 90)
            {
                Console.WriteLine("A dolgozat jegye: 5");
            }
            else
            {
                if (szazalek > 80)
                {
                    Console.WriteLine("A dolgozat jegye: 4");
                }
                else if (szazalek > 70)
                {
                    Console.WriteLine("A dolgozat jegye: 3");
                }
                else if (szazalek > 60)
                {
                    Console.WriteLine("A dolgozat jegye: 2");
                }
                else
                {
                    Console.WriteLine("A dolgozat jegye: 1");
                }
            }
            Console.ReadKey();
        }
    }
}
