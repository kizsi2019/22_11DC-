using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalogatas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiválogatás tétele
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 }; 
            int[] FTömb = new int[Tömb.Length]; 
            int j = 0; 
            for (int i = 0; i < Tömb.Length; i++) 
            { 
                if(Tömb[i] > 10 ) 
                { 
                    FTömb[j] = Tömb[i]; j++; 
                } 
            }
            foreach (var item in FTömb)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
