using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola1
{
    internal class tanulo
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }

        public tanulo(string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];
        }
    }
}
