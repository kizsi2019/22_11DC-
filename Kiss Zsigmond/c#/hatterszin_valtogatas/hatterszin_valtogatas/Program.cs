using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatterszin_valtogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] consolecolors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor)); 
            int i = 0; 
            while (true) 
            { 
                Console.BackgroundColor = consolecolors[i]; Console.Clear(); 
                if (i++ == consolecolors.Length - 1) i = 0; 
            }
        }
    }
}
