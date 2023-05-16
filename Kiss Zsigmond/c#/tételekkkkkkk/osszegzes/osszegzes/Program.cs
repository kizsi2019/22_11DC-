using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 }; 
            //összegzés tétele:
            int összeg = 0; 
            for (int i = 0; i < Tömb.Length; i++) 
            { 
                összeg += Tömb[i]; 
            } 
            Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);
            Console.ReadKey();
        }
    }
}
