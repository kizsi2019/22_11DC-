using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktura1
{
    class Program
    {
        struct Diák 
        { 
            public string név; 
            public int életkor; 
            public string lakhely; 
        }
        static void Main(string[] args)
        {
            Diák d = new Diák(); 
            d.név = "Péter"; 
            d.lakhely = "Nyíregyháza"; 
            d.életkor = 15; 
            Console.WriteLine("Neve: " + d.név);
            Console.ReadKey();

        }
    }
}
