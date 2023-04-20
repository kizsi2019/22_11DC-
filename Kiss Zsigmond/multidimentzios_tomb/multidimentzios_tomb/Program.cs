﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimentzios_tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mutatovektor = new int[][]
            {
                new int[] {6,2,2,7,3},
                new int[] {3,1},
                new int[] {12, 31, 56}
            };
            Console.WriteLine("For-ciklussal: ");
            for (int i = 0; i < mutatovektor.Length; i++)
            {
                for (int j = 0; j < mutatovektor[i].Length; j++)
                {
                    Console.Write(mutatovektor[i][j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Foreach ciklussal: ");
            foreach (int[] belsővektor in mutatovektor)
            {
                foreach (int elem in belsővektor)
                {
                    Console.Write(elem + ",");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}