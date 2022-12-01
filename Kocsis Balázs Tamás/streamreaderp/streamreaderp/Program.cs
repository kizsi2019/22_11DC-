using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamreaderp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\KocsisBalazsTamas\Desktop\Github\22_11DC-\Kocsis Balázs Tamás\streamreaderp\nevsor.txt");
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
        }
    }
}
