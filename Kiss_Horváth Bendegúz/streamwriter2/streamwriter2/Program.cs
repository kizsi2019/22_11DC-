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
            StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\BendegúzKiss-Horváth\source\repos\streamwriter1\streamwriter1\bin\Debug\szöveg.txt");
            sw_elérésiúttal.WriteLine("Elérési úttal rendelkező szöveges állomány");
            sw_elérésiúttal.Flush(); 
            sw_elérésiúttal.Close();
        }
    }
}
