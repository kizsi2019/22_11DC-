using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    internal class Program
    {
        struct Diák
        {
            public string nev;
            public int eletkor;
            public string lakhely;
            public List<int> jegyei;
            public Diák(string nev, int k, string h)
            {
                this.nev = nev; this.eletkor = k; this.lakhely = h; this.jegyei = null;
            }

            public void Kiir()
            {
                Console.WriteLine("Név: " + this.nev);
                Console.WriteLine("Életkor: " + this.eletkor);
                Console.WriteLine("Lakhely: " + this.lakhely);
                Console.Write("Jegyei: ");
                foreach (int item in this.jegyei)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("\nA diák átlaga: " + Atlag());
            }

            public double Atlag()
            {
                int osszeg = 0;
                foreach (int item in this.jegyei)
                {
                    osszeg += item;
                }
                return osszeg / (double)this.jegyei.Count;
            }
        }
        static void Main(string[] args)
        {
            Diák d = new Diák("András", 17, "Sopron");
            d.jegyei = new List<int>() { 4, 5, 3, 5, 5, 4 };
            Console.WriteLine("A diák adatai:");
            d.Kiir();
            Console.ReadKey();
        }
    }
}
