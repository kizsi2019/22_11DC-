using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktura
{
    internal class Program
    {
        struct Diák
        {
            public string nev;
            public int eletkor;
            public string lakhely;
        }
        static void Main(string[] args)
        {
            Diák d = new Diák();
            d.nev = "Péter";
            d.lakhely = "Nyíregyháza";
            d.eletkor = 15;
            Console.WriteLine("Neve: " + d.nev);
        }
    }
}
