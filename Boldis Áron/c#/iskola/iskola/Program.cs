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
            List<iskolaClass> tanulok = new List<iskolaClass>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new iskolaClass(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3. feladat: Az iskolába {0} tanuló jár", tanulok.Count);
        }
    }
}
