using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iskola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<tanulo> tanulok = new List<tanulo>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulok.Add(new tanulo(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3. feladat: Az iskolába {0} tanuló jár", tanulok.Count);

            Console.ReadKey();
        }
    }
}
