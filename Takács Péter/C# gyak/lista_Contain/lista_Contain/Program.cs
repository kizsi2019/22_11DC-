﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_Contain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            if (lista.Contains("körte")) Console.WriteLine("Van körte! ");
            else
            {
                Console.WriteLine("ez nem a körte");
            }
            Console.ReadKey();
        }
    }
}
