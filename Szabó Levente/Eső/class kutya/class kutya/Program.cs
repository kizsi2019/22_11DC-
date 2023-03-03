using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_kutya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e = new Ember();
            e.Név = "Tóth József"; e.Életkor = 32; e.Lakhely = "Eger"; e.Munkahely = "XYZ Kft.";
            Ember e2 = e;
            e2.Név = "Horvát Béla";
            Console.WriteLine(e.Név);
            e2.Kiír();
            Console.ReadKey();
        }
        class Ember
        {
            public string Név;
            public int Életkor;
            public string Lakhely;
            public string Munkahely;
            public void Kiír()
            {
                Console.WriteLine("Név: " + Név);
                Console.WriteLine("Életkor: " + Életkor);
                Console.WriteLine("Lakhely: " + Lakhely);
                Console.WriteLine("Munkahely: " + Munkahely);
            }
        }

    }
}
