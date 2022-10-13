using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamvektor = new int[20];
            for (int i = 1; i < 20; i++ )
            {
                Console.WriteLine("Adj meg egy számot -100 és 100 között");
                szamvektor[i] = int.Parse(Console.ReadLine());
            }
            int db = 0;
            int osszeg = 0;
            int min = szamvektor[0];
            int max = szamvektor[0];
            for (int i = 1; i < szamvektor.Length; i++)
            {
                osszeg = osszeg + szamvektor[i];
                if (szamvektor[i] % 3 == 0)
                {
                    db = db + 1;
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
            Console.WriteLine("Ennyi szám osztható hárommal: " + db);
            Console.WriteLine("Ez a legkisebb szám: " + min);
            Console.WriteLine("Ez a legnagyobb szám: " + max);
            Console.WriteLine("Ez a számok átlaga: " + osszeg/szamvektor.Length);
            Console.ReadKey();
        }   
    }
}
