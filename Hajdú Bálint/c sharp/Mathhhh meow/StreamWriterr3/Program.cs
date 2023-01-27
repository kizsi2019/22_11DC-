using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_elérésiúttal = new StreamWriter (@"C:\Userss\BalintHajdu\Desktop\streamwriter1\bin\Debug");
            sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány");
            sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
            try
            {
                StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\BalintHajdu\Desktop\streamwriter1\bin\Debug");
                sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány");
                sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Nem található egy mappa, valószínűleg rossz elérési utat adott meg!");
            }
            catch (IOException)
            {
                Console.WriteLine("Hiba lépett fel a fájlírása közben!");
            }

        }
