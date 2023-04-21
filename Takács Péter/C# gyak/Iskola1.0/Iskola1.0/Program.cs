﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while(!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: Az iskolában {0} tanuló jár", tanulok.Count);
            int maxErtek = tanulok[0].NevHossza;
            for (int i = 0; i<tanulok.Count;i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }
            Console.WriteLine("4. feladat: A leghosszabb ({0}karakter nevü tanuló(k):", maxErtek);
            foreach (Tanulo item in tanulok)
            {
                if (item.NevHossza == maxErtek)
                {
                    Console.WriteLine("\t{0}", item.Nev);
                }
            }

            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső { 0} - { 1}", tanulok[0].Nev, tanulok[0].Azonosito);
            Console.WriteLine("\tUtolso { 0} - { 1}", tanulok[tanulok.Count-1].Nev, tanulok[tanulok.Count - 1].Azonosito);
            Console.WriteLine("Kérek egy azonosítót! [pl.:4dvavkri]: ");
            int j = 0;
            string azon = Console.ReadLine();
            while(j< tanulok.Count && tanulok[j].Azonosito != azon)
            {
                j++;
            }
            if (j < tanulok.Count)
            {
                Console.WriteLine("\t {0} {1} {2}",)
            }


            Console.ReadKey();
        }
    }
}
