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
            static void RandTomb(int[] tomb, int mettol, int meddig)
            {
                int[] veletlen_szamok = new int[10];
                RandTomb(veletlen_szamok, 10, 100);
                foreach (int item in veletlen_szamok)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            
                Random r = new Random();
                for (int i = 0; i < tomb.Length; i++)
                {
                    tomb[i] = r.Next(mettol, meddig);
                }
            }
        }
    }
}
