﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_node
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
            Console.WriteLine(csomópont.Value);
            foreach (string i in láncoltlista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
