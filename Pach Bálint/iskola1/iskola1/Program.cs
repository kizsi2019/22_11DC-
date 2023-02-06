using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iskola
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<IskolaClass> tanulok = new List<IskolaClass>();

            StreamReader sr = new StreamReader("nevek.txt");
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                IskolaClass m = new IskolaClass(sor);
                tanulok.Add(m);
            }
            Console.WriteLine("3. feladat");
            Console.WriteLine("A tanulók száma:" + tanulok.Count);
            Console.WriteLine("4. feladat");

            int maxNevhossz = int.MinValue;
            int szokozSzam = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                szokozSzam = tanulok[i].Nev.Split(' ').Length - 1;
                if (tanulok[i].Nev.Length - szokozSzam > maxNevhossz)
                {
                    maxNevhossz = tanulok[i].Nev.Length - szokozSzam;
                }
                if (tanulok[i].Nev.Length - szokozSzam == maxNevhossz)
                {
                    Console.WriteLine(tanulok[i].Nev);
                }
            }
            Console.WriteLine("Maximális karakterek száma:" + maxNevhossz);
            for (int i = 0; i < tanulok.Count; i++)
            {
                Console.WriteLine(tanulok[i].Nev);
            }
            Console.ReadKey();
        }
    }
}