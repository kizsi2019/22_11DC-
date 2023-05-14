using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace iskola
{
    class Tanulo
    {
        public int Ev { get; private set; }
        public string Osztaly { get; private set; }
        public string Nev { get; private set; }

        public Tanulo(string sor)
        {
            //2006;c;Bodnar Szilvia
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztaly = adatok[1];
            Nev = adatok[2];
        }
        public string azonosító()
        {
            char evUtolso = Ev.ToString()[3];
            string vezNev = Nev.Substring(0, 3);
            string kerNev = Nev.Split(' ')[1].Substring(0, 3);
            return (evUtolso + Osztaly + vezNev +kerNev).ToLower();
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
