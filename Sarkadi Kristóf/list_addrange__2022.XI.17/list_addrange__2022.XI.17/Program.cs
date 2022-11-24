using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_addrange__2022.XI._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>();
            lista.AddRange(tömb);
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
