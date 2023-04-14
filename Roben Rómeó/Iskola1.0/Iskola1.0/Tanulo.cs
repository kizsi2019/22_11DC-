using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola1._0
{
    internal class Tanulo
    {
        public int Ev { get; set; }
        public string Osztály { get; set; }
        public string Nev { get; set; }
        public Tanulo(string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Osztály = adatok[1];
            Nev = adatok[2];
        }
        public int NevHossza
        {
            get
            {
                return Nev.Replace(" "," ").Length;
            }
        }


    }
}
