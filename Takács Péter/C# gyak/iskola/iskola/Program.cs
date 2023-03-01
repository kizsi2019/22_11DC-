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
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3. feladat : sz iskolába {0} tanuló jár", tanulok.Count);
            Console.ReadKey();

            Console.WriteLine("4. feladat: ");
            int maxNevhossz = int.MinValue;
            int sokozSzam = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                sokozSzam = tanulok[i].Nev.Split(' ').Length - 1;
                if (tanulok[i].Nev.Length-sokozSzam > maxNevhossz)
                {
                    maxNevhossz = tanulok[i].Nev.Length - sokozSzam;
                }
            }
            Console.WriteLine("Maximális karakterek szama: " + maxNevhossz);
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (tanulok[i].Nev.Length - sokozSzam == maxNevhossz)
                {
                    Console.WriteLine(tanulok[i].Nev);
                }
            }

            Console.WriteLine("5.feladat: ");
            Console.WriteLine("Elsö: " + tanulok[0].Nev + ": " + tanulok[0].azonosito());
            Console.WriteLine("Utolsó: " + tanulok[tanulok.Count - 1].Nev + ": " + tanulok[tanulok.Count - 1].azonosito());

            Console.WriteLine("6.feladat: ");
            Console.WriteLine("Kérek egy azonosítót! ");
            string az = Console.ReadLine();
            int j = 0;
            bool megvan = false;
            while (megvan == false && j < tanulok.Count)
            {
                if (tanulok[j].azonosito()==az )
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
