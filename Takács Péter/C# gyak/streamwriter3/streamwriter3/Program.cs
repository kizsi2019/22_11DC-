using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamwriter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                StreamWriter sw_elérésiúttal = new StreamWriter(@"C:\Users\TakacsPeter\Desktop\github\22_11DC-\Takács Péter\C# gyak\streamwriter1\szöveg.txt");
                sw_elérésiúttal.WriteLine("Elérésiúttal rendelkező szöveges állomány");
                sw_elérésiúttal.Flush(); sw_elérésiúttal.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Nem talalhato egy mappa, valószinüleg rossz eleleresi utat adott meg! ");
            }
            catch (IOException)
            {
                Console.WriteLine("Hiba lepett fel a fajl irasa kozben! ");
            }
            Console.ReadKey();
        }
    }
}
