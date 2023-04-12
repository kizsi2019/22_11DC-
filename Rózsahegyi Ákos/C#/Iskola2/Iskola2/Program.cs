using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Iskola2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Iskola> tanulok = new List<Iskola>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Iskola(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: Az iskolába {tanulok.Count} tanuló jár");
        }
    }
}
