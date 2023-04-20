using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_insert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(); 
            lista.Add(12); 
            lista.Add(43); 
            lista.Add(2); 
            lista.Insert(1, 31);
            foreach (int item in lista) 
            { 
                Console.Write(item + ", "); 
            }
            Console.ReadKey();
        }
    }
}
