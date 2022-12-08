using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_gyumolcsok = new StreamWriter(@"C:\Users\BalintHajdu\Desktop\streamwriter1\bin\Debug");
            sw_gyumolcsok.WriteLine("Elérési uttal rendelkező szöveges állomány");
            sw_gyumolcsok.Flush();
            sw_gyumolcsok.Close();

        }
    }
}
