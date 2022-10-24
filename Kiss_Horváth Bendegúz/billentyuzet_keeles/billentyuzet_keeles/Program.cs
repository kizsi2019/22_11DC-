using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billentyuzet_keeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ascii = Console.Read();
            //Console.WriteLine("Bekért betű: " + (char)ascii + " - ascii kódja: " + ascii); 
            //Console.ReadKey();  


            //ConsoleKeyInfo cki = Console.ReadKey();
            //Console.WriteLine(cki.KeyChar);
            //Console.ReadKey();


            //ConsoleKey ck = Console.ReadKey().Key;
            //Console.WriteLine(ck);
            //Console.ReadKey();


            //ConsoleKey ck = Console.ReadKey().Key;
            //switch (ck)
            //{
            //    case ConsoleKey.UpArrow:
            //        Console.WriteLine("A felfele nyilat nyomtad meg!"); break;
            //    case ConsoleKey.DownArrow:
            //        Console.WriteLine("A lefele nyilat nyomtad meg!"); break;
            //}
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
            if (jelszo == "1234") Process.Start("shutdown", "/s /t 0");
            else Console.WriteLine("\nHelytelen jelszo");
            Console.ReadKey();
        }
    }
}

