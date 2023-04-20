using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace osszegzes_pelda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            StreamReader sr = new StreamReader("diszek.txt");

            while (!sr.EndOfStream) 
            { 
                Lista.Add(int.Parse(sr.ReadLine())); 
            }
            sr.Close();

            //összegzés tétele:
            int összes = 0;
            
            for (int i = 0; i < Lista.Count; i++) 
            {
                összes += Lista[i];
            } 
            Console.WriteLine("Ennyi karácsonyi díszt készítettek: " + összes);
            Console.ReadKey();
        }
    }
}
