using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ember
{
    internal class Program
    {
        class ember
        {
            public string nev;
            public int eletkor;
            public string lakhely;
            public string munkahely;
            public void Kiír()
            {
                Console.WriteLine("Név: " + nev);
                Console.WriteLine("Életkor: " + eletkor);
                Console.WriteLine("Lakhely: " + lakhely);
                Console.WriteLine("Munkahely: " + munkahely);
            }
        }
        static void Main(string[] args)
        {
            ember e = new ember();
            e.nev = "Tóth József";
            e.eletkor = 32;
            e.lakhely = "Eger";
            e.munkahely = "XYZ Kft.";
            ember e2 = e;
            e2.nev = "Nagy Árpi";
            Console.WriteLine(e.nev);
            Console.WriteLine(e2.nev);
            e2.Kiír();
            Console.ReadKey();
        }
    }
}
