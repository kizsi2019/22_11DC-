using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj jelszot");
            string passw;
            do
            {
                passw = Console.ReadLine();
            }
            while (passw != "123");
            Console.WriteLine("Sikeres login");
            Console.ReadKey();
        }
    }
}
