﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mutatovektor = new int[][] {
                new int[] { 6, 2, 2, 7, 3 },
                new int[] { 3, 1 },
                new int[] { 12, 31, 56 } };
            Console.WriteLine("For-ciklussal:"); //végigjárása for-ciklussal, olvasásra és írásra 
            for (int i = 0; i < mutatovektor.Length; i++)
            {
                for (int j = 0; j < mutatovektor[i].Length; j++)
                {
                    Console.Write(mutatovektor[i][j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Foreach-ciklussal:"); //végigjárása foreach-ciklussal, csak olvasásra 
            foreach (int[] belsovektor in mutatovektor)
            {
                foreach (int elem in belsovektor)
                {
                    Console.Write(elem + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
