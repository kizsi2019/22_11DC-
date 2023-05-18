using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace sudokuCLI
{
    class Program
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
            int meret = 0;

            do
            {
                Console.WriteLine("4. feladat: Kérem a feladvány méretét! [4..9]");
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

            Console.WriteLine("5. feladat");
            Random r = new Random();
            int kivalasztottIndex = 0;
            do
            {
                kivalasztottIndex = r.Next(0, feladvanyok.Count);
            } while (feladvanyok[kivalasztottIndex].Meret != meret);
            Console.WriteLine("A kisorsolt feladvány kezdő állapota: " + feladvanyok[kivalasztottIndex].Kezdo);

            Console.WriteLine("6. feladat");
            int nemNullaDb = 0;
            int hossz = feladvanyok[kivalasztottIndex].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (feladvanyok[kivalasztottIndex].Kezdo[i] != '0')
                {
                    nemNullaDb++;
                }
            }
            double kitoltottseg = (double)nemNullaDb / hossz * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: " +
                kitoltottseg + "%");

            Console.WriteLine("7. feladat: ");
            feladvanyok[kivalasztottIndex].Kirajzol();

            Console.WriteLine("8. feladat");
            StreamWriter sw = new StreamWriter("sudoku" + meret + ".txt");
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    sw.WriteLine(feladvanyok[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("A kiválasztott méretű kiírva a fájlba!");

           

            Console.ReadKey();
        }
    }
}
