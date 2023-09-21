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
            List<int> lista2 = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 10 };
            lista2.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete:{1}", lista2.Capacity, lista2.Count);
            Console.ReadKey();
        }
    }
}
