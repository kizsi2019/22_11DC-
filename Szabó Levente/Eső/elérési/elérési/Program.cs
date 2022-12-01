using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elérési
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\SzaboLeventeTamas\Desktop\Eső\githab\22_11DC-\Szabó Levente\Eső\elérési\Eső.txt");
            sw_elérésiúttal.WriteLine("Eső esik");
            sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
        }
    }
}
