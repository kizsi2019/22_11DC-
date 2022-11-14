using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekuzio_nemes
{
    internal class Program
    {
        static int Variaciok_szama = 0;
        static void Main(string[] args)
        {
            Console.Write("Add meg az emeletek számát! ");
            int emeletekszama = int.Parse(Console.ReadLine());
            Emeletekszine("F", 1, ref emeletekszama);
            Emeletekszine("P", 1, ref emeletekszama);
            Emeletekszine("Z", 1, ref emeletekszama);
            Console.WriteLine("Variációk száma: " + Variaciok_szama);
        }
        static void Emeletekszine(string s, int emeletekszama, ref emeletekszam_meddig)
        {
            if (emeletszam < emeletszam_meddig)
            {
                switch (s)
                {
                    case "P":
                        Emeletekszine("F", emeletszam + 1, ref emeletekszam_meddig);
                        break;
                    case "Z":
                        Emeletekszine("F", emeletszam + 1);
                        Emeletekszine();
                        Emeletekszine();
                        break;
                }
            }
        }
    }
}
