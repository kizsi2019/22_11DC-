using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banan", "ama", "kote", "nalanc"};
            lista.Sort();
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
