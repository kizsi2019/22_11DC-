using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamwriter2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\zsigm\OneDrive\Asztali gép\Github\22_11DC-\Kiss Zsigmond\c#\streamwriter2\szöveg.txt"); 
            sw_elérésiúttal.WriteLine("Ez egy másik szöveg"); 
            sw_elérésiúttal.Flush(); 
            sw_elérésiúttal.Close(); //el ne felejtsük a puffert kiüríteni és a fájlt lezárni!
        }
    }
}
