using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }
    }
}
