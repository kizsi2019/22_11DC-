﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool paros;
            paros(11, out paros);
            Console.WriteLine(paros);
            Console.ReadKey();
        }
        static void Paros(int a, out bool log)
        {
            if (a % 2 == 0) log = true;
            else log = false;
        }
    }
}
