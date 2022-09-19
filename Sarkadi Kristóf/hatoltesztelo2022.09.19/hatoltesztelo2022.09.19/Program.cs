using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatoltesztelo2022._09._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy jelszót");
            string pswd;
            do
            {
                pswd = Console.ReadLine();
            } while (pswd != "Koxy100101");
            Console.WriteLine("Sikeres belépés");
            Console.ReadKey();
        }
    }
}
