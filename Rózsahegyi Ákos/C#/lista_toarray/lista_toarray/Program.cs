using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_toarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 20, 30, 10 };
            int[] tomb = lista.ToArray();

            foreach (int item in tomb)
            {
                Console.Write(item, ", ");
            }
            Console.ReadKey();
        }
    }
}
