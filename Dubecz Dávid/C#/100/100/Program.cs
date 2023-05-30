using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = 102;
            while (szam >= 2)
             {
                szam--;
                if (szam % 2 == 0)
                {
                    Console.WriteLine(szam);
                }
            }
            Console.ReadKey();
        }
    }
}
