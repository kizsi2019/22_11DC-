﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_removeat__2022.XI._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 10, 23, 4, 30 };
            lista.RemoveAt(2);
            foreach (var item in lista)
            {
                Console.Write(item + " ,");
            }
            Console.ReadKey();
        }
    }
}
