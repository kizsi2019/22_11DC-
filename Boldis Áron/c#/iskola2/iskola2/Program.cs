using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola2
{
    internal class Program
    {
        static List<IskolaClass> iLista = new List<IskolaClass>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("nevek.txt", Encoding.UTF8);
            string sor = ""; //nincs fejléc adatsor
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                IskolaClass m = new IskolaClass(sor);
                iLista.Add(m);
            }

            Console.WriteLine("3. feladat");
            Console.WriteLine("A tanulók száma: " + iLista.Count);
            Console.WriteLine("4. feladat");
            int maxNevHossz = int.MinValue;

            for (int i = 0; i < iLista.Count; i++)
            {
                int szokozSzam = iLista[i].Nev.Split(' ').Length - 1;
                if (iLista[i].Nev.Length - szokozSzam > maxNevHossz)
                {
                    maxNevHossz = iLista[i].Nev.Length - szokozSzam;
                }
            }
            Console.WriteLine("Maximális karakterek száma: " + maxNevHossz);
            for (int i = 0; i < iLista.Count; i++)
            {
                int szokozSzam = iLista[i].Nev.Split(' ').Length - 1;
                if (iLista[i].Nev.Length - szokozSzam == maxNevHossz)
                {
                    Console.WriteLine(iLista[i].Nev);
                }
            }
            Console.ReadKey();
        }
    }
}
