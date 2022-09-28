using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ez kék hátterű szöveg");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ez zöld színű szöveg");
        }
    }
}
