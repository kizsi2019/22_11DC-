using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class iskola
    {
        public int Ev { get; set; }
        public string Osztaly { get; set; }
        public string Nev { get; set; }
        public iskola(string sor)
        {
            string[] d = sor.Split(';');
            Ev = Convert.ToInt32(d[0]);
            Osztaly = d[1];
            Nev = d[2];
        }
    }
}
