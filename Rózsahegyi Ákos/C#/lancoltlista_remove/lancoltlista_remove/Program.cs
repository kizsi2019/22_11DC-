using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancoltlista_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lancoltlista = new LinkedList<string>();
            lancoltlista.AddLast("vár");
            lancoltlista.AddLast("kávé");
            lancoltlista.AddFirst("autó");
            lancoltlista.RemoveFirst();
            //lancoltlista.RemoveLast();

            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
