using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hátultesztelő
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a jelszót! ");
            string passw;
            do
            {
                passw = Console.ReadLine();
            } while (passw != "123");
            Console.WriteLine("Sikeres belépés! ");
            Console.ReadKey();
        }
    }
}
