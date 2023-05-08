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
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült ");
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
                Console.WriteLine(" 5. feladat : Volt olyan nap, amikor nem készült dísz! ");
            }
            else
            { 
                Console.WriteLine("5. feladat: Volt olyan nap, amikor egy dísz sem készült ");
            }
            Console.WriteLine("6. feladat:");
            int nap;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            }
            while (nap < 1 || nap > 40);
            int harangok = 0, angyalok = 0, fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyalok += napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofak += napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap} nap végén {harangok} harang, {angyalok} angyalka és {fenyofak} fenyőfa maradt készleten. ");

            Console.Write("7. feladat: Legtöbbet eladott dísz: ");
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
            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if
                    (item.Value == max)
                    Console.WriteLine($"\t{item.Key}");
            }

            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb = 0;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap}:{disz.NapiBevetel()}");
                    legalabb++;
                }
            }
            sw.WriteLine($"{legalabb} napon volt legalább 10000 Ft a bevétel.\n");
            sw.Close();
            Console.ReadKey();
             
        }
    }
}
