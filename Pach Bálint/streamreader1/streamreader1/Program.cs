using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamreader1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:.txt");
            List<string> nevek = new List<string>();
            while (!sr.EndOfStream)
            {
                nevek.Add(sr.ReadLine());
            }
            foreach (string item in nevek)
            {
                Console.WriteLine(item);
            }
            sr.Close();
            Console.ReadKey(); 
        }
    }
}
