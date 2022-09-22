using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int bekertszam = int.Parse(Console.ReadLine());
            if (bekertszam < 0) {
                bekertszam *= -1;
            }
            Console.WriteLine("A megadott szám abszolút értéke: " + bekertszam); 
            Console.ReadKey();
        }
    }
    }+
