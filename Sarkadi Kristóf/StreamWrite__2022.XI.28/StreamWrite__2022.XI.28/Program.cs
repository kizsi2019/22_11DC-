using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_write__2022.XI._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_gyumolcsok = new StreamWriter("gyömülcsök.txt");
            sw_gyumolcsok.WriteLine("alma");
            sw_gyumolcsok.WriteLine("banán");
            sw_gyumolcsok.WriteLine("ananász");
            sw_gyumolcsok.WriteLine("körte");
            sw_gyumolcsok.Flush(); //puffer kiürítése
            sw_gyumolcsok.Close(); //adatfolyam lezárása

        }
    }
}
