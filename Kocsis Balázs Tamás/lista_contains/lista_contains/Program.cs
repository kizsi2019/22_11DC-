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
            List<string> lista = new List<string>() { "banan", "nem", "igen", "kote" };
            if (lista.Contains("kote")) Console.WriteLine("van kote");
            else
            {
                Console.WriteLine("nincs kote");
            }
            Console.ReadKey();
        }        
    }
}

