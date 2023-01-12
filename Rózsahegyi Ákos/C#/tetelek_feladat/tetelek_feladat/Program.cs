using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetelek_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] Tomb = new int[20];
            int[] paratlan = new int[Tomb.Length];
            int k = 0;
            int db = 0;
            int legkisebb_index = 0;
            int legnagyobb_index = 0;
            int s = 0;
            int x = 0;

            for (int i = 0; i < Tomb.Length; i++)
            {
                Tomb[i] = r.Next(0, 101);
            }

            foreach (int item in Tomb)
            {
                Console.Write(item + ", ");
            }

            while (k < Tomb.Length && Tomb[k] < 20)
            {
                k++;
            }
            if (k < Tomb.Length) Console.WriteLine("Van 20-nál kisebb szám");
            else Console.WriteLine("Nincs 20-nál kisebb szám");

            for (int l = 0; l < Tomb.Length; l++)
            {
                if (Tomb[l] % 3 == 0) db++;
            }
            Console.WriteLine("{0} darab páros szám van benne", db);

            for (int o = 0; o < Tomb.Length; o++)
            {
                if (Tomb[o] > Tomb[legnagyobb_index]) legnagyobb_index = o;
                if (Tomb[o] < Tomb[legkisebb_index]) legkisebb_index = o;
            }
            Console.WriteLine("A legnagyobb szám: {0}", Tomb[legnagyobb_index]);
            Console.WriteLine("A legkisebb szám: {0}", Tomb[legkisebb_index]);

            while (s < Tomb.Length && Tomb[s] % 3 == 0)
            {
                s++;
            }
            if (s < Tomb.Length) Console.WriteLine("Van 3-mal osztható szám, sorszáma: {0}", s);
            else Console.WriteLine("Nincs 3-mal osztható szám");

            for (int y = 0; y < Tomb.Length; y++)
            {
                if (Tomb[y] % 3 == 0)
                {
                    paratlan[x] = Tomb[y];
                    x++;
                }
            }

            foreach (int item in paratlan)
            {
                Console.Write(item + ", ");
            }

            for (int g = Tomb.Length - 1; g > 1; g--)
            {
                for (int e = 0; e < g; e++)
                {
                    if (Tomb[e] > Tomb[e + 1])
                    {
                        int csere = Tomb[e];
                        Tomb[e] = Tomb[e + 1];
                        Tomb[e + 1] = csere;
                    }
                }
            }

            Console.WriteLine("\nBuborékos rendezés után:");
            foreach (int item in Tomb)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
