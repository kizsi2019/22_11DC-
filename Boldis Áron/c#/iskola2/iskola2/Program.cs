using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iskola2;

namespace bdc_IskolaKonzolos
{
    class JelszóGeneráló
    {
        private Random Rnd;

        public JelszóGeneráló(Random r)
        {
            Rnd = r;
        }

        public string Jelszó(int jelszóHossz)
        {
            string jelszó = "";
            while (jelszó.Length < jelszóHossz)
            {
                char c = (char)Rnd.Next(48, 123);
                if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                {
                    jelszó += c;
                }
            }
            return jelszó;
        }
    }


    class Program
    {
        static List<IskolaClass> iLista = new List<IskolaClass>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("nevek.txt", Encoding.UTF8);
            string sor = "";
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

            Console.WriteLine("5. feladat");
            Console.WriteLine("Első: " + iLista[0].Nev + ": " + iLista[0].azonosito());
            Console.WriteLine("Utolsó: " + iLista[iLista.Count - 1].Nev + ": " + iLista[iLista.Count - 1].azonosito());

            Console.WriteLine("6. feladat");
            Console.WriteLine("Kérek egy azonosítót!");
            string az = Console.ReadLine();
            int j = 0;
            bool megvan = false;
            while (megvan == false && j < iLista.Count)
            {
                if (iLista[j].azonosito() == az)
                {
                    megvan = true;
                    Console.WriteLine(iLista[j].Nev);
                }
                j++;
            }
            if (megvan == false)
            {
                Console.WriteLine("Nincs ilyen tanuló!");
            }

            Console.WriteLine("7. feladat");
            Random r = new Random();
            int tanuloSorszam = r.Next(0, iLista.Count);
            JelszóGeneráló jelszoGen = new JelszóGeneráló(r);
            Console.WriteLine(iLista[tanuloSorszam].Nev);
            Console.WriteLine(jelszoGen.Jelszó(8));

            Console.ReadKey();
        }
    }
}