using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emelet_szine
{
    internal class Program
    {
        static int Variaciok_szama = 0;
        static void Main(string[] args)
        {
            Console.Write("Add meg az emeletek számát! ");
            int emeletekszama = int.Parse(Console.ReadLine());
            EmeletSzine("F", 1, ref emeletekszama);
            EmeletSzine("P", 1, ref emeletekszama);
            EmeletSzine("Z", 1, ref emeletekszama);
            Console.WriteLine("Variációk száma: "+ Variaciok_szama);
            Console.ReadKey();
        }
        static void EmeletSzine(string s, int emeletszama, ref int emeletszama_meddig)
        {
            if(emeletszama < emeletszama_meddig)
            {
                switch (s)
                {
                    case "P":
                        EmeletSzine("F", emeletszama + 1, ref emeletszama_meddig);
                        break;
                    case "F":
                        EmeletSzine("F", emeletszama + 1, ref emeletszama_meddig);
                        EmeletSzine("P", emeletszama + 1, ref emeletszama_meddig);
                        EmeletSzine("Z", emeletszama + 1, ref emeletszama_meddig);
                    case "Z":
                        EmeletSzine("F", emeletszama + 1, ref emeletszama_meddig);
                        EmeletSzine("P", emeletszama + 1, ref emeletszama_meddig);
                        break;


                }
            }
        }
    }
}
