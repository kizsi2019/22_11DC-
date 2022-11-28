using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hahaha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stream Readersr = new StreamReader(@"C:\Felhasználók\RobenRomeo\Desktop\nevek.txt");
            List<string> nevek = new List<string>();
            while (!sr.EndOf Stream) {
                nevek.Add(sr.ReadLine()); }
            foreach (string item in nevek) {
                Console.WriteLine(item); }
            sr.Close();

            Console.ReadKey();
        }
    }
}
