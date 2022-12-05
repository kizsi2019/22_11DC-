using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivalasztas_pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\kivalasztas_pelda\kivalasztas_pelda\bin\Debug\vegeredmeny.txt");
            List<string> eredmeny = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmeny.Add(sr.ReadLine());
            }
            sr.Close();

            //Kiválasztás tétele
            Console.Write("Adja meg a versenyző nevét: ");
            string nev = Console.ReadLine();
            int i = 0;
            while (i < eredmeny.Count && eredmeny[i] != nev)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", nev, i + 1);
            Console.ReadKey();
        }
    }
}
