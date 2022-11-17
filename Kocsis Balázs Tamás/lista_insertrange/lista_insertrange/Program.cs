using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_insertrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>() { 10, 24, 32};
            lista.InsertRange(2, tömb);
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
