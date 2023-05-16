using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iskolafeladat
{
    class Program
    {
        static List<IskolaClass> iLista = new List<IskolaClass>();

        static void Main(string[] args)
        {
            // beolvasás
            StreamReader sr = new StreamReader("nevek.txt");
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                IskolaClass m = new IskolaClass(sor);
                iLista.Add(m);

            }
            Console.WriteLine("3. feladat: ");
            Console.WriteLine("A tanulók száma: " + iLista.Count);

            Console.WriteLine("4. feladat: ");

            int maxNevhossz = int.MinValue;
            int szokozSzam = 0;
            for (int i = 0; i < iLista.Count; i++)
            {
                szokozSzam = iLista[i].nev.Split(' ').Length - 1;
                if (iLista[i].nev.Length - szokozSzam> maxNevhossz) 
                {
                    maxNevhossz = iLista[i].nev.Length - szokozSzam;
                }

            }
            Console.WriteLine("Maximális karakterek száma: " + maxNevhossz);
            for (int i = 0; i < iLista.Count; i++)
            {
                if (iLista[i].nev.Length - szokozSzam == maxNevhossz)
                {
                    Console.WriteLine(iLista[i].nev);
                }

            }
            Console.WriteLine("5. feladat: ");
            Console.WriteLine("Első: " + iLista[0].nev + ": " + iLista[0].azonosito());
            Console.WriteLine("Utolsó: " + iLista[iLista.Count - 1].nev + ": " + iLista[iLista.Count - 1].azonosito());

            Console.WriteLine("6. feladat: ");
            Console.WriteLine("Kérek egy azonosítót! ");
            string az = Console.ReadLine();
            int j = 0;
            bool megvan = false;
            while (megvan == false && j < iLista.Count)
            {
                if (iLista[j].azonosito() == az)
                {
                    megvan = true;
                    Console.WriteLine(iLista[j].ev + " "  + iLista[j].osztaly + " " 
                        +  iLista[j].nev);
                }
                j++;
            }
            if (megvan == false)
            {
                Console.WriteLine("Nincs ilyen tanuló!");
            }

            Console.WriteLine("7. feladat: ");
            Random r = new Random();
            int tanuloSorszam = r.Next(0, iLista.Count);
            JelszóGeneráló jelszoGen = new JelszóGeneráló(r);
            Console.WriteLine(iLista[tanuloSorszam].nev);
            Console.WriteLine(jelszoGen.Jelszó(8));

            Console.ReadKey();

        }
    }
}
