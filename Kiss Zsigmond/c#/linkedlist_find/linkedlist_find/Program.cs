﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_find
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");
            LinkedListNode<string> kerescsomópont = láncoltlista.Find("vár");
            Console.WriteLine(kerescsomópont.Value);

            foreach (string item in láncoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
