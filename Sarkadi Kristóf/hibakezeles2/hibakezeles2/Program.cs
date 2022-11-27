using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hibakezeles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hiba = true;
            do
            {
                string s = "";
                try
                {
                    Console.Write("Kérem a szöveget: ");
                    s = Console.ReadLine();
                    if (s.Length == 0) throw new Exception("Nem adott szöveget");
                    hiba = false;
                    //ide, csak akkor jut ela vezérlés, ha nem lesz kivétel
                }
                catch (Exceptione) 
                { 
                    Console.WriteLine(e.Message); 
                }
            } 
            while (hiba);
            Console.ReadKey();
        }
    }
}
