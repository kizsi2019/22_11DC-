using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eső2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi a jelszó.");
            string pswd = "123";
            do
            {
                pswd = Console.ReadLine();
            } while (pswd != "123");
            Console.WriteLine("Sikeres bejelntkezés");
            Console.ReadKey();
        }
    }
}
