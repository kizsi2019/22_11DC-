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
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                tomb[i] = r.Next(0, 100);
            }
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



            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[legnagyobb_index]) legnagyobb_index = i;
                if (tomb[i] < tomb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine(
             "A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, tomb[legnagyobb_index]);
            Console.WriteLine(
             "A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, tomb[legkisebb_index]);




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



            while (j < tomb.Length && tomb[j] % 2 != 0)
            {
                j++;
            }
            if (j < tomb.Length)
            {
                Console.WriteLine("A " + j + ". indexű szám osztható 3-al.");
            }


            {
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
                foreach (int i in tomb)
                        {
                            Console.WriteLine(i);
                        }

            }






            Console.ReadKey();
        }
    }
}
