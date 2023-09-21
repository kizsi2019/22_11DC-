using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace sudokuCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader sr = new StreamReader(@"C:\\Users\\DubeczDavidRaymundo\\Desktop\\githubv1\\22_11DC-\\Dubecz Dávid\\C#\\soduku\\2. Szudoku\\feladvanyok.txt");

            while (!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3. feladat: Beolvasva {0} feladvány", feladvanyok.Count);

            int meret = 0;
            do
            {
                Console.WriteLine("4. feladat: Kérem a feladvány méretét [4..9]:");
                meret = Convert.ToInt32(Console.ReadLine());
            }

            while (meret < 4 || meret > 9);

            int meretdb = 0;
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    meretdb++;
                }
            }
            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", meret, meretdb);

            Random r = new Random();
            int index = 0;
            do
            {
                index = r.Next(0, feladvanyok.Count);
            } while (feladvanyok[index].Meret != meret);
            Console.WriteLine("5. feladat: A kiválasztott feladvány: " + feladvanyok[index].Kezdo);

            Console.WriteLine("6. feladat");
            int nemnulladb = 0;
            int hossz = feladvanyok[index].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (feladvanyok[index].Kezdo[i] != '0')
                {
                    nemnulladb++;
                }
            }
            double kitoltottseg = (double)nemnulladb / hossz * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: " + kitoltottseg + "%");

            Console.WriteLine("7. feladat: ");
            feladvanyok[index].Kirajzol();

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
            Console.WriteLine("A kiválasztott méretű feladvány kiírva a fájlba!");
            Console.ReadKey();
        }
    }
}