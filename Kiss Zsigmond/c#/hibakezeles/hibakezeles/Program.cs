using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hibakezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Adj meg egy számot ");
            try 
            { 
                a = int.Parse(Console.ReadLine()); 
            } 
            catch (FormatException) 
            { 
                Console.WriteLine("Hiba - Nem sikerült átalakítani a bevitt karakterláncot!"); 
            }
            Console.WriteLine("A kapot szám: " + a);
            Console.ReadKey();
        }
    }
}
