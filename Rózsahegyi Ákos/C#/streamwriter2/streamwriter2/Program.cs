using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_gyumolcsok = new StreamWriter(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\streamwriter\szöveg.txt");
            sw_gyumolcsok.WriteLine("Ez egy másik szöveg");
            sw_gyumolcsok.Flush();
            sw_gyumolcsok.Close();
        }
    }
}
