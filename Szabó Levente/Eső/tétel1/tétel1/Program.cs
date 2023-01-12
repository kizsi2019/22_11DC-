using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tétel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]tomb = new int[20];
            int[]három = new int[tomb.Length];
            int q = 0;
            int db = 0;
            int n = 0;
            int j = 0;
            int legkisebb_index = 0;
            int legnagyobb_index = 0;
            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = tomb.Next(0, 101);
            }
            
            foreach (int item in tomb)
            {
                Console.Write(item + ", ");
            }
            
            while (q < tomb.Length && tomb[q] < 20)
            {
                q++;
            }
            
            if (q < tomb.Length)
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
            
            Console.WriteLine("{0} db páros szám van itt most", db);
            
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
            
            while (n < tomb.Length && tomb[n] % 3 == 0)
            {
                n++;
            }

            if (n < tomb.Length)
            {
                Console.WriteLine("Van 3-mal osztható szám most, a db: {0}");
            }
            
            else
            {
                Console.WriteLine("Nincs 3-mal osztható szám most");
            }
            
            for (int y = 0; y < tomb.Length; y++)
            {
                
                if (tomb[y] % 3 == 0)
                {
                    három[j] = tomb[y];
                    j++;
                }
            }
            
            foreach (int item in három)
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
            
            Console.WriteLine("\nBuborékos rendezés volt itt most: ");
            
            foreach (int item in tomb)
            {
                
                Console.Write(item + " , ");
            }
            
            Console.ReadKey();
        }    
    }
}
