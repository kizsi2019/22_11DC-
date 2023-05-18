using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamwriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_gyumolcsok = new StreamWriter("gyümölcsök.txt"); 
            sw_gyumolcsok.WriteLine("alma"); //írás
            sw_gyumolcsok.WriteLine("banán"); 
            sw_gyumolcsok.WriteLine("ananász"); 
            sw_gyumolcsok.WriteLine("körte"); 
            sw_gyumolcsok.Flush(); //puffer kiürítése
            sw_gyumolcsok.Close(); //adatfolyam lezárása
        }
    }
}
