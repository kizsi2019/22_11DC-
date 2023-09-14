using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader szamok = new StreamReader("feladvanyok.txt");
            while (!szamok.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(szamok.ReadLine()));
            }
            szamok.Close();
            Console.WriteLine("3. feladat: Beolvasva {0} feladvány", feladvanyok.Count);
            int szam;

            do
            {
                Console.Write("4. feladat: Kérek egy számot 4 és 9 között");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            while (szam < 4 || szam > 9);

            int meretdb = 0;
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == szam)
                {
                    meretdb++;
                }
            }
            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva: ", szam, meretdb);

            Console.WriteLine("5. feladat");
            Random r = new Random();
            int index = 0;

            do
            {
                index = r.Next(0, feladvanyok.Count);
            }
            while (feladvanyok[index].Meret != szam);
                Console.WriteLine("A kisorolt feladvány kezdő állapota: " + feladvanyok[index].Kezdo);

            Console.WriteLine("6.feladat");
            int nemNullaDb = 0;
            int hossz = index.Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (index.Kezdo[i] != '0') ;
                {
                    nemNullaDb++;
                }
            }

            Console.ReadKey();
        }
    }
}
