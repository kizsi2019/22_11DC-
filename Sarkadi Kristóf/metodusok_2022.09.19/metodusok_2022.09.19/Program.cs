using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodusok_2022._09._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ez zöld színű szöveg");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Szín");
            Console.ResetColor();
            Console.WriteLine("Alapértelmezett");
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
            Console.Clear();
            Console.Beep(400, 1000);
            Console.Title = "ablak";
            int m = Console.WindowHeight, sz = Console.WindowWidth; 
            Console.WriteLine(m + "*" + sz);
            Console.SetWindowSize(50, 40);
            int m = Console.WindowHeight; 
            int sz = Console.WindowWidth; 
            Console.SetCursorPosition(sz / 2, m / 2);
            double x = -20.5; 
            x = Math.Abs(x);
            //Megoldás: 20.5
            doublex = 12.6; 
            x = Math.Ceiling(x); 
            //Megoldás: 13

            Console.ReadKey();
        }
    }
}
