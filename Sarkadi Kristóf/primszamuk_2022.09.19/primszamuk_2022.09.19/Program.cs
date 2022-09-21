using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primszamuk_2022._09._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 100; i++);
            {
                bool primszam = true;
                for (int j = 2; j < i && primszam; j++);
                {
                    if (i % j == 0) primszam = false;
                }
                if (primszam) Console.WriteLine(i);
            }
        }
    }
}
