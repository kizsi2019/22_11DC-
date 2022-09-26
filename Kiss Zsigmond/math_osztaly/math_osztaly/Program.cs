using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace math_osztaly
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = -20.5; 
            //x = Math.Abs(x); //Megoldás: 20.5

            double x = 12.6; 
            x = Math.Ceiling(x); //Megoldás: 13


            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
