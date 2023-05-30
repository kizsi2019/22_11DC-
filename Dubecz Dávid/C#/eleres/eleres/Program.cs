using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\DubeczDavidRaymundo\OneDrive - BGéSZC Katona József Technikum\Asztal\github\22_11DC-\Dubecz Dávid\stream\automatictext.txt");
                sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány");
                sw_elérésiúttal.Flush();
                sw_elérésiúttal.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Nem található egy mappa, valószínűleg rossz elérési utat adott meg!");
            }
            catch (IOException)
            {
                Console.WriteLine("Hiba lépett fel a fájl írása közben!");
            }
            //el ne felejtsük a puffert kiüríteni és a fájlt lezárni!
            Console.ReadKey();
        }
    }
}
