using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_contains
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" }; 
            if (lista.Contains("körte")) Console.WriteLine("Van körte");
            Console.ReadKey();
        }
    }
}
