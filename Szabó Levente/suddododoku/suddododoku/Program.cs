using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bdc_sudoku
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }
        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }
        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
    class Program
    {
        static List<Feladvany> lista = new List<Feladvany>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("feladvanyok.txt", Encoding.UTF8);
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Feladvany f = new Feladvany(sor);
                lista.Add(f);
            }
            sr.Close();
            Console.WriteLine("3. feladat");
            Console.WriteLine("Feladványok száma: " + lista.Count);
            Console.WriteLine("4. feladat");
            int meret = 0;
            do
            {
                Console.Write("Kérem a sudoku méretét: ");
                meret = Convert.ToInt32(Console.ReadLine());
            } while (meret < 4 || meret > 9);

            int meretDB = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Meret == meret)
                {
                    meretDB++;
                }
            }
            Console.WriteLine("A megadott méretből ennyi van: " + meretDB);
            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", meret, meretDB);
            Console.WriteLine("5. feladat");
            Random r = new Random();
            int kivalasztottIndex = 0;
            do
            {
                kivalasztottIndex = r.Next(0, lista.Count);
            } while (lista[kivalasztottIndex].Meret != meret);
            Console.WriteLine("A kisorsolt feladvány kezdő állapota: " + lista[kivalasztottIndex].Kezdo);
            Console.WriteLine("6. feladat");
            int nemNullaDb = 0;
            int hossz = lista[kivalasztottIndex].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (lista[kivalasztottIndex].Kezdo[i] != '0')
                {
                    nemNullaDb++;
                }
            }
            double kitoltottseg = (double)nemNullaDb / hossz * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: "
                + kitoltottseg + "%");
            Console.WriteLine("7. feladat");
            Console.WriteLine("A kiválasztott feladvány kirajzolva:");
            lista[kivalasztottIndex].Kirajzol();

            Console.WriteLine("8. feladat");
            string fajlneve = "sudoku" + meret + ".txt";
            StreamWriter sw = new StreamWriter(fajlneve);
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Meret == meret)
                {
                    sw.WriteLine(lista[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("A kiválasztott méretűek kiírva a fájlba!");
            Console.WriteLine("A " + fajlneve + " állomány létrehozva ennyi sorral: " + meretDB);
            Console.ReadKey();
        }
    }
}