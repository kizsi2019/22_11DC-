using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
namespace iiiskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Class1> tanulok = new List<Class1>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Class1(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"3. feladat:{tanulok.Count} tanuló van.");
            int maxErtek = tanulok[0].NevHossza;
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }
            Console.WriteLine($"4. feladat: Leghosszabb nevű tanuló: {0}"+ maxErtek);
            if (item.NevHossza == maxErtek)
            {
                Console.WriteLine("\t{0}", item.New);
            }
            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső {0} - {1}", tanulok[0].Nev, tanulok[0].Azonosito);
            Console.WriteLine("\tUtolsó szóköz {0} - {1}", tanulok[tanulok.Count-1].Azonosito);
            Console.WriteLine("Kérek egy azonosítót! [pl.: 4dvavkri]");
            int j = 0;
            string azon = Console.ReadLine();
            while (j < tanulok.Count && tanulok[j].Azonosito != azon)
            {
                j++;
            }
            if (j < tanulok.Count)
            {
                Console.WriteLine("\t {0} {1} {2}", tanulok[j].Ev, tanulok[j].Osztaly, tanulok[j].Nev);
            }
            else
            {
                Console.WriteLine("\tNincs ilyen tanuló");
            }
            Random rand = new Random();
            JelszóGeneráló jelszoGeneralo = new JelszóGeneráló(rand);
            Console.ReadKey();
        }
    }
}