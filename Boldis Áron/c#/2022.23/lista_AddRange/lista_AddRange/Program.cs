using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_AddRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>();
            lista.AddRange(tömb);
            foreach (int i in lista)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();

        }
    }
}
