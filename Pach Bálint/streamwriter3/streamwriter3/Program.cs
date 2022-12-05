using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw_elérésiúttal = new StreamWriter(@"D:\Saját\Fálok\szöveg.txt");
                sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány");
                sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Nem található egy mappa, valószínűleg rossz elérési utat adott meg!");
            }
            catch (IOException)
            {
                Console.WriteLine("Hiba lépett fel a fájl írása közben!");
            }
            Console.ReadKey(); 
        }
    }
}
