using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kereses
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 }; 
            //Keresés tétele
            int i = 0; 
            while (i < Tömb.Length && Tömb[i] != 45) 
            { 
                i++; 
            } 
            if(i < Tömb.Length) Console.WriteLine("A 'Feltétel' feltételnek megfelelő elem sorszáma {0}", i); 
            else Console.WriteLine("Nincs");
            Console.ReadKey();
        }
    }
}
