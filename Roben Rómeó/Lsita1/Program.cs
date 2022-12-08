using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsita1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            foreach (int item in lista)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
