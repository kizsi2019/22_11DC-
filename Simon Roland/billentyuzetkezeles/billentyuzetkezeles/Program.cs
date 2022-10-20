using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzetkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleKeyInfo cki = Console.ReadKey();
            //int ascii = Console.Read();
            //Console.WriteLine("Bekért betű " + (char)ascii + " - ascii kódja " + ascii);
            //Console.WriteLine(cki.KeyChar);
            //ConsoleKey ck = Console.ReadKey().Key;
            //switch (ck)
            //{
            //case ConsoleKey.UpArrow:
            //   Console.WriteLine("A felfele nyilat nyomtad meg!"); break;
            // case ConsoleKey.DownArrow:
            //       Console.WriteLine("A lefele nyilat nyomtad meg!"); break;
            // }

            ConsoleKeyInfo  cki;
            string jelszo = "";
            do 
            { 
                cki = Console.ReadKey(true);
                if (cki.Key != ConsoleKey.Enter)
                {
                    Console.Write("x");
                    jelszo += cki.KeyChar; 
                } 
            } 
            while (cki.Key != ConsoleKey.Enter);
            if (jelszo == "3930") Console.WriteLine("\nJó jelszó");
            else Console.WriteLine("\nHelytelen jelszó");
            Console.ReadKey();
        }
    }
}
