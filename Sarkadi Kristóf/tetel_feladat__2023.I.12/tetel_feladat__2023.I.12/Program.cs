using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetel_feladat__2023.I._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand_tomb = new Random();
            int[] tomb = new int[20];
            int[] paratlan = new int[tomb.Length];
            int k = 0;
            int db = 0;
            int legkisebb_index = 0;
            int legnagyobb_index = 0;
            int s = 0;
            int x = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand_tomb.Next(0, 102);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + ", ");
            }
            while (k < tomb.Length && tomb[k] < 20)
            {
                k++;
            }
            if (k < tomb.Length)
            {
                Console.WriteLine("Van 20-nál kisebb számok.");
            }
            else
            {
                Console.WriteLine("Nincs 20-nál kisebb számok.");
            }
            for (int l = 0; l < tomb.Length; l++)
            {
                if (tomb[l] % 3 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} db páros szám van benne összesen", db);
            for (int o = 0; o < tomb.Length; o++)
            {
                if (tomb[o] < tomb[legkisebb_index])
                {
                    legkisebb_index = o;
                }
                if (tomb[o] > tomb[legnagyobb_index])
                {
                    legnagyobb_index = o;
                }
            }
            Console.WriteLine("A legkisebb szám: {0}", legkisebb_index);
            Console.WriteLine("A legnagyobb szám: {0}", legnagyobb_index);
            while (s < tomb.Length && tomb[s] % 3 == 0)
            {
                s++;
            }
            if (s <tomb.Length)
            {
                Console.WriteLine("Van 3-mal osztható szám, a sorszáma: {0}");
            }
            else
            {
                Console.WriteLine("Nincs 3-mal osztható szám");
            }
            for (int y = 0; y < tomb.Length; y++)
            {
                if (tomb[y] % 3 == 0)
                {
                    paratlan[x] = tomb[y];
                    x++;
                }
            }
            foreach (int item in paratlan)
            {
                Console.Write(item + ", ");
            }
            for (int g = tomb.Length - 1; g >= 0; g--)
            {
                for (int e = 0; e < tomb.Length; e++)
                {
                    if (tomb[e] > tomb[e + 1])
                    {
                        int csere = tomb[e];
                        tomb[e] = tomb[e + 1];
                        tomb[e + 1] = csere;
                    }
                }
            }
            Console.WriteLine("\nBuborékos rendezés után: ");
            foreach (int item in tomb)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
