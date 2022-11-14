using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billkez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ascii = Console.Read();
            //Console.WriteLine("Betu " + (char)ascii + " - ascii codeja: " + ascii);
            //Console.ReadKey();
            ConsoleKeyInfo cki;
            string jelszo = "";
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key != ConsoleKey.Enter)
                {
                    Console.Write("x");
                    jelszo += cki.KeyChar;
                }
            } while (cki.Key != ConsoleKey.Enter);
            if (jelszo == "1234") Console.WriteLine("\nJó jelszó");
            else Console.WriteLine("\nHelytelen jelszó");
            Console.ReadKey();
        }
    }
}
