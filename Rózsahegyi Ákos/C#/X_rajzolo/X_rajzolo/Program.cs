﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_rajzolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy páros számot:");
            int szam = int.Parse(Console.ReadLine());

            int szamfele = szam / 2;
            int j = 1;
            
            for (int i = 1; i <= szamfele; i++)
            {
                while (j <= i)
                {
                    Console.Write("x");
                    j++;
                }

            for (int e = szamfele; e > 1; e--)
            {
                while (j <= szamfele)
                {
                    Console.Write("x");
                    j--;
                }
                Console.WriteLine();
            } Console.ReadKey();
        }
    }
}
