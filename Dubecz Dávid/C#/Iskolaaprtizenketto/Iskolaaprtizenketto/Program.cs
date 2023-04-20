using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iskolaaprtizenketto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iskola> tanulok = new List<Iskola>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Iskola(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: Az iskolában {tanulok.Count} tanuló jár");
            int maxErtek = tanulok[0].NevHossza;
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }

            Console.WriteLine("4. feladat: A leghosszabb {0} nevű tanuló(k):", maxErtek);
            foreach (Iskola item in tanulok)
            {
                if (item.NevHossza == maxErtek)
                {
                    Console.WriteLine("\t{0}", item.Nev);
                }
            }

            Console.ReadKey();
        }
    }
}
