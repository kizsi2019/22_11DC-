using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futoverseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("vegeredmeny.txt");
            List<string> eredmeny = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmeny.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            string nev = Console.ReadLine();
            int i = 0;
            while (i < eredmeny.Count && eredmeny[i] != nev)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", nev, i + 1);
          
        }
    }
}
