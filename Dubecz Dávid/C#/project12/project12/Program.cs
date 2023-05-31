using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adjá vektort");
            int[] vektor = new int[20];
            for (int i = 0; i < 20; i++)
            {
                vektor[i] = int.Parse(Console.ReadLine());
            }
            int db = 0;
            int osszeg = 0;
            int min = vektor[0];
            int max = vektor[0];
            for (int i = 1; i< vektor.Length; i++)
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
            Console.WriteLine("Szamok oszthatoak 3-al: " + db);
            Console.WriteLine("Min szam: " + min);
            Console.WriteLine("Max szam: " + max);
            Console.WriteLine("Szamok atlaga: " + osszeg / vektor.Length);
            Console.ReadKey();
        }
    }
}
