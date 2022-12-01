using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwriter4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\TakacsPeter\Desktop\github\22_11DC-\Takács Péter\C# gyak\streamwriter4\apád.txt"); 
            List<string> nevek = new List<string>(); 
            while (!sr.EndOfStream) { nevek.Add(sr.ReadLine()); }
            foreach (string item in nevek) { Console.WriteLine(item); }
            sr.Close();
            Console.ReadKey();
        }
    }
}
