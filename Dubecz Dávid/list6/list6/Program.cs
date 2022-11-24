using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = lista.LastIndexOf("körte");

            if (index != -1)
            {
                Console.WriteLine("Van körte, indexe:" + index);
            }
            Console.ReadKey();

        }
    }
}
