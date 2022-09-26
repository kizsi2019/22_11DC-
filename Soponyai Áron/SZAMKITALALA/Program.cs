using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZAMKITALALA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szám = 0;
            Random r = new Random();
            byte randszam = (byte)r.Next(0, 101);
            byte tipp = 0;
            do
            {
                Console.Write("Tipp: "); tipp = byte.Parse(Console.ReadLine());
                if (tipp < randszam)
                {
                    Console.WriteLine("Nagyobb számra gondoltam!");
                    szám = szám + 1;
                }

                else if (tipp > randszam)
                    {
                    Console.WriteLine("Kisebb számra gondoltam!");
                    szám = szám + 1;
                    }

                else
                    Console.WriteLine("Eltaláltad!");

            } while (tipp != randszam);

            Console.WriteLine("Ennyiből találtad ki:" + szám);

            Console.ReadKey();

        }
    }
}
