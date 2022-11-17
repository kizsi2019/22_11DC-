using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            if (lista.Contains("körte"))
            {
                Console.WriteLine("Van körte :D");
            }
            if (lista.Contains("banán"))
            {
                Console.WriteLine("Van banán :D");
            }
            else
            {
                Console.WriteLine("Nincs körte :c");
            }
            Console.ReadKey();
        }
    }
}
