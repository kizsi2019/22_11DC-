using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class totoData
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int Fordulo { get; set; }
        public int T13p1 { get; set; }
        public int Ny13p1 { get; set; }
        public string Eredmenyek { get; set; }

        public totoData(string line)
        {
            string[] splitted = line.Split(' ');
            Ev = int.Parse(splitted[0]);
            Het = int.Parse(splitted[1]);
            Fordulo = int.Parse(splitted[2]);
            T13p1 = int.Parse(splitted[3]);
            Ny13p1 = int.Parse(splitted[4]);
            Eredmenyek = splitted[5];
        }
    }
}
