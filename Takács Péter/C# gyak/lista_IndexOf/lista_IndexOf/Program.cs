﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = lista.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, index:" + index);
            else
            {
                Console.WriteLine("Nincs körte");
            }
            Console.ReadKey();
        }
    }
}
