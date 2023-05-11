using karacsonyCLI;
using System;
using System.Collections.Generic;
using System.IO;

namespace KaracsonyCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> munkak = new List<NapiMunka>();
            StreamReader sr = new StreamReader("diszek.txt");
            while (!sr.EndOfStream)
            {
                munkak.Add(new NapiMunka(sr.ReadLine()));
            }
            sr.Close();

            int ossz = 0;
            foreach (var m in munkak)
            {
                ossz += m.FenyofaKesz + m.HarangKesz + m.AngyalkaKesz;
            }
            Console.WriteLine("4. feladat: Összesen {0} darab dísz készült", ossz);

            int i = 0;
            while (i < munkak.Count && munkak[i].FenyofaKesz + munkak[i].HarangKesz + munkak[i].AngyalkaKesz > 0)
                i++;
            if (i < munkak.Count)
            {
                Console.WriteLine("5. feladat: Volt olyan nap, amikor egyetlen dísz sem készült");
            }
            else
            {
                Console.WriteLine("5. feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült");
            } 
        }
    }
}