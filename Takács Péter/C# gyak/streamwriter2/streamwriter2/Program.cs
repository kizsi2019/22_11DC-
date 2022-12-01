using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamwriter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\TakacsPeter\Desktop\github\22_11DC-\Takács Péter\C# gyak\streamwriter1\szöveg.txt"); 
            sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány"); 
            sw_elérésiúttal.Flush(); sw_elérésiúttal.Close(); 
        }
    }
}
