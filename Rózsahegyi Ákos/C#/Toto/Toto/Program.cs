using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\Toto\Toto\bin\Debug\toto.txt");
            List<totoData> database = new List<totoData>();
            for (int i = 1; i < inputs.Length; i++)
            {
                totoData temp = new totoData(inputs[i]);
                database.Add(temp);
            }

            Console.WriteLine("3. feladat: Fordulók száma: {0}", database.Count);

            double osszead = 0;
            for (int i = 0; i < database.Count; i++)
            {
                osszead += database[i].T13p1;
            }
            Console.WriteLine("4. feladat: Telitalálatos szelvények száma: {0}", osszead);

            List<double> items = new List<double>();
            for (int i = 0; i < database.Count; i++)
            {
                double temp = database[i].T13p1 * database[i].Ny13p1;
                if (temp > 0)
                {
                    items.Add(temp);
                }
            }
            double osszeg = items.Sum();
            double atlag = Math.Round(osszeg / database.Count, 0);
            Console.WriteLine("5. feladat: Átlag: {0} Ft", atlag);

            int min = 0;
            int max = 0;
            while (database[min].Ny13p1 == 0)
            {

            }
            for (int i = 0; i < database.Count; i++)
            {
                if (database[min].Ny13p1 > database[i].Ny13p1 && database[i].Ny13p1 != 0)
                {
                    min = i;
                }
                if (database[max].Ny13p1 < database[i].Ny13p1)
                {
                    max = i;
                }
            }
            Console.WriteLine($"6. feladat: \n\tLegnagyobb: \n{database[max]} \n\n\tLegkisebb: \n{database[min]}");
            Console.ReadKey();
        }
    }
}
