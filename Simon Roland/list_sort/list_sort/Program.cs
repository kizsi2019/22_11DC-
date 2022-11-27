using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte" , "narancs", "kiwi"};
            lista.Sort();
            foreach (string i in lista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
