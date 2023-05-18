using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kereses_pelda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] beolvasás = new int[20]; 
            for (int i = 0; i < 20; i++)
            { 
                //bekérés a felhasználótól
                Console.Write("Adja meg a {0}. számot: ", i + 1); 
                beolvasás[i] = int.Parse(Console.ReadLine()); 
            } 
            //Keresés tétele
            int j = 0; 
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0) 
            { 
                j++; 
            } 
            if(j < beolvasás.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be!", j + 1); 
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");
            Console.ReadKey();
        }
    }
}
