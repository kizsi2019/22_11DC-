using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string azonosito()
        {
            char evutolso = Ev.ToString()[3];
            string veznev = Nev.Substring(0, 3);
            string kernev = Nev.Split(' ')[1].Substring(0, 3);
            return (evutolso + Osztaly + veznev + kernev).ToLower();
        }

    }
}
