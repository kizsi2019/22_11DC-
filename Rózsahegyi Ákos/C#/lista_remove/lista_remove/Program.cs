using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() {5, 8, 11, 14};
            lista.Remove(8);
            
            foreach (int item in lista)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
