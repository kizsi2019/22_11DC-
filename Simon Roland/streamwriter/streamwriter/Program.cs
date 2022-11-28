using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            sw_gyumolcsok.Flush();
            sw_gyumolcsok.Close();
        }
    }
}
