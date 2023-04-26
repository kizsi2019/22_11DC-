using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

 

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkalista = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkalista.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4. fealadat: összesen {NapiMunka.KeszultDb} darab dísz készült");
            bool nemKeszultDisz = false;
            foreach (NapiMunka disz in napiMunkalista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
            {
                Console.WriteLine("Volt olyan nap amikor nem készült dísz! ");
            }
            else
                Console.WriteLine("Nem volt olyan nap mikor egyetlen egy disz sem készült! ");
            Console.WriteLine("6. feladat:");
            int nap;
            do
            {
                Console.Write("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            }
            while (nap < 1 || nap > 40) ;
            int harangok = 0, angyalok = 0, fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += napiMunkalista[i].HarangKesz + napiMunkalista[i].HarangEladott;
                angyalok += napiMunkalista[i].AngyalkaKesz + napiMunkalista[i].AngyalkaEladott;
                fenyofak += napiMunkalista[i].FenyofaKesz + napiMunkalista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap} nap végén {harangok} harang, {angyalok} angyal és {fenyofak} fenyöfák maradtak készleten. ");

 

            Console.Write("7. fealadat: legtöbbet eladott dísz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach (NapiMunka disz in napiMunkalista)
            {
                eladottak["Harang"] -= disz.HarangEladott;
                eladottak["Angyalka"] -= disz.HarangEladott;
                eladottak["Fenyőfa"] -= disz.HarangEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                    Console.WriteLine($"\t{item.Key}");
            }
            Console.WriteLine();

 

            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka disz in napiMunkalista)
            {
                if (disz.NapiBevetel() >= 10000) ;
                {
                    sw.WriteLine($"{disz.Nap}:{disz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon volt legalabb 10000 Ft a bevétel.\n");
            sw.Close();
            Console.ReadKey();
        }
    }
}