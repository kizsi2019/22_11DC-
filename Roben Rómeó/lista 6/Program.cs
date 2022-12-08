using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 10 };
            lista.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete:{1}", lista.Capacity, lista.Count);
            Console.ReadKey();
        }
    }
}
