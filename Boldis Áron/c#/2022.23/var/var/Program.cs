using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var szám = 2; //int
            var str = "string"; //string
            var valami; //hibás, hiszen nincs kezdőértéke
            str = 3; //hibás
            szám = 17; //jó
        }
    }
}
