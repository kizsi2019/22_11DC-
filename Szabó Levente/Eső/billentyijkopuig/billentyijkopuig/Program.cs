using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyijkopuig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ascii = Console.Read();
            Console.WriteLine("bekért betű: " + (char)ascii + " - ascii kódja: " + ascii);
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine(cki.KeyChar);
            Console.ReadKey();
        }
    }
}
