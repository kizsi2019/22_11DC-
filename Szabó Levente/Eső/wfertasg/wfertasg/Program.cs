using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfertasg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 1; i <= 5; i++) ;
            {
                int dobott = r.Next(1, 91);
                Console.WriteLine("A lottószám: "+ dobott);
            }
            Console.ReadKey();
        }
    }
}
