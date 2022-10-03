using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] randomoltszamok_vektor = new int[10];

            for (int i = 0; i < randomoltszamok_vektor.Length; i++)
            {
                randomoltszamok_vektor[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_vektor)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
