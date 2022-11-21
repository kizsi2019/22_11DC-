using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_after_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");
            LinkedListNode<string> csomópont = láncoltlista.First;
            láncoltlista.AddAfter(csomópont, "2.hely");
            Console.WriteLine(csomópont.Value);
            foreach (string i in láncoltlista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
