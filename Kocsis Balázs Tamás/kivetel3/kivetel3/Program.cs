using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetel3
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
                    if (s.Length == 0) throw new Exception("Nem adott meg szöveget");
                    hiba = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(s);
            } while(hiba);
            Console.ReadKey();
                }
    }
}
