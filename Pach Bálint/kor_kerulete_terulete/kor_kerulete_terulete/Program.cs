﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor_kerulete_terulete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            double r, k, t;
            Console.WriteLine("Add meg a kör sugarát centiben: ");
            r = Convert.ToDouble(Console.ReadLine());
            k = 2 * r * Math.PI;
            Console.WriteLine("A kör kerülete: {0}", k);
            t = r * r * Math.PI;
            Console.WriteLine("A kör területe: {0}", t);
            Console.ReadLine(); 

        }
    }
}
