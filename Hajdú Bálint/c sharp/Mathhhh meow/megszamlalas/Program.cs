using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megszamlalas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int db = 0;
            for (int i =0; i <tömb.Length; i++)
            {
                if (tömb[i] <= 10) db++;

            }
            Console.WriteLine("Feltétel megfelelő elemek számok:{0}db",db);
            Console.ReadKey();
        }
    }
}
