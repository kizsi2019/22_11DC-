using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdfl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey ck = Console.ReadKey().Key;
            switch (ck)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("felfele"); break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("lefele"); break;
            }
        }
    }
}
