using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalogatas_pelda
{
    class Program
    {
        static int[] PáratlanSzámok(int[] számokT, out int páratlanindex) { 
            int[] páratlanok = new int[számokT.Length]; 
            páratlanindex = 0; 
            for (int i = 0; i < számokT.Length; i++) 
            { 
                if (számokT[i] % 2 != 0) 
                { 
                    páratlanok[páratlanindex] = számokT[i]; 
                    páratlanindex++; 
                } 
            } 
            return páratlanok; 
        }
        static void Main(string[] args)
        {
        }
    }
}
