using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace sudokuCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader sr = new StreamReader("feladvanyok.txt");
            while (!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3.feladat: Beolvasva {0} feladvány", feladvanyok.Count);
            int szam;

            do
            {
                Console.Write("4.feladat: Kérek egy számot 4 és 9 közt ");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            while (szam < 4 || szam > 9);

            int meretdb = 0;
            for(int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == szam)
                {
                    meretdb++;
                }
            }
            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", szam, meretdb);

            Console.WriteLine("5.feladat");
            Random r = new Random();
            int index = 0;

            do
            {
                index = r.Next(0, feladvanyok.Count);
            }
            while (feladvanyok[index].Meret != szam);
            Console.WriteLine("A kisorsolt feladvány kezdő állapota: " + feladvanyok[index].Kezdo);

            Console.WriteLine("6.feladat");
            int newNulladb = 0;
            int hossz = feladvanyok[index].Kezdo.Length;
            for(int i = 0; i < hossz; i++)
            {
                if (feladvanyok[index].Kezdo[i] != '0')
                {
                    newNulladb++;
                }
            }
            double kitoltottseg = (double)newNulladb / hossz * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: " + kitoltottseg + "%");

            Console.WriteLine("7.feladat");
            Console.WriteLine("A kiválasztott feladvány kirajzolva: ");
            feladvanyok[index].Kirajzol();

            Console.WriteLine("8.feladat");
            string filename = "sudoku" + szam + ".txt";
            StreamWriter sw = new StreamWriter(filename);
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == szam)
                {
                    sw.WriteLine(feladvanyok[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("A kiválasztott méretűek kiírva a fájlba");
            Console.WriteLine("A " + filename + " állomány létrehozva ennyi sorral: " + meretdb);

            Console.ReadKey();
        }
    }
}
