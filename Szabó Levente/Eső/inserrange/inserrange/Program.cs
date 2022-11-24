using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inserrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>();
            lista.AddRange(tömb);
            foreach (var item in lista)
            {
                Console.WriteLine(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
