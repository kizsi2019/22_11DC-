using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abszolut_ertek
{
    class Program
    {
        static int AbszolútÉrték(int szám)
        {
            return szám > 0 ? szám : szám * -1; 
            //feltétel ^ha nem, akkor a -1-szeresét // ^ha igaz, önmagát adjuk vissza
        }
            static void Main(string[] args)
        {
            Console.WriteLine(AbszolútÉrték(-10));
            Console.ReadKey();
        }
    }
}
