using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkaLista = new List<NapiMunka>();
            StreamReader sr = new StreamReader("diszek.txt");
            while (!sr.EndOfStream)
            {
                napiMunkaLista.Add(new NapiMunka(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("4.feladat: Összesen {0} darab dísz készült.", NapiMunka.KeszultDb);
            
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
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült.");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            Console.WriteLine("6.feladat:");
            int napSzam;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1 ... 40]: ");
                napSzam = int.Parse(Console.ReadLine());
            } while (napSzam < 1 || napSzam > 40);

            int harangok = 0, angyalok = 0, fenyofak = 0;
            for (int i = 0; i < napSzam; i++)
            {
                harangok = napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyalok = napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofak = napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine("\tA(z) {0}. nap végén {1} harang, {2} angyalka és {3} fenyőfa maradt készleten.", napSzam, harangok, angyalok, fenyofak);

            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach (NapiMunka disz in napiMunkaLista)
            {
                eladottak["Harang"] -= disz.HarangEladott;
                eladottak["Angyalka"] -= disz.AngyalkaEladott;
                eladottak["Fenyőfa"] -= disz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine("7.feladat: Legtöbbet eladott dísz: {0} darab", max);
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine("\t{0}", item.Key);
                }
            }
            Console.WriteLine();

            StreamWriter sw = new StreamWriter("bevetel.txt");
            int tizezres = 0;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine("{0}:{1}", disz.Nap, disz.NapiBevetel());
                    tizezres++;
                }
            }
            sw.WriteLine("{0} napon volt legalább 10000 Ft a bevétel.\n", tizezres);
            sw.Close();
            Console.ReadKey();
        }
    }
}
