using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class Tanulo
    {
        public int Ev { get; private set; }
        public string Osztaly { get; private set; }
        public string Nev { get; private set; }
        public Tanulo(string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];
        }
    }
}
