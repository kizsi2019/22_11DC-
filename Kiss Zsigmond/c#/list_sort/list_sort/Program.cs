﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" }; 
            lista.Sort(); 
            foreach (string item in lista) 
            { 
                Console.WriteLine(item); 
            }
            Console.ReadKey();
        }
    }
}
