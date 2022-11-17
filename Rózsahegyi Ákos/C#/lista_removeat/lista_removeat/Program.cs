using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_removeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 12, 24, 36, 48 };
            lista.RemoveAt(3);

            foreach (int item in lista)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
