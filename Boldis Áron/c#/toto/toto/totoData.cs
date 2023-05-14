using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toto
{
    internal class totoData
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int Fordulo { get; set; }
        public double T13p1 { get; set; }
        public double Ny13p1 { get; set; }
        public string Eredmenyek { get; set; }

        public totoData(string line)
        {
            string[] splitted = line.Split(";");
            Ev = int.Parse(splitted[0]);
            Het = int.Parse(splitted[1]);
            Fordulo = int.Parse(splitted[2]);
            T13p1 = double.Parse(splitted[3]);
            Ny13p1 = double.Parse(splitted[4]);
            Eredmenyek = splitted[5];
        }

        public override string ToString()
        {
            string output = "";
            output += "\tÉv: ";
            output += Ev;
            output += "\nHét: ";
            output += Het;
            output += "\nForduló: ";
            output += Fordulo;
            output += "\nTelitalálat: ";
            output += T13p1;
            output += "db\nNyeremény: ";
            output += Ny13p1;
            output += "Ft\nEredmények: ";
            output += Eredmenyek;
            return output;
        }
    }
}
