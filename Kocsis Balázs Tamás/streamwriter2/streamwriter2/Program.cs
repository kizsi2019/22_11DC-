using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_gyumolcsok = new StreamWriter(@"C:\Users\KocsisBalazsTamas\Desktop\Github\22_11DC-\Kocsis Balázs Tamás\streamwriter2\szöveg.txt");
            sw_gyumolcsok.WriteLine("Ez egy masik szoveg");            
            sw_gyumolcsok.Flush();
            sw_gyumolcsok.Close();
        }
    }
}
