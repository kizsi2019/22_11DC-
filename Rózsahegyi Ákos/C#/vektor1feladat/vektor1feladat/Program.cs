using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektor1feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg 20 olyan számot, ami 100 és -100 között van.");
            int[] szamvektor = new int[20];

            for (int i = 0; i < 20; i++)
            {
                szamvektor[i] = int.Parse(Console.ReadLine());
            }

            int darab = 0;
            int osszeg = 0;
            int min = szamvektor[0];
            int max = szamvektor[0];
            
            for (int i = 1; i < szamvektor.Length; i++)
            {
                osszeg += szamvektor[i];
                if (szamvektor[i] % 3 == 0)
                {
                    darab += 1;
                }
                if (szamvektor[i] < min)
                {
                    min = szamvektor[i];
                }
                if (szamvektor[i] > max)
                {
                    max = szamvektor[i];
                }
            }

            Console.WriteLine("Ennyi szám osztható hárommal: " + darab);
            Console.WriteLine("A legkisebb szám: " + min);
            Console.WriteLine("A legnagyobb szám: " + max);
            Console.WriteLine("A számok átlaga: " + osszeg/szamvektor.Length);
            Console.ReadKey();
        }
    }
}
