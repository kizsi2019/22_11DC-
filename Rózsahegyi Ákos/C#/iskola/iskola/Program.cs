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
            int szokozszam = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                szokozszam = tanulok[i].nev.Split(' ').Length - 1;
                if (tanulok[i].nev.Length - szokozszam > maxnevhossz)
                {
                    maxnevhossz = tanulok[i].nev.Length - szokozszam;
                }
            }
            Console.WriteLine("Maximális karakterek száma: " + maxnevhossz);
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (tanulok[i].nev.Length - szokozszam == maxnevhossz)
                {
                    Console.WriteLine(tanulok[i].nev);
                }
            }

            Console.WriteLine("5. feladat: ");
            Console.WriteLine("Első: " + tanulok[0].nev + ": " + tanulok[0].azonosito());
            Console.WriteLine("Utolsó: " + tanulok[tanulok.Count - 1].nev + ": " + tanulok[tanulok.Count - 1].azonosito());

            Console.WriteLine("6. feladat: ");
            Console.WriteLine("Kérek egy azonosítót: ");
            string az = Console.ReadLine();
            int j = 0;
            bool megvan = false;
            while (megvan == false && j < tanulok.Count)
            {
                if (tanulok[j].azonosito() == az)
                {
                    Console.WriteLine(tanulok[j].ev + " " + tanulok[j].osztaly + " " + tanulok[j].nev);
                }
                j++;
            }
            if (megvan == false)
            {
                Console.WriteLine("Nincs ilyen tanuló!");
            }

            Console.WriteLine("7. feladat: ");
            Random r = new Random();
            int tanulosorszam = r.Next(0, tanulok.Count);
            JelszoGeneralo jelszogen = new JelszoGeneralo(r);
            Console.WriteLine(tanulok[tanulosorszam].nev);
            Console.WriteLine(jelszogen.Jelszo(8));
            Console.ReadKey();
        }
    }
}
