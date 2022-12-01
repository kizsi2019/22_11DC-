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
            StreamWriter sw_gyumolcsok = new StreamWriter(@"C:\Users\SimonRoland\Desktop\Github\22_11DC-\Simon Roland\streamwriter\szöveg.txt");
            sw_gyumolcsok.WriteLine("Elérési úttal rendelkező szöveges állomány");
            sw_gyumolcsok.Flush();
            sw_gyumolcsok.Close();
        }
    }
}
