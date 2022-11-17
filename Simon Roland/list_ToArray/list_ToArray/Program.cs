using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_ToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 20, 31, 10};
            int[] tömb = lista.ToArray();
            foreach (int i in tömb)
            {
                Console.WriteLine(i);
            }
        }
    }
}
