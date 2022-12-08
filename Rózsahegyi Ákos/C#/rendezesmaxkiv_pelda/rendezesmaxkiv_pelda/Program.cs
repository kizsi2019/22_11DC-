using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendezesmaxkiv_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randt = new int[200];
            Random r = new Random();
            for (int i = 0; i < randt.Length; i++)
            {
                randt[i] = r.Next(0, 1001);
            }

            Console.WriteLine("Rendezés előtt: ");
            foreach (int item in randt)
            {
                Console.Write(item + ", ");
            }

            for (int i = randt.Length - 1; i > 0; i--)
            {
                int m = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (randt[j] > randt[m])
                        m = j;
                }
                int csere = randt[i];
                randt[i] = randt[m];
                randt[m] = csere;
            }

            Console.WriteLine("\nRendezés után: ");
            foreach (int item in randt)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
