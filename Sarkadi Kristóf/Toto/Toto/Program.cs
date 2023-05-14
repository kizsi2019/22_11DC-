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
            string[] inputs = File.ReadAllLines("toto.txt");
            List<Totodata> database = new List<Totodata>();
            for (int i = 1; i < inputs.Length; i++)
            {
                Totodata temp = new Totodata(inputs[i]);
                database.Add(temp);
            }
            Console.WriteLine($"3.feladat: Fordulók száma: {database.Count }");
            double sum = 0;
            for (int i = 0; i < database.Count; i++)
            {
                sum += database[i].T13p1;
            }
            Console.WriteLine($"4.feladat: Telitalálatos szelvények száma: { sum }");
            List<double> item = new List<double>();
            for (int i = 0; i < database.Count; i++)
            {
                double temp = database[i].T13p1 * database[i].Ny13p1;
                if (temp > 0)
                {
                    item.Add(temp);
                }
            }
            double osszeg = item.Sum();
            double avg = osszeg / database.Count;
            Console.WriteLine($"5.feladat: Átlad: { avg } Ft");
            Console.ReadKey();
        }
    }
}
