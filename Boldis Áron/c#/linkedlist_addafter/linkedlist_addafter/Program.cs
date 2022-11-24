using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_addafter
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
            lancoltlista.AddAfter(csomopont, "2. hely");
            Console.WriteLine(csomopont.Value);
            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
