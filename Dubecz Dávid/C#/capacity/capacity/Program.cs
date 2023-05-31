using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            Console.WriteLine("Kapacítása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            Console.ReadKey();
        }
    }
}
