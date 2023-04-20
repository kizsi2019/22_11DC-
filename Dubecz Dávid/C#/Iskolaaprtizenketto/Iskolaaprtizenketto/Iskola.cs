using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskolaaprtizenketto
{
    internal class Iskola
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }



        public Iskola(string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];
        }

        public int NevHossza
        {
            get
            {
                return Nev.Replace(" ", "").Length;
            }
        }
    }
}
