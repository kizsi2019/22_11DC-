using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_contain__2022.XI._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            lista.Sort();
            if (lista.Contains("Körte")) Console.WriteLine("Van benne körte");
            Console.ReadKey();
        }
    }
}
