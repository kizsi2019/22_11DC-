using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudokuCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader sr = new StreamReader("feladvanyok.txt");
            while(!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3. feladat: Beolvasva {0} feladvány",feladvanyok.Count);
            int meret;
            string adat;
            do
            {
                Console.WriteLine("4. feladat: kérem a feladvány méretét [4..9]: ");
                meret = Convert.ToInt32(Console.ReadLine());
            }
            while (meret < 4 || meret > 9);
            int meretDB = 0;
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    meretDB++;
                }
            }
            Console.WriteLine("{0}x{0} méretü feladványból {1} darab van tárolva ", meret,meretDB);

            Console.WriteLine("5.feladat: ");
            Random r = new Random();
            int kivalasztoIndex = 0;
            do
            {
                kivalasztoIndex = r.Next(0, feladvanyok.Count);
            }
            while (kivalasztoIndex < feladvanyok.Count);


            Console.ReadKey();
        }
    }
}
