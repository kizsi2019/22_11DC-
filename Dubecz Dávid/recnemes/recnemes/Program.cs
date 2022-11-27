﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recnemes
{
    internal class Program
    {
        static int Variaciok_szama = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("add mneg az emeleteket ");
            int emeletekszama = int.Parse(Console.ReadLine());
            EmeletSzine("F", 1, ref emeletekszama);
            EmeletSzine("P", 1, ref emeletekszama);
            EmeletSzine("Z", 1, ref emeletekszama);
            Console.WriteLine("Variaciok szama: " + Variaciok_szama);
            Console.ReadKey();
        }
        static void EmeletSzine(string s, int emeletszam, ref int emeletszam_meddig)
        {
            if (emeletszam < emeletszam_meddig)
            {
                switch (s)
                {
                    case "P":
                        EmeletSzine("F", emeletszam + 1, ref emeletszam_meddig);
                        break;
                    case "F":
                        EmeletSzine("F", emeletszam + 1, ref emeletszam_meddig);
                        EmeletSzine("P", emeletszam + 1, ref emeletszam_meddig);
                        EmeletSzine("Z", emeletszam + 1, ref emeletszam_meddig);
                        break;
                    case "Z":
                        EmeletSzine("F", emeletszam + 1, ref emeletszam_meddig);
                        EmeletSzine("P", emeletszam + 1, ref emeletszam_meddig);
                        break;
                }
            }
            else Variaciok_szama++;
        }
    }
}
