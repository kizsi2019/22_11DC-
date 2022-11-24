using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link_list.add__2022.XI._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("auto");
            LinkedListNode<string> csomópont = láncoltlista.First;
            láncoltlista.AddAfter(csomópont, "2.hely");
            foreach (string item in láncoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
