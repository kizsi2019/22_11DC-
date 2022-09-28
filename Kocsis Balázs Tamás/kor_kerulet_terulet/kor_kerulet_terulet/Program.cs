using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace kor_kerulet_terulet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add meg a kör sugarát: ");
            int r = byte.Parse(Console.ReadLine());
            Console.WriteLine("A kör kerülete " + 2 * r * Math.PI (Math.Round);
            Console.WriteLine("A kör területe " + r * r * Math.PI (Math.Round);
            Console.ReadKey();
        }
    }
}
