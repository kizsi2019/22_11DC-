using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Karácsonyi_díszek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkaLista = new List<NapiMunka>();
            foreach(string sor in File.ReadLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült");
            bool nemKeszultDisz = false;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
            {
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nam, amikor egyetlen dísz sem készült" );
            }
            Console.WriteLine("6.feladat: ");
            int nap;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harangok = 0, angyalok = 0, fenyofak = 0;
            for (int i = 0; 1 < nap; i++)
            {
                harangok = napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyalok = napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofak = napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}, nap végén {harangok} harangok, {angyalok} angyol és {fenyofak} fenyőfa");
            Console.WriteLine("7.feladat: ");
            Dictionary<string, int> eladott = new Dictionary<string, int>();
            eladott.Add("Harang", 0);
            eladott.Add("Angyalka", 0);
            eladott.Add("Fenyöfa", 0);
            foreach (NapiMunka disz in napiMunkaLista)
            {
                eladott["Harang"] -= disz.HarangEladott;
                eladott["Angyalka"] -= disz.AngyalkaEladott;
                eladott["Fenyőfa"] -= disz.FenyofaEladott;
            }
            int max = eladott.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladott)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine();
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legnagyobb10000 = 0;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.NapiBevetel() == 10000)
                {
                    sw.WriteLine("{0} : {1}", disz.Nap, disz.NapiBevetel());
                }
            }
            sw.WriteLine($"{legnagyobb10000} napon volt legalább 10000 Ft a bevétel.\n");
            Console.ReadKey();
        }
    }
}
