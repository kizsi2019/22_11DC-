using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("3. feladat: Beolvasva {0} feladvány", feladvanyok.Count);
            int meret;

            do
            {
                Console.WriteLine("4. feladat: Kérem a feladvány méretét! [4...9]");
                meret = Convert.ToInt32(Console.ReadLine());

            }
            while (meret < 4 || meret > 9);
            int db = 0;
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} x {0} meretu tablabol {1} darab van", meret, db);
            Console.WriteLine("5. feladat");
            Random r = new Random();
            int kiv = 0;
            do
            {
                kiv = r.Next(0, feladvanyok.Count);
            }
            while (feladvanyok[kiv].Meret == meret);
            Console.WriteLine("A kisorsolt feladvány kezdő állapota: " + feladvanyok[kiv].Kezdo);

            Console.WriteLine("6. feladat");
            int nemNulla = 0
            int hossz = feladvanyok[kiv].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (feladvanyok[kiv].Kezdo[i] != '0')
                {
                    nemNulla++;
                }
            }
            double kitoltottseg = (double)nemNulla / hossz * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: " + kitoltottseg + "%");
            Console.WriteLine("7. feladat");
            feladvanyok[kiv].Kirajzol();
            Console.WriteLine("8. feladat");
            StreamWriter sw = new StreamWriter("sudoku" + meret + ".txt");
            for(int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    sw.WriteLine(feladvanyok[i].Kezdo);
                }
            }
            sr.Close();
            Console.WriteLine("A kiválasztott méretű feladvány kiírja a fájlba");
            Console.ReadKey();
        }
    }
}
