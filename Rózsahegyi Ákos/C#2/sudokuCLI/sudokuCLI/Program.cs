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
            StreamReader sr = new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\github\22_11DC-\Rózsahegyi Ákos\C#2\sudokuCLI\sudokuCLI\bin\Debug\feladvanyok.txt");

            while (!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3. feladat: Beolvasva {0} feladvány", feladvanyok.Count);

            int meret = 0;

            do
            {
                Console.WriteLine("\n4. feladat: Kérem a feladvány méretét [4..9]: ");
                meret = Convert.ToInt32(Console.ReadLine());
            } while (meret < 4 || meret > 9);

            int meretdb = 0;
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    meretdb++;
                }
            }
            Console.WriteLine("\n{0}x{0} méretű feladványból {1} darab van tárolva", meret, meretdb);

            Random r = new Random();
            int index = 0;
            do
            {
                index = r.Next(0, feladvanyok.Count);
            } while (feladvanyok[index].Meret != meret);
            Console.WriteLine("\n5. feladat: A kiválasztott feladvány: " + feladvanyok[index].Kezdo);

            int nemnulladb = 0;
            int hossz = feladvanyok[index].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (feladvanyok[index].Kezdo[i] != '0')
                {
                    nemnulladb++;
                }
            }
            double kitoltott = (double)nemnulladb / hossz * 100;
            Console.WriteLine("\n6. feladat: A feladvány kitöltöttsége: {0}%", kitoltott);

            Console.WriteLine("\n7. feladat: A feladvány kirajzolva:");
            feladvanyok[index].Kirajzol();

            StreamWriter sw = new StreamWriter("sudoku" + meret + ".txt");
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == meret)
                {
                    sw.WriteLine(feladvanyok[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("\n8. feladat: A kiválasztott méretű feladvány kiírva a fájlba!");
            Console.ReadKey();
        }
    }
}
