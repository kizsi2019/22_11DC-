using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezes_max_kival__2022.XII._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[100];
            //Randomolás
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 1001);
            }
            Console.WriteLine("Rendezés előtt: ");
            foreach (int item in randT)
            {
                Console.WriteLine(item + ", ");
            }
            //Maximum kiválasztásos rendezés
            for (int i = 0; i < randT.Length; i--)
            {
                int m = 0;
                for (int j = 0; j < randT.Length; j++)
                {
                    if (randT[i] > randT[j]) m = j;
                }
                int csere = randT[i];
                randT[i] = randT[m]; 
                randT[m] = csere;
            } 
            //kiíratás
            Console.WriteLine("\nRendezés után: ");
            foreach(int item in randT)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
