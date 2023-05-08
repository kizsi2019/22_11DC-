using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> NapiMunkaLista = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                NapiMunkaLista.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült");
            bool NemKeszultDisz = false;
            foreach (NapiMunka disz in NapiMunkaLista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    NemKeszultDisz = true;
                    break;
                }
            }
            if (NemKeszultDisz)
            {
                Console.WriteLine("Volt olyan nap amikor nem készült dísz");
            }
            else
            {
                Console.WriteLine("Nem volt olyan nap amikor nem készült dísz");
            }
            Console.WriteLine("6.feladat");
            int nap;
            do
            {
                Console.Write("Adja meg a keresett napot[1-40]");
                nap = int.Parse(Console.ReadLine());
            }
            while (nap < 1 || nap > 40);
            int harangok = 0, angyalok = 0, fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += NapiMunkaLista[i].HarangKesz + NapiMunkaLista[i].HarangEladott;
                angyalok += NapiMunkaLista[i].AngyalkaKesz + NapiMunkaLista[i].AngyalkaEladott;
                fenyofak += NapiMunkaLista[i].FenyofaKesz + NapiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"A(z) {nap}. nap végén {harangok} harang, {angyalok} angyalka, és {fenyofak} fenyőfa maradt készleten.");

            Console.Write("7.feladat: Legtöbb eladott dísz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach (NapiMunka disz in NapiMunkaLista)
            {
                eladottak["Harang"] -= disz.HarangEladott;
                eladottak["Angyalka"] -= disz.AngyalkaEladott;
                eladottak["Fenyőfa"] -= disz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t {item.Key}");
                }
            }

            Console.WriteLine();

            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka disz in NapiMunkaLista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap}:{disz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon volt legalább 10000ft a bevétel.\n");
            sw.Close();

            Console.ReadKey();
        }
    }
}
