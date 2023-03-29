using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;

namespace toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("toto.txt");
            List<totoData> database = new List<totoData>();
            for (int i = 1; i < inputs.Length; i++)
            {
                totoData temp = new totoData(inputs[i]);
                database.Add(temp);
            }
            Console.WriteLine($"3. feladat: Fordulók száma: {database.Count}");
            double sum = 0;
            for (int i = 0; i < database.Count; i++)
            {
                sum += database[i].T13p1;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {sum}");
            List<double> items = new List<double>();
            for (int i = 0; i < database.Count; i++)
            {
                double temp = database[i].T13p1 * database[i].Ny13p1;
                if(temp > 0)
                {
                    items.Add(temp);
                }
            }
            double osszeg = items.Sum();
            double avg = Math.Round( osszeg / database.Count , 0);
            Console.WriteLine($"5. feladat: Átlag; {avg} Ft");
            int min = 0;
            int max = 0;
            while (database[min].Ny13p1 == 0)
            {
                min++;
            }
            for (int i = 1; i < database.Count; i++)
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
            Console.WriteLine($"6. feladat:\n\tLegnagyobb: {database[max]}\n\tLegkisebb:\n{database[min]}");

        }
    }
}
