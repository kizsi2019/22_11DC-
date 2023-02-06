using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3. feladat : sz iskolába {0} tanuló jár", tanulok.Count);
            Console.ReadKey();

            Console.WriteLine("4. feladat: ");
            int maxNevhossz = int.MinValue;
            int sokozSzam = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                sokozSzam = tanulok[i].Nev.Split(' ').Length - 1;
                if (tanulok[i].Nev.Length-sokozSzam > maxNevhossz)
                {
                    maxNevhossz = tanulok[i].Nev.Length - sokozSzam;
                }
            }
            Console.WriteLine("Maximális karakterek szama: "+ maxNevhossz);
            for(int i = 0; i < tanulok.Count; i++)
            {
                if (tanulok[i].Nev.Length - sokozSzam == maxNevhossz)
                {
                    Console.WriteLine(tanulok[i].Nev);
                }
            }
            Console.ReadKey();
        }
    }
}
