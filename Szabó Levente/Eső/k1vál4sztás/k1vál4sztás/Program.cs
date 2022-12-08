using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1vál4sztás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\\Users\\SzaboLeventeTamas\\Desktop\\Eső\\githab\\22_11DC-\\Szabó Levente\\Eső\\k1vál4sztás\árkéd.txt");
            List<string> eredmény = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmény.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();
            int i = 0;
            while (i < eredmény.Count && eredmény[i] != név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);
            Console.ReadKey();
        }
    }
}
