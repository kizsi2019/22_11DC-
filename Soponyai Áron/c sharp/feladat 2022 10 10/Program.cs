using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat_2022_10_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vektor = new int[20];
            Console.WriteLine("adj meg 20 számot -100 és 100 között");
            for (int i = 0; i < 20; i++) {
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
            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
            Console.WriteLine("össz: " + osszeg/vektor.Length);
            Console.WriteLine("db: " + db );
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
