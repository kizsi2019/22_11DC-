using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolav3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iskola> tanulok = new List<iskola>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new iskola(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("tanulok: {0}", tanulok.Count);
        }
    }
}
