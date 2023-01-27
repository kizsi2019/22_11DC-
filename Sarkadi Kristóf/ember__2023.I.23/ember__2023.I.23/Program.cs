using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ember__2023.I._23
{
    internal class Program
    {
        class Ember
        {
            public string nev;
            public int eletkor;
            public string lakhely;
            public string munkahely;
        }
        static void Main(string[] args)
        {
            Ember e = new Ember();
            e.nev = "Thót József";
            e.eletkor = 32;
            e.lakhely = "XYZ Kft.";
        }
    }
}
