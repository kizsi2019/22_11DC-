using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[] { 5, 31, 78, 124, 4048 };
            Oszegzo(szamok);
            Console.ReadKey();

        }
        static int Oszegzo(int[]tomb)
        {
            int Ossz = 0;
            foreach(int item in tomb)
            {
                Ossz + item;
                {
                    Console.WriteLine(Ossz);
                    return Ossz;
                }
            }
        }
    }
   }
