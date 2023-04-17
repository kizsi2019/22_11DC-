using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Iskola2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Iskola> tanulok = new List<Iskola>();
            StreamReader sr = new StreamReader($"C:\\Users\\RozsahegyiAkos\\Desktop\\GITHUB\\22_11DC-\\Rózsahegyi Ákos\\C#\\Iskola2\\nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Iskola(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"3. feladat: Az iskolába {tanulok.Count} tanuló jár");
            
            int maxErtek = tanulok[0].NevHossza;
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }
            Console.WriteLine("4. feladat: A leghosszabb ({0} karakter) nevű tanuló(k):", maxErtek);
            foreach (Iskola item in tanulok)
            {
                if (item.NevHossza == maxErtek)
                {
                    Console.WriteLine("\t{0}", item.Nev);
                }
            }

            Console.WriteLine("5. feladat: Azonosítók");
            Console.WriteLine("\tElső: {0} - {1}", tanulok[0].Nev, tanulok[0].Azonosito);
            Console.WriteLine("\tUtolsó: {0} - {1}", tanulok[tanulok.Count-1].Nev, tanulok[tanulok.Count - 1].Azonosito);

            Console.WriteLine("6. Kérek egy azonosítót [pl.: 4dvavkri]: ");
            int j = 0;
            string azon = Console.ReadLine();
            while (j < tanulok.Count && tanulok[j].Azonosito != azon)
            {
                j++;
            }
            if (j < tanulok.Count)
            {
                Console.WriteLine("\t{0} {1} {2}", tanulok[j].Ev, tanulok[j].Osztaly, tanulok[j].Nev);
            }
            else
            {
                Console.WriteLine("\tNincs ilyen tanuló");
            }

            Random rand = new Random();
            JelszoGeneralo jelszoGeneralo = new JelszoGeneralo(rand);
            int index = rand.Next(tanulok.Count);
            Console.WriteLine("7. feladat: Jelszó generálása");
            Console.WriteLine("\t{0} - {1}", tanulok[index].Nev, jelszoGeneralo.Jelszo(8));
            Console.ReadKey();
        }
    }
}
