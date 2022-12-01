using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamreader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\GITHUB\22_11DC-\Rózsahegyi Ákos\C#\streamreader\nevsor.txt");
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
