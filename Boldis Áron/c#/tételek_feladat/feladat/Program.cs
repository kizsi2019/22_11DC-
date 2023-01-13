using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[20];
            int[] paratlan = new int[tomb.Length];
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                tomb[i] = r.Next(0, 100);
            }
            foreach (int i in tomb)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            int j = 0;
            while (j < tomb.Length && tomb[j] >= 20)
            {
                j++;
            }
            if (j < tomb.Length) Console.WriteLine("Van 20-nál kisebb szám.");
            else Console.WriteLine("Nincs 20-nál kisebb szám.");
            int paros = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0) paros++;
            }
            Console.WriteLine("Páros számok a tömben: " + paros);
            int max = 0;
            int min = 0;
            for(int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[max]) max = i;
                if (tomb[i] < tomb[min]) min = i;
            }
            Console.WriteLine("A legnagyobb szám: " + tomb[max]);
            Console.WriteLine("A legkisebb szám: " + tomb[min]);
            j = 0;
            while (j < tomb.Length && tomb[j] % 3 != 0)
            {
                j++;
            }
            if (j < tomb.Length)
            {
                 Console.WriteLine("A " + j + ". indexű szám osztható 3-al.");
            }
            else
            {
                Console.WriteLine("Nincs 3-al osztható szám.");
              
            }
            int i1 = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 != 0)
                {
                    paratlan[i1] = tomb[i];
                    i1++;
                }
            }
            Console.WriteLine("Páratlan számok: ");
            foreach(int i in paratlan)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            j = 0;
            for (int i = tomb.Length - 1; i > 1; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int csere = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = csere;
                    }
                }
            }
            Console.WriteLine("Növekvő sorrendben: ");
            foreach (int i in tomb)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }   
    }       
}
