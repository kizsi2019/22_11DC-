using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzes_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            StreamReader sr = new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\osszegzes_pelda\osszegzes_pelda\bin\Debug\diszek.txt");
            while (!sr.EndOfStream)
            {
                lista.Add(int.Parse(sr.ReadLine()));
            }
            sr.Close();

            int osszes = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszes += lista[i];
            }
            Console.WriteLine("Ennyi karácsonyi díszt készítettek: " + osszes);
            Console.ReadKey();
        }
    }
}
