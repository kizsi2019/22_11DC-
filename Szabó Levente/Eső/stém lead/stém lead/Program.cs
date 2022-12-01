using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stém_lead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\SzaboLeventeTamas\Desktop\Eső\githab\22_11DC-\Szabó Levente\Eső\stém lead\zzzzzz.txt");
            sw_elérésiúttal.WriteLine("");
            sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();

            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\zolcsyx\Desktop\nevek.txt");
                List<string> nevek = new List<string>();
                while (!sr.EndOfStream)
                {
                    nevek.Add(sr.ReadLine());
                }
                foreach (string item in nevek)
                {
                    Console.WriteLine(item);
                }
                sr.Close();
            }
            catch (FileNotFoundException) { Console.WriteLine("Nem található a fájl!"); }
            catch (IOException) { Console.WriteLine("Hiba keletkezett a fájl olvasása közben!"); }

        }
    }
}
