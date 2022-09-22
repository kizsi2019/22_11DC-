using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatultesztelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a jelszót!");
            string pswd;
            do
            {
                pswd = Console.ReadLine();
            } while (pswd != "123");
            Console.WriteLine("Sikeres belépés!");
            Console.ReadKey();
        }
    }
}
