using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szinekxd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ez a szöveg kék ");
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("Ez zöld színű szöveg");
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine("Színes"); 
            Console.ResetColor(); 
            Console.WriteLine("Alapértelmezett");
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
            Console.Clear();
            Console.ReadKey();
        }
    }
}
