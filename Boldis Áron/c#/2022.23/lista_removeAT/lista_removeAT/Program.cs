using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_removeAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 10, 23, 4, 30 };
            lista.RemoveAt(2);
            foreach (int i in lista)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();
        }
    }
}
