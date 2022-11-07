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
            int[] vektor = new int[20];
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Kérlek adj meg egy számot -100 és +100 között!!!44!");
                vektor[i] = int.Parse(Console.ReadLine());
            }
            int db = 0;
            int osszeg = 0;
            int min = vektor[0];
            int max = vektor[0];
            for (int i = 1; i < vektor.Length; i++);
            { 
                osszeg = osszeg + vektor[i]
            }
        }
    }
}
