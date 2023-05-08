using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyiv2
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
                Console.WriteLine("4. feladat: Összesen {0} darab dísz készült.", NapiMunka.KeszultDb);

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
                    Console.WriteLine("5. feladat: Volt olyan nap, amikor egyetlen dísz sem készült.");
                }
                else
                {
                    Console.WriteLine("5. feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült.");
                }
                Console.ReadKey();
                sr.Close();
            }
    }
}
