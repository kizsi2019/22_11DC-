using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hibakezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Baj van");
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
