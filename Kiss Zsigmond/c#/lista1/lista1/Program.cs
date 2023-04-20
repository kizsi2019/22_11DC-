using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 10, 23, 4 }; 

            foreach (int item in lista) 
            { 
                Console.Write(item + ", "); 
            }
            Console.ReadKey();
        }
    }
}
