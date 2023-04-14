using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iskola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo1> tanulok = new List<Tanulo1>();
            StreamReader sr = new StreamReader("nevek.txt");
            while(!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo1(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"3.feladat: Az iskolában {tanulok.Count} tanuló jár");
            int maxErtek = tanulok[0].NevHossza;
            for (int i = 1; i < tanulok.Count; i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }
            Console.WriteLine("4.feladat: A leghosszab {0} nevű tanuló(k):", maxErtek);
            foreach (Tanulo1 item in tanulok)
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
