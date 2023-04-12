using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Iskola1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while(!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: Az iskolában {0} tanuló jár", tanulok.Count);
            Console.ReadKey();
            for (int i = 0; i < tanulok.Count; i++)
            {
                if (maxErtek < tanulok[i].NevHossza)
                {
                    maxErtek = tanulok[i].NevHossza;
                }
            }
            Console.WriteLine("4. feladat:a leghosszabb({0}karakter) nevű tanuló",maxErtek
                foreach (Tanulo item in tanulok)
            {
                if (item.NevHossza == maxErtek)
                {
                    Console.WriteLine("\t{0}",item.Nev);
                }
            }
            Console.ReadKey();
        }

    }
}
