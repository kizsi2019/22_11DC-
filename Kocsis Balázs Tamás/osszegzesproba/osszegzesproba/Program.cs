using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszegzesproba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            StreamReader sr = new StreamReader("díszek.txt");
            while (!sr.EndOfStream)
            {
                Lista.Add(int.Parse(sr.ReadLine()));
            }
            sr.Close();
            int összes = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                összes+= Lista[i];
            }
            Console.WriteLine("Ennyi karácsonyi díszt készítettek: " + összes);
            Console.ReadKey();
        }
    }
}
