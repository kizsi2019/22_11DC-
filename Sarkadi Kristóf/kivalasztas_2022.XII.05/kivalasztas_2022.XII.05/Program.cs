﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalasztas_2022.XII._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < Tömb.Length && Tömb[i] != 0)
            {
                i++;
            }
            Console.WriteLine("A 'Feltétel' feltételének megfelelő elem sorszáma {0}", i);
            Console.ReadKey();
        }
    }
}
