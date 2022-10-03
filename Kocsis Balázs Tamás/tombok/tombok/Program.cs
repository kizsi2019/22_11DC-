using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomolt_szamok = new int[10];
            Random r = new Random();
            for (int i = 1; i < randomolt_szamok.Length; i++)
            {
                randomolt_szamok[i] = r.Next(1, 100);
            }
            foreach (int item in randomolt_szamok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
