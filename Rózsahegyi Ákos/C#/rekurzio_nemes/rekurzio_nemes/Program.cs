using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio_nemes
{
    internal class Program
    {
        static int variacok_szama = 0;
        static void Main(string[] args)
        {
            int emeletekszama = int.Parse(Console.ReadLine());
            emeletszine("F", 1, ref emeletekszama);
            emeletszine("P", 1, ref emeletekszama);
            emeletszine("Z", 1, ref emeletekszama);
            Console.WriteLine(variacok_szama);
            Console.ReadKey();
        }

        static void emeletszine(string s, int emeletszam, ref int emeletszam_meddig)
        {
            if (emeletszam < emeletszam_meddig)
            {
                switch (s)
                {
                    case "P":
                        emeletszine("F", emeletszam + 1, ref emeletszam_meddig);
                        break;
                    case "F":
                        emeletszine("F", emeletszam + 1, ref emeletszam_meddig);
                        emeletszine("P", emeletszam + 1, ref emeletszam_meddig);
                        emeletszine("Z", emeletszam + 1, ref emeletszam_meddig);
                        break;
                    case "Z":
                        emeletszine("F", emeletszam + 1, ref emeletszam_meddig);
                        emeletszine("P", emeletszam + 1, ref emeletszam_meddig);
                        break;
                }
            }
            else variacok_szama++;
        }
    }
}
