using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3.feladat: ");

            Console.WriteLine($"Az iskolába {tanulok.Count} tanuló jár");

            Console.WriteLine("4. feladat: ");

            int maxNevhossz = int.MinValue; ;
            int szokozszam = 0;
            for (int i= 0; i < tanulok.Count; i++)
            {
                szokozszam = tanulok[i].Nev.Split(' ').Length - 1;
                if (tanulok[i].Nev.Length - szokozszam > maxNevhossz)
                {
                    maxNevhossz = tanulok[i].Nev.Length - szokozszam;
                }
            }
            Console.WriteLine("Maximális karakterek száma: " + maxNevhossz);
            for (int i= 0; i < tanulok.Count; i++)
            {
                if (tanulok[i].Nev.Length - szokozszam == maxNevhossz)
                {
                    Console.WriteLine(tanulok[i].Nev);
                }
            }

            Console.WriteLine("5. feladat: ");
            Console.WriteLine("Első: " + tanulok[0].Nev + ": " + tanulok[0].azonosító());
            Console.WriteLine("Utolsó: " + tanulok[tanulok.Count - 1].Nev + ": " + tanulok[tanulok.Count - 1].azonosító());

            Console.WriteLine("6. feladat: ");
            Console.WriteLine("Kérek egyazonosítót! ");
            string az = Console.ReadLine();
            int j = 0;
            bool megvan = false;
            while (megvan == false && j < tanulok.Count)
            {
                if (tanulok[j].azonosító() == az)
                {
                    megvan = true;
                    Console.WriteLine(tanulok[j].Ev + " " + tanulok[j].Osztaly + " " + tanulok[j].Nev);
                }
                j++;
            }
            if (megvan == false)
            {
                Console.WriteLine("Nincs ilyen tanuló! ");
            }

            Console.WriteLine("7. feladat: ");
            Random r = new Random();
            int tanuloSorszam = r.Next(0, tanulok.Count);
            JelszóGeneráló jelszoGen = new JelszóGeneráló(r);
            Console.WriteLine(tanulok[tanuloSorszam].Nev);
            Console.WriteLine(jelszoGen.Jelszó(8));



            Console.ReadKey();  
        }
    }
}
