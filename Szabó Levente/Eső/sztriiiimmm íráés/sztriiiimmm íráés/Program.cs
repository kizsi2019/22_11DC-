using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztriiiimmm_íráés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_elérésiúttal = new StreamWriter(@"D:\Saját\Fájlok\szöveg.txt");
            sw_elérésiúttal.WriteLine("Elérési úttal rendelkező szöveges állomány");
            sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
        }
    }
}
