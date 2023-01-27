using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            StreamReader sr = new StreamReader("@C:\\Users\\SarkadiKristofStefan\\Desktop\\sark.kris.stef\\22_11DC-\\Sarkadi Kristóf\\hiskola\\hiskola\\bin\\Debug")
            while (!sr.EndOfStream)
            {
                tanulok.Add(new Tanulo(sr.ReadLine));
            }
            sr.Close();
            Console.WriteLine("3. Feladat");
        }
    }
}
