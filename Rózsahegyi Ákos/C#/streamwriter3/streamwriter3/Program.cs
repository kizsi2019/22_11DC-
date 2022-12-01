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
                StreamWriter sw_gyumolcsok = new StreamWriter(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Áko\C#\streamwriter\szöveg.txt");
                sw_gyumolcsok.WriteLine("Ez egy másik szöveg");
                sw_gyumolcsok.Flush();
                sw_gyumolcsok.Close();
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
