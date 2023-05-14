using Iskola;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Iskola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            
            Console.WriteLine($"3. feladat: Az iskolába {tanulok.Count} tanuló jár");

            int maxErtek = tanulok[0].NevHossza;
            for (int i = 1; i < tanulok.Count; i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }
            

            Console.WriteLine("4. feladat: A leghosszab ({0} karakter) nevű tanuló(k):", maxErtek);
            foreach (Tanulo t in tanulok)
            {
                if (t.NevHossza == maxErtek)
                {
                    Console.WriteLine("\t{0}", t.Nev);
                }
            }

           

        }
    }
}