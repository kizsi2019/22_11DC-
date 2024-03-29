﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    internal class Tanulo1
    {
       public int Ev { get; set; }
       public string Osztaly { get; set; }
       public string Nev { get; set; }
       public Tanulo1(string sor)
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
       public string Azonosito
        {
            get
            {
                string azon = (Ev % 1000).ToString();
                azon += Osztaly;
                string[] nevek = Nev.ToLower().Split(' ');
                azon += nevek[0].Substring(0, 3);
                azon += nevek[1].Substring(0, 3);

                return azon;
            }
        }
    }
}
