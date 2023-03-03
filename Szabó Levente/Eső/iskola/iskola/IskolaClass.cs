using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class IskolaClass
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }
        public IskolaClass(string sor)
        {
            string[] d = sor.Split(';');
            Ev = Convert.ToInt32(d[0]);
            Osztaly = d[1];
            Nev = d[2];
        }
        public string azonosito()
        {
            char evUtolso = Ev.ToString()[3];
            string vezNev = Nev.Substring(0, 3);
            string kerNev = Nev.Split(' ')[1].Substring(0, 3);
            return (evUtolso + Osztaly +vezNev + kerNev).ToLower();
        }
    }
}

