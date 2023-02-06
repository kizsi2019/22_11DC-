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

            Console.WriteLine("3. feladat: Az iskolába {0} tanuló jár", tanulok.Count);

            int maxnevhossz = int.MinValue;
            int szokozSzam = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                szokozSzam = tanulok[i].nev.Split(' ').Length - 1;
                if (tanulok[i].nev.Length - szokozSzam > maxnevhossz)
                {
                    maxnevhossz = tanulok[i].nev.Split(' ').Length - 1;
                }
            }
            Console.WriteLine("Maximális karakter száma: " + maxnevhossz);
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (tanulok[i].nev.Length - szokozSzam == maxnevhossz)
                {
                    Console.WriteLine(tanulok[i].nev);
                }
            }
            Console.WriteLine("5.feladat: ");
            Console.WriteLine("Első: " + tanulok[0].nev + "; " + tanulok[0].azonosito());
            Console.WriteLine("Utolsó: " + tanulok[tanulok.Count - 1].nev + "; " +tanulok.Count);
            Console.WriteLine("Kérek egy azonosított");
            Console.ReadKey();
        }
           
            
        }
    }

