using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lácolast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");

            LinkedList<string> csomópont = new LinkedList<string>();
            Console.WriteLine(csomópont);

            foreach (string item in láncoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
