using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok list = new List<Tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3. feladat: {0} tanuló jár ide", tanulok.Count);
        }
    }
}
