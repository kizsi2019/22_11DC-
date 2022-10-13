using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vektor = new int[10];
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Kérlek adj meg egy számot -100 és +100 között");
                vektor[i] = int.Parse(Console.ReadLine());
            }
            int db = 0;
            int osszeg = 0;
            int min = vektor[0];
            int max = vektor[0];
            for (int i = 1; i < vektor.Length; i++)
            {
                osszeg = osszeg + vektor[i];
                if (vektor[i] % 3 == 0)
                {
                    db = db + 1;
                }
                if (vektor[i] < min)
                {
                    min = vektor[i];
                }
                if (vektor[i] > max)
                {
                    max = vektor[i];
                }



        }
    }       Console.Writeline("Ennyi szám osztható hárommal: {0}, a legkisebb szám: {1}, a legnagyobb szám: {2}," +
            ) 
}    
