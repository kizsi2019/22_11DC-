using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola1
{
    internal class Tanulo
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }
        public Tanulo(sor)
        {
            string[] adatok = sor.split(";");
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];
        }
    }
}
