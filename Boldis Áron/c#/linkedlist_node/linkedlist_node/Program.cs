using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lancoltlista = new LinkedList<string>();
            lancoltlista.AddLast("vár");
            lancoltlista.AddLast("kávé");
            lancoltlista.AddFirst("autó");
            LinkedListNode<string> csomopont = lancoltlista.First;
            Console.WriteLine(csomopont.Value);
            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
           
        }
    }
}
