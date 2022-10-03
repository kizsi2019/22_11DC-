using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1000; i++)
            {
                bool primszam = true;
                for (int j = 2; j < i && primszam; j++)
                {
                    if (i % j == 0) primszam = false;
                }
                if (primszam) Console.WriteLine(i);
            }

        }
    }
}
