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
                Console.WriteLine("Volt oylan nap amikor nem készült dísz! ");
            }
            else
                Console.WriteLine("Nem volt olyan nap mikor egyetlen egy disz sem készült! ");
            Console.ReadKey();
        }
    }
}
