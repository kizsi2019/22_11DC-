using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class OsztalyIskola
    {
        class IskolaClass
        {
            //adattagok
            private int ev;
            private string osztaly;
            private string nev;

            //konstruktor
            public IskolaClass(string sor)
            {
                string[] d = sor.Split(';');í
                ev = Convert.ToInt32(d[0]);
                osztaly = d[1];
                nev = d[2];
            }
        }
}   }

