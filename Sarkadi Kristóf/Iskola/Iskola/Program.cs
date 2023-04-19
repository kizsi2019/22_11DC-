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
            Console.WriteLine("5.feladat: Azonosító");
            Console.WriteLine("\tElso {0} - {1}", tanulok[0].Nev, tanulok[0].Azonosito);
            Console.WriteLine("\tUtolso {0} - {1}", tanulok[tanulok.Count -1].Nev, tanulok[tanulok.Count - 1].Azonosito);
            Console.WriteLine("Kérek egy azonosítót! {pl.: 4dvavkri}: ");
            int j = 0;
            string azon = Console.ReadLine();
            while(j<tanulok.Count && tanulok[j].Azonosito != azon)
            {
                j++;
            }
            if(j < tanulok.Count)
            {
                Console.WriteLine("\t {0} {1} {2}", tanulok[j].Ev, tanulok[j].Osztaly, tanulok[j].Nev);
            }
            else
            {
                Console.WriteLine("\tNincs ilyentanuló!");
            }
            Random rand = new Random();
            JelszoGeneralo jelszoGeneralo = new JelszoGeneralo(rand);
            int index = rand.Next(tanulok.Count);
            Console.WriteLine("7.feladat: Jelszó generálása");
            Console.WriteLine("\t {0} - {1}", tanulok[index].Nev, jelszoGeneralo.Jelszó(0));

            Console.ReadKey();
        }
    }
}
