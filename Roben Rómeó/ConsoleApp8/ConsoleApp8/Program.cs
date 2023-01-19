using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        
        
            static int AbszolútÉrték(int szám)
            {
                return szám > 0 ? szám : szám * -1;
            }
            static void Main(string[] args)
        {
            Console.WriteLine(AbszolútÉrték(-10));
            Console.ReadKey();
        }
            
    }
}
