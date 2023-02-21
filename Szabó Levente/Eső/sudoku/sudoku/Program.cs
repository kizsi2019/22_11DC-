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
            StreamReader sr = new StreamReader("C:\\Users\\SzaboLeventeTamas\\Desktop\\Eső 2\\git\\22_11DC-\\Szabó Levente\\Eső\\sudoku\\sudoku\\bin\\Debug\\feladvanyok.txt");
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

            Console.ReadKey();
        }
    }
}