using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { StreamReader sr = new StreamReader(@"C:\Users\zolcsyx\Desktop\nevek.txt")
                    List<string> nevek = new List<string>();
                while (!sr.EndOfStream) { nevek.Add(sr.ReadLine());
                }
                foreach (string item in nevek) {
                    Console.WriteLine(item);
                }
                sr.Close();
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Nem található a fájl!");
            }
            catch (IOException) 
            {
                Console.WriteLine("Hiba keletkezett a fájl olvasása közben!"); }

            Console.ReadKey();
        }
    }
}
