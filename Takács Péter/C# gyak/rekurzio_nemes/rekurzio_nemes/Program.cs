using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio_nemes
{
    internal class Program
    {
        static int Variaciok_szama = 0;
        static void Main(string[] args)
        {
            Console.Write("Add meg at emeletek számát! ");
            int emeletekszama = int.Parse(Console.ReadLine());
            EmeletSzine("F", 1, ref emeletekszama);
            EmeletSzine("P", 1, ref emeletekszama);
            EmeletSzine("Z", 1, ref emeletekszama);
            Console.WriteLine("variációk száma: " + Variaciok_szama);
            Console.ReadKey();
        }
        static void EmeletSzine(string s, int emeleszam, ref int emeletszam_meddig)
        {
            if (emeletszam_meddig< emeletszam_meddig)
            {
                switch (s)
                {
                    case "P":
                        EmeletSzine("F", emeleszam + 1, ref emeletszam_meddig);
                        break;
                    case "F":
                        EmeletSzine("F", emeleszam + 1, ref emeletszam_meddig);
                        EmeletSzine("P", emeleszam + 1, ref emeletszam_meddig);
                        EmeletSzine("F", emeleszam + 1, ref emeletszam_meddig);
                        break;
                    case "Z":
                        EmeletSzine("F", emeleszam + 1, ref emeletszam_meddig);
                        EmeletSzine("P", emeleszam + 1, ref emeletszam_meddig);
                        break;
                }
            }
            else Variaciok_szama++;
        }
    }
}
