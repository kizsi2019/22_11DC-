using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamreader1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\zsigm\OneDrive\Asztali gép\Github\22_11DC-\Kiss Zsigmond\c#\streamreader1\nevsor.txt"); 
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
