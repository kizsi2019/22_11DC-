using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtomb_feltoltes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] veletlen_szamok = new int[5];
            randtomb(veletlen_szamok, 1, 90);
            foreach (int item in veletlen_szamok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void randtomb(int[] tomb, int mettol, int meddig)
        {
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(mettol, meddig);
            }
        }
    }
}
