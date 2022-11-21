using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");
            láncoltlista.RemoveFirst();
            foreach (string i in láncoltlista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
