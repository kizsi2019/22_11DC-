using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolav3
{
    class Iskola2
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }

        public Iskola2 {string sor}
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);

            Osztaly = adatok[1];

            Nev = adatok[2];
        }
    }

}
