using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            byte randszam = (byte)r.Next(0, 101);
            byte tipp = 0;
            int db = 0;
            do
            {
                Console.Write("Tipp: ");
                byte v = byte.Parse(Console.ReadLine());
                tipp = v;
                if (tipp < randszam)
                {
                    Console.WriteLine("Nagyobb számra gondoltam!");
                    db = db + 1;
                }
                else if (tipp > randszam)
                {
                    Console.WriteLine("Kisebb számra gondoltam!");
                    db = db + 1;
                }
                else
                    Console.WriteLine("Eltaláltad!");
            } while (tipp != randszam);
            Console.WriteLine("Ennyiből találtad el: " + db);

            Console.ReadKey();
        }
    }
}

