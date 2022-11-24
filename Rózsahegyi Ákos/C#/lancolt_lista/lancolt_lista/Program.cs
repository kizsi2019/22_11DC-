using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancolt_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lancoltlista = new LinkedList<string>();
            lancoltlista.AddLast("vár");
            lancoltlista.AddLast("kávé");
            lancoltlista.AddFirst("autó");

            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
