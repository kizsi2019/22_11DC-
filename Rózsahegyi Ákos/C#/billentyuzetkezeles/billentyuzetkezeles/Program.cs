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
            //int ascii = Console.Read();
            //Console.WriteLine("Bekért betű " + (char)ascii + " -  ascii kódja: " + ascii);
            //Console.ReadKey();

            //ConsoleKeyInfo cki = Console.ReadKey();
            //Console.WriteLine(cki.KeyChar);
            //Console.ReadKey();

            ///ConsoleKey ck = Console.ReadKey().Key;
            ///Console.WriteLine(ck);
            ///Console.ReadKey();

            ///ConsoleKey ck = Console.ReadKey().Key;
            ///switch (ck)
            ///{
            ///case ConsoleKey.UpArrow:
            ///Console.WriteLine("A felfelé nyilat nyomtad meg!"); break;
            ///case ConsoleKey.DownArrow:
            ///Console.WriteLine("A lefelé nyilat nyomtad meg!"); break;
            ///case ConsoleKey.Enter:
            ///Console.WriteLine("Az Enter-t nyomtad meg!"); break;
            ///case ConsoleKey.F:
            ///Console.WriteLine("Az F betűt nyomtad meg!"); break;
            ///case ConsoleKey.G:
            ///Console.WriteLine("Glory to Arstotzka!"); break;
            ///}
            ///Console.ReadKey();

            ConsoleKeyInfo cki;
            string jelszo = "";
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key != ConsoleKey.Enter)
                {
                    Console.Write("*");
                    jelszo += cki.KeyChar;
                }
            } while (cki.Key != ConsoleKey.Enter);

            if (jelszo == "1234") Console.WriteLine("\nJó jelszó");
            else Console.WriteLine("\nHelytelen jelszó");
            Console.ReadKey();
        }
    }
}
