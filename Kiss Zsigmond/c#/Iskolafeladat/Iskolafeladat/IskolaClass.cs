using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskolafeladat
{
    class IskolaClass
    {
        // adattagok
        public int ev { get; private set; }
        public string osztaly { get; private set; }
        public string nev { get; private set; }

        // konstruktor
        public IskolaClass(string sor)
        {
            string[] d = sor.Split(';');
            ev = Convert.ToInt32(d[0]);
            osztaly = d[1];
            nev = d[2];
        }
        public string azonosito()
        {
            char evUtolso = ev.ToString()[3];
            string vezNev = nev.Substring(0, 3);
            string kerNev = nev.Split(' ')[1].Substring(0, 3);
            return (evUtolso + osztaly + vezNev + kerNev).ToLower();

        }
        
    }
}
