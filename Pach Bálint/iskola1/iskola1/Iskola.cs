using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola1
{
    internal class Iskola
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }

        public Iskola (string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];   
        }
        public string azonosito()
        {
            char evUtolso = Ev.ToString()[3];
            string vezNev = Nev.Substring(0, 3);
            string kerNev = Nev.Split(' ')[1].Substring(0, 3);
            return (evUtolso + Osztaly + vezNev + kerNev).ToLower(); 
        }

    }
}
