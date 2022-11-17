using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(8);
            lista.Add(4);
            lista.Add(30);
            lista.Add(50);
            Console.WriteLine("Kapacitása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            Console.ReadKey();
        }
    }
}
