using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola2
{
    internal class IskolaClass
    {
        private int ev;
        private string osztaly;
        private string nev;

        //konstruktor
        public IskolaClass(string sor)
        {
            string[] d = sor.Split(';');
            ev = Convert.ToInt32(d[0]);
            osztaly = d[1];
            nev = d[2];
        }

        public int Ev { get => ev; set => ev = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public string Nev { get => nev; set => nev = value; }
    }
}
