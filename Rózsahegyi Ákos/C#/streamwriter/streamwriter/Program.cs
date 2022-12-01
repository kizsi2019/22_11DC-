using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_gyumolcsok = new StreamWriter("gyümölcsök.txt");
            sw_gyumolcsok.WriteLine("alma");
            sw_gyumolcsok.WriteLine("banán");
            sw_gyumolcsok.WriteLine("ananász");
            sw_gyumolcsok.WriteLine("körte");
            sw_gyumolcsok.Flush(); //puffer kiürítése
            sw_gyumolcsok.Close(); //adatfolyam lezárása
        }
    }
}
