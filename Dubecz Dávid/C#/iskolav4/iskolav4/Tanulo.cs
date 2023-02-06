using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolav4
{
    class Tanulo
    {
        public int ev { get; set; }
        public string osztaly { get; set; }
        public string nev { get; set; }

        public Tanulo(string sor)
        {
            string[] adatok = sor.Split(';');
            ev = int.Parse(adatok[0]);
            osztaly = adatok[1];
            nev = adatok[2];
        }
    }
}