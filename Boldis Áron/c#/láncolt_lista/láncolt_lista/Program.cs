using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace láncolt_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lancoltlista = new LinkedList<string>();
            lancoltlista.AddLast("vár");
            lancoltlista.AddLast("kávé");
            lancoltlista.AddFirst("Autó");
            foreach (string i in lancoltlista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
