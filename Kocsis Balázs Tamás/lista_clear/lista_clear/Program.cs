using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 10, 23, 4 };
            lista.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete {1}", lista.Capacity, lista.Count);
            Console.ReadKey();
        }
    }
}
