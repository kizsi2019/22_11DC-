using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eljarasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiír();
            int i = Osszeg();
            Console.WriteLine(i);
            Console.ReadKey();
            
        }
        static void Kiír()
        {
            Console.WriteLine("Ez kiír valamit a képernyőre ");
            Console.ReadKey();
        }
        static int Osszeg()
        {
            return 5 + 7;
        }
           
        
    }
}
