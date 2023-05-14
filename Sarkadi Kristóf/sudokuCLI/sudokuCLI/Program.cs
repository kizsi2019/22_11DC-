using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudokuCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader sr = new StreamReader("@C:\\Users\\SarkadiKristofStefan\\Desktop\\sark.kris.stef\\22_11DC-\\Sarkadi Kristóf\\sudokuCLI\\sudokuCLI\\bin\\Debug\\feladvanyok.txt");
            while (!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3.feladat: Beolvasva {0} feladvány", feladvanyok.Count);

            int meret;
            do
            {
                Console.WriteLine("4.feladat: Kérem a feladvány méretét [4..9]");
                meret = Convert.ToInt32(Console.ReadLine());
            }
            while (meret < 4 || meret > 9);
            int meretDb = 0;
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    meretDb++;
                }
            }
            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva ", meret, meretDb);

            Console.WriteLine("5.feladat");
            Random r = new Random();
            int kivalasztottindex = 0;
            do
            {
                kivalasztottindex = r.Next(0, feladvanyok.Count);
            }
            while (feladvanyok[kivalasztottindex].Meret != meret);

            Console.WriteLine("6. feladat: ");
            int nemNullaDb = 0;
            int hossz = feladvanyok[kivalasztottindex].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (feladvanyok[kivalasztottindex].Kezdo[i] != '0')
                {
                    nemNullaDb++;
                }
            }
            double kitoltotseg = (double)nemNullaDb / hossz * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: ");

            Console.WriteLine("7. feladat: ");
            feladvanyok[kivalasztottindex].Kirajzol();

            Console.WriteLine("8. feladat: ");
            StreamWriter sw = new StreamWriter("sudoku" + meret + ".txt");
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    sw.WriteLine(feladvanyok[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("A kiválasztott méretű feladvány kiírva a fájlban!");

            Console.ReadKey();
        }
    }
}
