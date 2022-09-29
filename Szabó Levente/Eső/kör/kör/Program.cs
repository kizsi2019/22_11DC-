using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kör
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a kört.");
            int x = byte.Parse(Console.ReadLine());
            int k = 2 * x * Math.PI;
            Console.WriteLine(x * 3.14);
            Console.ReadKey();
        }
    }
}
